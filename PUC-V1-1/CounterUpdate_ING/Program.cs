using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CounterUpdate_ING
{
    class Program
    {
        static private ADODB.Recordset rs = new ADODB.Recordset();
        static private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        static private List<string> emails = ConfigurationManager.AppSettings["email"].Split(';').ToList();
        static private string usp_Update = ConfigurationManager.AppSettings["usp_Update"];
        static private string Database_Server = ConfigurationManager.AppSettings["Database_Server"];
        static private string Database_Name = ConfigurationManager.AppSettings["Database_Name"];

        static List<string> notRegisteredMachine = new List<string>();
        static List<string> RegisteredMachine_no_detail = new List<string>();
        static void Main(string[] args)
        {
            var section = (Hashtable)ConfigurationManager.GetSection("Config");
            Dictionary<string, string> dictionary = section.Cast<DictionaryEntry>().ToDictionary(d => (string)d.Key, d => (string)d.Value);
            var listKey = dictionary.Keys.ToList();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            var endTime = DateTime.Now;
            var startTime = endTime.AddHours(-0.25);
            DataTable dt1 = new DataTable();
            JEMS_3.QM_TestData qmt = new JEMS_3.QM_TestData();
            rs = qmt.GetTestsForDateRange(Database_Server, Database_Name, 6511, startTime.ToString(), endTime.ToString());
            rs.Filter = "TestStep_ID ='10' OR TestStep_ID ='12'";
            dataAdapter.Fill(dt1, rs);
            dt1 = dt1.AsEnumerable().Where(d => d.Field<Int32>("Customer_ID") == 4).CopyToDataTable();
            var count = dt1.Rows.Count;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                //Console.WriteLine(dt1.Rows[i]["SerialNumber"] + "|" + dt1.Rows[i]["TestEquipment"] + "|" + dt1.Rows[i]["TestRoute"] + "|" + dt1.Rows[i]["TestRouteStep"] + "|" + dt1.Rows[i]["TestStartDateTime"] + "|" + dt1.Rows[i]["TestEndDateTime"] + "|" + dt1.Rows[i]["Customer_ID"] + "|" + dt1.Rows[i]["Customer"]);
                var testStep = dt1.Rows[i]["TestRouteStep"].ToString().Split(' ').LastOrDefault();
                var customer_ID = dt1.Rows[i]["Customer_ID"].ToString();
                //string test = dt1.Rows[i]["TestEquipment"].ToString();
                string testEquipment = dt1.Rows[i]["TestEquipment"].ToString().Split(' ').LastOrDefault();

                //if ((dictionary.ContainsKey(testStep) && dictionary[testStep] == customer_ID) || (dictionary.ContainsKey(testEquipment) && dictionary[testEquipment] == customer_ID))
                //{
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(usp_Update, conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@in_fixtureId", testEquipment);
                        command.Parameters.AddWithValue("@out_result", 0).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        int out_result = Convert.ToInt32(command.Parameters["@out_result"].Value);
                        if (out_result == 2)
                        {
                            if (!notRegisteredMachine.Contains(testEquipment))
                            {
                                notRegisteredMachine.Add(testEquipment);
                            }
                        }
                        else if (out_result == 3)
                        {
                            if (!RegisteredMachine_no_detail.Contains(testEquipment))
                            {
                                RegisteredMachine_no_detail.Add(testEquipment);
                            }
                        }
                        conn.Close();
                    }
                //}
            }
            notRegisteredMachine.Sort();

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");

            var emailContent = "<p>List of machine that not registered in the PUC system <p/><table> <tr style='background-color:cyan'> Equipment Name </tr>";

            for (int i = 0; i < notRegisteredMachine.Count; i++)
            {
                emailContent += "<tr>" + notRegisteredMachine[i] + "</tr>";
            }
            emailContent += "</table>";
            emailContent += "<hr/>";
            emailContent += "<p>List of machine that registered in the PUC system without detail part<p/><table> <tr style='background-color:cyan'> Equipment Name </tr>";
            for (int i = 0; i < RegisteredMachine_no_detail.Count; i++)
            {
                emailContent += "<tr>" + RegisteredMachine_no_detail[i] + "</tr>";
            }
            emailContent += "</table>";
            message.From = new MailAddress("PUC@Jabil.com");
            foreach (var email in emails)
            {
                if (email != "")
                {
                    message.To.Add(new MailAddress(email));
                }
            }
            message.Subject = "[ING] PUC";
            message.Body = emailContent;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
    }
}

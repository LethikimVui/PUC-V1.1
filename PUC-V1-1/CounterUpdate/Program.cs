using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CounterUpdate
{
    class Program
    {
        static private ADODB.Recordset rs = new ADODB.Recordset();
        //private ADODB.Connection cnn = new ADODB.Connection(); 
        static private string connectionString = "Data Source=VNHCMC0SQL81;Database=PUC;User Id=PUC_USER;Password=PUC!@#123;MultipleActiveResultSets=true;";
        static List<string> notRegisteredMachine = new List<string>();
        static List<string> RegisteredMachine_no_detail = new List<string>();
        static List<string> list = new List<string>()
            {
                "BFT",
                "RFT",
                "CONFIG",
                "DTT",
                "CST",
                "APTC"
            };
        static void Main(string[] args)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            var endTime = DateTime.Now;
            var startTime = endTime.AddHours(-0.5);
            DataTable dt1 = new DataTable();

            JEMS_3.QM_TestData qmt = new JEMS_3.QM_TestData();
            rs = qmt.GetTestsForDateRange("VNHCMM0MSSQLV1A", "JEMS", 6511, startTime.ToString(), endTime.ToString());
            dataAdapter.Fill(dt1, rs);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                //Console.WriteLine(dt1.Rows[i]["SerialNumber"] + "|" + dt1.Rows[i]["TestEquipment"] + "|" + dt1.Rows[i]["TestRoute"] + "|" + dt1.Rows[i]["TestRouteStep"] + "|" + dt1.Rows[i]["TestStartDateTime"] + "|" + dt1.Rows[i]["TestEndDateTime"]);
                var testStep = dt1.Rows[i]["TestRouteStep"].ToString().Split(' ').LastOrDefault();
                if (list.Contains(testStep))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("usp_Main_Usedtimes_Update", conn);
                        string TestEquipment = dt1.Rows[i]["TestEquipment"].ToString().Split(' ').LastOrDefault();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@in_machineName", TestEquipment);
                        command.Parameters.AddWithValue("@out_result", 0).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        int out_result = Convert.ToInt32(command.Parameters["@out_result"].Value);
                        if (out_result == 2)
                        {
                            if (!notRegisteredMachine.Contains(TestEquipment))
                            {
                                notRegisteredMachine.Add(TestEquipment);
                            }
                        }
                        else if (out_result == 3)
                        {
                            if (!RegisteredMachine_no_detail.Contains(TestEquipment))
                            {
                                RegisteredMachine_no_detail.Add(TestEquipment);
                            }
                        }
                        conn.Close();
                    }
                }
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
            message.To.Add(new MailAddress("vui_le@Jabil.com"));
            message.Subject = "PUC";
            message.Body = emailContent;
            message.IsBodyHtml = true;
            smtp.Send(message);

            //Console.WriteLine(list.ToString());

        }
    }
}

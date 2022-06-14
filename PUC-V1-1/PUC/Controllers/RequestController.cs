using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Interfaces;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using SharedObjects.Extensions;

namespace PUC.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestService requestService;
        private readonly IConfiguration configuration;
        private readonly ICommonService commonService;

        public RequestController(IRequestService requestService, IConfiguration configuration, ICommonService commonService)
        {
            this.requestService = requestService;
            this.configuration = configuration;
            this.commonService = commonService;
        }

        public async Task<IActionResult> Get()
        {
            var Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["customers"] = await commonService.Customer_get(Ntlogin);
            ViewData["status"] = await commonService.Master_Status_get();
            var model = new RequestViewModel()
            {
                StatusId = 0,
            };
            var request = await requestService.Request_Get(model);
            return View(request);
        }
        public async Task<IActionResult> Request_insert([FromBody] RequestViewModel model)
        {
            var result = await requestService.Request_insert(model);
            model.ReqNumber =result.Message;
            model.ReqId = Int32.Parse(result.Message.Split('-').LastOrDefault());
            if (result.StatusCode == 200)
            {
                SentEmail(model);
            }
            return Json(new { results = result });
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(List<IFormFile> files, string date)
        {
            string uploadFolder = @"\\" + configuration["Server"] + @"\eDowntime\Attachment";
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file.FileName);//get filename
                var newfileName = fileName.Split('.')[0] + "_" + date + "." + fileName.Split('.')[1];

                var fullFilePath = Path.Combine(uploadFolder, newfileName);
                using (var stream = new FileStream(fullFilePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return Ok(0);
        }
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            string path = @"\\" + configuration["Server"] + @"\eDowntime\Attachment\" + fileName;
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
        public async Task<IActionResult> Request_Detail([FromBody] RequestViewModel model)
        {
            var lst = await requestService.Request_Detail(model);
            return PartialView(lst);
        }
        public async Task<IActionResult> Request_Reject([FromBody] RequestViewModel model)
        {
            SentConfirmEmail(model, "Rejected");
            var response = await requestService.Request_Reject(model);

            return Json(new { results = response });
        }
        public async Task<IActionResult> Request_Approve([FromBody] RequestViewModel model)
        {
            SentConfirmEmail(model, "Aprroved");
            var response = await requestService.Request_Approve(model);

            return Json(new { results = response });
        }
        public async Task<IActionResult> Request_Get_Approval([FromBody] RequestViewModel model)
        {
            var approval = await requestService.Request_Get_Approval(model);

            return Json(new { results = approval });
        }
        #region Sent Email
        public async void SentEmail(RequestViewModel model)
        {
            string body = string.Empty;
            body += "<div style='border - top:3px solid #22BCE5'>Hi,</div>";
            body += "There is a new change request by " + model.CreatedEmail + " as below:";

            body += " <table>";
            string tableheader = "<tr style='background-color:#FFaf7a'><td></td><td>Supplier</td><td>Category</td><td>Location</td><td>Part Number</td><td>Limit</td><td>Trigger Limit</td></tr>";

            string tablecontent = string.Empty;
            var request_Detail = await requestService.Request_Detail(model);
            foreach (var item in request_Detail)
            {
                tablecontent += "<tr style='background-color:cyan'>" + "<td>" + item.Description + "<td>" + item.Supplier + "</td><td>" + item.CategoryName + "</td><td>" + item.Location + "</td><td>" + item.PartNumber + "</td><td>" + item.Limit + "</td><td>" + String.Format("{0}", item.TriggerLimit) + "</td>" + "</tr>";
            }
            body += tableheader;
            body += tablecontent;
            body += " </table>";

            body += "<p>You may access <a href='http://vnhcmm0teapp02/puc/request/get'>here</a> to get detail</p>";
            body += " <p>This is automatic email, please do not reply</p>    Thanks";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");
            message.From = new MailAddress("PUC@Jabil.com");

            var Get_ApprovalOwner = await requestService.Request_Get_Approval(model);
            foreach (var email in Get_ApprovalOwner)
            {
                if (email !=  null)
                {
                    message.To.Add(new MailAddress(email.Email));
                }
            }

            message.CC.Add(new MailAddress(model.CreatedEmail));
            var configureEmail = configuration["Email:Cc"].Split(';');
            foreach (var email in configureEmail)
            {
                if (email != "")
                {
                    message.To.Add(new MailAddress(email));
                }
            }
            message.Subject = "[" + model.ReqNumber + "] New Request Is Pending For Your Approval";
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
        #endregion
        #region Sent Confirm Email
        private async void SentConfirmEmail([FromBody] RequestViewModel model, string response = null)
        {
            string body = string.Empty;
            body += "<div style='border - top:3px solid #22BCE5'>Hi,</div>";
            //body += "There is a new change request by " + model.CreatedEmail + " as below:";

            body += " <table>";
            string tableheader = "<tr style='background-color:#FFaf7a'><td></td><td>Supplier</td><td>Category</td><td>Location</td><td>Part Number</td><td>Limit</td><td>Trigger Limit</td></tr>";

            string tablecontent = string.Empty;
            var request_Detail = await requestService.Request_Detail(model);
            foreach (var item in request_Detail)
            {
                tablecontent += "<tr style='background-color:cyan'>" + "<td>" + item.Description + "<td>" + item.Supplier + "</td><td>" + item.CategoryName + "</td><td>" + item.Location + "</td><td>" + item.PartNumber + "</td><td>" + item.Limit + "</td><td>" + String.Format("{0}", item.TriggerLimit) + "</td>" + "</tr>";
            }
            body += tableheader;
            body += tablecontent;
            body += " </table>";

            body += "<p>You may access <a href='http://vnhcmm0teapp02/puc/request/requested'>here</a> to get detail</p>";
            body += " <p>This is automatic email, please do not reply</p>    Thanks";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");
            message.From = new MailAddress("PUC@Jabil.com");

            message.To.Add(new MailAddress(model.CreatedEmail));
            message.CC.Add(new MailAddress(model.UpdatedEmail));
            var configureEmail = configuration["Email:Cc"].Split(';');
            foreach (var email in configureEmail)
            {
                message.CC.Add(new MailAddress(email));
            }
            message.Subject = "[" + model.ReqNumber + "] Your Request Has Been " + response;
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
        #endregion

    }
}

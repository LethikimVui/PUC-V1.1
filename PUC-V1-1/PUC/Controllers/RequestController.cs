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

namespace PUC.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestService requestService;
        private readonly IConfiguration configuration;

        public RequestController(IRequestService requestService, IConfiguration configuration)
        {
            this.requestService = requestService;
            this.configuration = configuration;
        }

        public async Task<IActionResult> Get()
        {
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
            //if (result.StatusCode == 200)
            //{
            //    SentEmail(model);
            //}
            return Json(new { results = result });
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile( List<IFormFile> files, string date)
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
            var response = await requestService.Request_Reject(model);
            SentConfirmEmail(model, "Rejected");
            return Json(new { results = response });
        }
        public async Task<IActionResult> Request_Approve([FromBody] RequestViewModel model)
        {
            var response = await requestService.Request_Approve(model);
            SentConfirmEmail(model, "Aprroved");
            return Json(new { results = response });
        }
        #region Sent Confirm Email
        private async void SentConfirmEmail(RequestViewModel model, string response = null)
        {
            string body = string.Empty;

            //body = body.Replace("{Title}", response + " by " + model.CreatedName);
            body = "<a href='http://vnhcmm0teapp02/puc/request/requested'>here</a>";
            //body = body.Replace("{tableheader}", null);
            //body = body.Replace("{tablecontent}", null);
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");
            message.From = new MailAddress("PUC@Jabil.com");

            message.To.Add(new MailAddress(model.CreatedEmail));
            message.CC.Add(new MailAddress(model.UpdatedEmail));
            message.Subject = "[" + model.ReqNumber + "] Your Request Has Been " + response;
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
        #endregion

    }
}

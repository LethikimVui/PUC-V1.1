#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b26b7773e4d03f8b2b11ceb060f576b723eb18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Get), @"mvc.1.0.view", @"/Views/Request/Get.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\_ViewImports.cshtml"
using PUC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\_ViewImports.cshtml"
using PUC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b26b7773e4d03f8b2b11ceb060f576b723eb18", @"/Views/Request/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c91abb59d1554f261cf9382e5172b6b99a20e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/request.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
  
    ViewData["Title"] = "Request - Search";
    var customers = ViewData["customers"] as IEnumerable<SharedObjects.ValueObjects.VCustomer>;
    var status = ViewData["status"] as IEnumerable<SharedObjects.ValueObjects.VStatus>;
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""height:1700px"">
                <div class=""portlet-title"">
                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Request - Search
                        </span>
                    </div>

                    <div class=""col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 996, "\"", 1002, 0);
            EndWriteAttribute();
            WriteLiteral(">Customer</label>\r\n\r\n                        <select class=\"form-control\" id=\"txt-customer-search\" style=\"height: 34px !important; color: mediumvioletred\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b26b7773e4d03f8b2b11ceb060f576b723eb185664", async() => {
                WriteLiteral("--Please Select--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 28 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                             foreach (var item in customers.OrderByDescending(c => c.CustId).ToList())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b26b7773e4d03f8b2b11ceb060f576b723eb187237", async() => {
#nullable restore
#line 30 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                      Write(item.CustName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                  WriteLiteral(item.CustId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                    <div class=\"col-md-2 pull-left\">\r\n                        <label class=\"text-center bold font-green-sharp\"");
            BeginWriteAttribute("for", " for=\"", 1674, "\"", 1680, 0);
            EndWriteAttribute();
            WriteLiteral(">Status</label>\r\n\r\n                        <select class=\"form-control\" id=\"txt-status-search\" style=\"height: 34px !important; color: mediumvioletred\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b26b7773e4d03f8b2b11ceb060f576b723eb189930", async() => {
                WriteLiteral("--Please Select--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 40 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                             foreach (var item in status.OrderByDescending(c => c.StatusId).ToList())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b26b7773e4d03f8b2b11ceb060f576b723eb1811502", async() => {
#nullable restore
#line 42 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                        Write(item.StatusName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                  WriteLiteral(item.StatusId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                    <div class=\"form-group col-md-2\">\r\n                        <label class=\"text-center bold font-green-sharp\"");
            BeginWriteAttribute("for", " for=\"", 2352, "\"", 2358, 0);
            EndWriteAttribute();
            WriteLiteral(@">Request Number</label>
                        <label class=""control-label""></label>
                        <input id=""txt-reqNumber-search"" class=""form-control col-md-3"" style=""color: mediumvioletred"" />
                    </div>


                    <table class=""table table-bordered table-hover table-striped"">
                        <thead>
                            <tr class=""text-center bold"">
                                <td>No.</td>
                                <td>Request Number</td>
                                <td>Machine Name</td>
                                <td>Customer</td>
                                <td>Attachment</td>
                                <td>Created By</td>
                                <td>Creation Date</td>
                                <td>Approved By</td>
                                <td>Update Date</td>
                                <td>Status</td>
                                <td style=""width:100px"">Modification</td>
   ");
            WriteLiteral("                         </tr>\r\n                        </thead>\r\n                        <tbody id=\"table-data\">\r\n");
#nullable restore
#line 70 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-center\">\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3684, "\"", 3689, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3745, "\"", 3750, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.ReqNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3813, "\"", 3818, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3883, "\"", 3888, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3950, "\"", 3955, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"zoom\">\r\n");
#nullable restore
#line 78 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         if (item.FileName != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                             foreach (var item2 in item.FileName.Split(';'))
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a class=\"wrapper\" id=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 4818, "\"", 4890, 1);
#nullable restore
#line 88 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
WriteAttributeValue("", 4825, Url.Action("DownloadFile", "Request", new { fileName = @item2 }), 4825, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                                Write(item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                <br />\r\n");
#nullable restore
#line 90 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 5132, "\"", 5137, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.CreatedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 5202, "\"", 5207, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 5273, "\"", 5278, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 95 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 5341, "\"", 5346, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 96 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 5410, "\"", 5415, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 5416, "\"", 5458, 2);
            WriteAttributeValue("", 5424, "background-color:", 5424, 17, true);
#nullable restore
#line 97 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
WriteAttributeValue("", 5441, item.StatusColor, 5441, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                    Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n");
#nullable restore
#line 99 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         if (item.Status == "Pending Approval")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a id=\"btn-show\" class=\"btn default btn-xs red\" data-detailid=\"");
#nullable restore
#line 101 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                      Write(item.ReqNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-reqid=\"");
#nullable restore
#line 101 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                   Write(item.ReqId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-createdby=\"");
#nullable restore
#line 101 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                                                Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-createdemail=\"");
#nullable restore
#line 101 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                                                                                    Write(item.CreatedEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Show Request\" data-toggle=\"modal\" data-target=\"#myModal\"> <span class=\"glyphicon glyphicon-chevron-up\"></span></a>\r\n");
#nullable restore
#line 102 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 107 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- The Modal -->
<div class=""modal"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Detail Part Request Detail</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body pre-scrollable"">
                <table id=""modal-detail"" class=""table table-striped table-hover table-scrollable table-responsive"">
                </table>
            </div>
            <div class=""form-group"">
                <label>Remark</label>
                <input type=""text"" id=""txt-description"" />
            </div>
            <!-- Modal footer -->
            <div class=""modal-footer btn-modal"" sty");
            WriteLiteral(@"le=""visibility: hidden"">
                <button type=""button"" class=""btn btn-danger"" id=""btn-reject"">Reject</button>
                <button type=""button"" class=""btn blue"" id=""btn-approve"">Approve</button>

            </div>
        </div>
    </div>
</div>

");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b26b7773e4d03f8b2b11ceb060f576b723eb1827456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d16716d7afc1be6fa18b5b05cdbcf2a0675c74"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20d16716d7afc1be6fa18b5b05cdbcf2a0675c74", @"/Views/Request/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c91abb59d1554f261cf9382e5172b6b99a20e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/request.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">
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
                    <table class=""table table-bordered table-hover table-striped"">
                        <thead>
                            <tr class=""text-center bold"">
                                <td>No.</td>
                                <td>Request Number</td>
                                <td>Attachment</td>
                                <td>Created By</td>
                                <td>Creation Date</td>
                                <td>Approved By</td>
                                <td");
            WriteLiteral(@">Update Date</td>
                                <td>Status</td>
                                <td style=""width:100px"">Modification</td>
                            </tr>
                        </thead>
                        <tbody id=""table-data"">
");
#nullable restore
#line 31 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-center\">\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 1604, "\"", 1609, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 1665, "\"", 1670, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.ReqNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 1733, "\"", 1738, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"zoom\">\r\n");
#nullable restore
#line 37 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         if (item.FileName != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                             foreach (var item2 in item.FileName.Split(';'))
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a class=\"wrapper\" id=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 2649, "\"", 2721, 1);
#nullable restore
#line 47 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
WriteAttributeValue("", 2656, Url.Action("DownloadFile", "Request", new { fileName = @item2 }), 2656, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                                Write(item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                <br />\r\n");
#nullable restore
#line 49 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 2963, "\"", 2968, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.CreatedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3033, "\"", 3038, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3104, "\"", 3109, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3172, "\"", 3177, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3241, "\"", 3246, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 3247, "\"", 3289, 2);
            WriteAttributeValue("", 3255, "background-color:", 3255, 17, true);
#nullable restore
#line 56 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
WriteAttributeValue("", 3272, item.StatusColor, 3272, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                    Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n");
#nullable restore
#line 58 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                         if (item.Status == "Pending Approval")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a id=\"btn-show\" class=\"btn default btn-xs red\" data-detailid=\"");
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                      Write(item.ReqNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-reqid=\"");
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                   Write(item.ReqId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-createdby=\"");
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                                                Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-createdemail=\"");
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
                                                                                                                                                                                                    Write(item.CreatedEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Show Request\" data-toggle=\"modal\" data-target=\"#myModal\"> <span class=\"glyphicon glyphicon-chevron-up\"></span></a>\r\n");
#nullable restore
#line 61 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Request\Get.cshtml"
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
            <div class=""modal-footer"">
           ");
            WriteLiteral("     <button type=\"button\" class=\"btn btn-danger btn-modal\" id=\"btn-reject\">Reject</button>\r\n                <button type=\"button\" class=\"btn blue btn-modal\" id=\"btn-approve\">Approve</button>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d16716d7afc1be6fa18b5b05cdbcf2a0675c7416447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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

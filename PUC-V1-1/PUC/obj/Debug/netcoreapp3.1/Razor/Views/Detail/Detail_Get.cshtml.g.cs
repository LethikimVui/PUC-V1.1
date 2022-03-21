#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b966d010f4d8bb3f1109006542fee2a70e076c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Detail_Get), @"mvc.1.0.view", @"/Views/Detail/Detail_Get.cshtml")]
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
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
using SharedObjects.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b966d010f4d8bb3f1109006542fee2a70e076c09", @"/Views/Detail/Detail_Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c91abb59d1554f261cf9382e5172b6b99a20e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Detail_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/common-detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
  
    var customers = ViewData["customers"] as IEnumerable<SharedObjects.ValueObjects.VCustomer>;
    var categories = ViewData["categories"] as IEnumerable<SharedObjects.ValueObjects.VCategory>;
    var suppliers = ViewData["suppliers"] as IEnumerable<SharedObjects.ValueObjects.VSupplier>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered table-hover table-striped table-responsive"">
    <thead>
        <tr class=""text-center bold"">
            <th>No.</th>
            <th>Customer</th>
            <th>Fixture ID</th>
            <th>Part Number</th>
            <th>Location</th>
            <th>Category</th>
            <th>Supplier</th>
            <th>Used Times</th>
            <th>Limit</th>
            <th>TriggerLimit</th>
            <th>Description</th>
            <th>Latest Update Date</th>
            <th>Latest Update By</th>
            <th>Status</th>
");
#nullable restore
#line 25 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               if (User.IsInRole("Configuraton Admin") || User.IsInRole("SYSTEM ADMIN"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Modification</th>\r\n");
#nullable restore
#line 28 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr class=\"text-center\">\r\n            <td>New</td>\r\n            <td>\r\n                <select class=\"form-control\" id=\"txt-customer\" required onchange=\"fncOnchange1()\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c096656", async() => {
                WriteLiteral("Please Select");
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
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                     foreach (var item in customers.OrderByDescending(c => c.CustId).ToList())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c098203", async() => {
#nullable restore
#line 40 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
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
#line 40 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
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
#line 41 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </td>\r\n            <td>\r\n                <select class=\"form-control\" id=\"txt-machineName\" style=\"height: 34px !important; color: mediumvioletred\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c0910582", async() => {
                WriteLiteral("Please Select Customer");
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
            WriteLiteral(@"
                </select>
            </td>
            <td>
                <input id=""txt-partNumber"" type=""text"" class=""form-control"" style=""height:30px"" />
            </td>
            <td>
                <input id=""txt-location"" type=""text"" class=""form-control"" style=""height:30px"" />
            </td>
            <td>
                <select class=""form-control"" id=""txt-category"" style=""height: 34px !important; color: mediumvioletred"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c0912256", async() => {
                WriteLiteral("Please Select");
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
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                     foreach (var item in categories.OrderByDescending(c => c.CategoryId).ToList())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c0913809", async() => {
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                  Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                          WriteLiteral(item.CategoryId);

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
#line 61 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </td>\r\n            <td>\r\n                <select class=\"form-control\" id=\"txt-supplier\" style=\"height: 34px !important; color: mediumvioletred\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c0916198", async() => {
                WriteLiteral("Please Select");
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
            WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                     foreach (var item in suppliers.OrderByDescending(c => c.SupplierId).ToList())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c0917750", async() => {
#nullable restore
#line 69 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                  Write(item.Supplier);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                          WriteLiteral(item.SupplierId);

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
#line 70 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </td>
            <td></td>
            <td>
                <input id=""txt-limit"" type=""text"" class=""form-control"" tyle=""height:30px"" />
            </td>
            <td>
                <input id=""customLimit"" type=""checkbox"" onclick=""Change(this.checked)"">
                <input id=""txt-triggerLimit"" type=""text"" class=""form-control"" style=""height:30px;visibility: hidden"" />
            </td>
            <td>
                <input id=""txt-description"" type=""text"" class=""form-control"" tyle=""height:30px"" />
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td class=""text-center"">
                <a id=""btn-add"" class=""btn default btn-xs purple update"" title=""Add""> <span class=""glyphicon glyphicon-plus""></span></a>
            </td>
        </tr>
");
#nullable restore
#line 91 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 94 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 99 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 100 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.Supplier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 101 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.UsedTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 102 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.Limit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 103 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.TriggerLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 104 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 105 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 106 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 107 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 108 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                   if (User.GetSpecificClaim("RoleId") != "-1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-center\">\r\n                            <a id=\"btn-delete\" class=\"btn default btn-xs purple\" data-detailid=\"");
#nullable restore
#line 111 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                           Write(item.DetailId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-location=\"");
#nullable restore
#line 111 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                          Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Delete\">  <span class=\"glyphicon glyphicon-trash\"></span></a>\r\n                            <a id=\"btn-edit\" class=\"btn default btn-xs purple\" data-detailid=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                         Write(item.DetailId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-location=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                        Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-partnumber=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                                                         Write(item.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-limit=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                                                                                       Write(item.Limit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-supplierId=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                                                                                                                     Write(item.SupplierId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-categoryId=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                                                                                                                                                        Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-triggerlimit=\"");
#nullable restore
#line 112 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                                                                                                                                                                                                                                                                                             Write(item.TriggerLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#myModal\" title=\"Edit\"> <span class=\"glyphicon glyphicon-edit\"></span></a>\r\n                        </td>\r\n");
#nullable restore
#line 114 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 117 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Detail_Get.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966d010f4d8bb3f1109006542fee2a70e076c0930928", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591

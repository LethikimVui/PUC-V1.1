#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f64dee2d485618df128a0716e89b551c4c7b5a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Get_PartialView), @"mvc.1.0.view", @"/Views/Detail/Get_PartialView.cshtml")]
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
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
using SharedObjects.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f64dee2d485618df128a0716e89b551c4c7b5a4", @"/Views/Detail/Get_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c91abb59d1554f261cf9382e5172b6b99a20e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Get_PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
  
    var reasons = ViewData["reasons"] as List<SharedObjects.ValueObjects.VReason>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-2 pull-left\">\r\n    <select class=\"form-control\" id=\"txt-reason\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f64dee2d485618df128a0716e89b551c4c7b5a44195", async() => {
                WriteLiteral("Please select");
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
#line 9 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
         foreach (var reason in reasons)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f64dee2d485618df128a0716e89b551c4c7b5a45668", async() => {
#nullable restore
#line 11 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                                        Write(reason.Reason);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               WriteLiteral(reason.ReasonId);

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
#line 12 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
</div>
<div class=""col-md-2 pull-left"">
    <a id=""btn-refresh"" class=""btn default btn-xs purple update "" title=""Refresh""> <span class=""glyphicon glyphicon-refresh""></span></a>
</div>
<table class=""table table-bordered table-hover table-striped table-responsive"">
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
            <th>Trigger Limit</th>
            <th>Status</th>
            <th>Description</th>
            <th>Latest Update Date</th>
            <th>Latest Update By</th>
");
#nullable restore
#line 35 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               if (User.IsInRole("Configuraton Admin") || User.IsInRole("SYSTEM ADMIN"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Modification</th>\r\n");
#nullable restore
#line 38 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.Supplier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.UsedTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.Limit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.TriggerLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"level\" data-level=\"");
#nullable restore
#line 56 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                                         Write(item.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
               Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 60 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                   if (User.IsInRole("Configuraton Admin") || User.IsInRole("SYSTEM ADMIN"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-center\">\r\n                            <input class=\"confirm\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2376, "\"", 2398, 1);
#nullable restore
#line 63 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
WriteAttributeValue("", 2384, item.DetailId, 2384, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-machineId=\"");
#nullable restore
#line 63 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                                                                                                     Write(item.MachineId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-custId=\"");
#nullable restore
#line 63 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                                                                                                                                   Write(item.CustId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-usedTimes=\"");
#nullable restore
#line 63 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                                                                                                                                                                 Write(item.UsedTimes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-location=\"");
#nullable restore
#line 63 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                                                                                                                                                                                                 Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                        </td>\r\n");
#nullable restore
#line 65 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Detail\Get_PartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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

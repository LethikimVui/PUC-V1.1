#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6c7699c11f319a6e6b4beb288ab1f51e1d93b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Main_Get), @"mvc.1.0.view", @"/Views/Main/Main_Get.cshtml")]
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
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
using SharedObjects.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6c7699c11f319a6e6b4beb288ab1f51e1d93b7", @"/Views/Main/Main_Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c91abb59d1554f261cf9382e5172b6b99a20e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Main_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VMain>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-bordered table-hover table-striped table-responsive"">
    <thead>
        <tr class=""text-center bold"">
            <th>No.</th>
            <th>Customer</th>
            <th>Machine Name / Fixture ID</th>
            <th>Fixture Serial Number</th>
            <th>Fixture Part Number</th>
            <th>Description</th>
            <th>Latest Update Date</th>
");
#nullable restore
#line 13 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               if (User.IsInRole("SYSTEM ADMIN") || User.IsInRole("Configuraton Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Details</th>\r\n");
#nullable restore
#line 16 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
               Write(item.UpdateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
                   if (User.IsInRole("SYSTEM ADMIN") || User.IsInRole("Configuraton Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-center\">\r\n                            <a id=\"btn-detail\" class=\"btn default btn-xs purple\" data-machineName=\"");
#nullable restore
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
                                                                                              Write(item.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-machineId=\"");
#nullable restore
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
                                                                                                                                 Write(item.MachineId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-custId=\"");
#nullable restore
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
                                                                                                                                                               Write(item.CustId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Detail\">  <span class=\"glyphicon glyphicon-list-alt\"></span></a>\r\n");
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 38 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\PUC-V1.1\PUC-V1-1\PUC\Views\Main\Main_Get.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VMain>> Html { get; private set; }
    }
}
#pragma warning restore 1591

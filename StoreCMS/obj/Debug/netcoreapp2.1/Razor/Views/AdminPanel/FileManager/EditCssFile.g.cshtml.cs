#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f66bd69d1e725f22e0d01b0224f5332293811b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_FileManager_EditCssFile), @"mvc.1.0.view", @"/Views/AdminPanel/FileManager/EditCssFile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/FileManager/EditCssFile.cshtml", typeof(AspNetCore.Views_AdminPanel_FileManager_EditCssFile))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Security;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f66bd69d1e725f22e0d01b0224f5332293811b4", @"/Views/AdminPanel/FileManager/EditCssFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_FileManager_EditCssFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StyleModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/file_manager/editCss.css";
    User user = Context.Items["User"] as User;
    bool incorrect = Context.Items["IsIncorrect"] == null ? false : (bool)Context.Items["IsIncorrect"];

#line default
#line hidden
            BeginContext(336, 44, true);
            WriteLiteral("<form method=\"post\" class=\"pageContainer\">\r\n");
            EndContext();
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
     if (incorrect)
    {

#line default
#line hidden
            BeginContext(408, 40, true);
            WriteLiteral("                <span class=\"incorrect\">");
            EndContext();
            BeginContext(449, 37, false);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                   Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(486, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
    }

#line default
#line hidden
            BeginContext(502, 79, true);
            WriteLiteral("                <div class=\"nameBlock\">\r\n                    <label for=\"Name\">");
            EndContext();
            BeginContext(582, 27, false);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                 Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(609, 85, true);
            WriteLiteral("</label>\r\n                    <input type=\"text\" id=\"Name\" name=\"StyleModel.FileName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 694, "\"", 718, 1);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
WriteAttributeValue("", 702, Model?.FileName, 702, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(719, 82, true);
            WriteLiteral(" required />\r\n                </div>\r\n                <label for=\"TemplateSource\">");
            EndContext();
            BeginContext(802, 39, false);
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                       Write(Html.Raw(localization.StyleFileContent));

#line default
#line hidden
            EndContext();
            BeginContext(841, 86, true);
            WriteLiteral("</label>\r\n                <textarea id=\"TemplateSource\" name=\"StyleModel.FileContent\">");
            EndContext();
            BeginContext(928, 18, false);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                                                       Write(Model?.FileContent);

#line default
#line hidden
            EndContext();
            BeginContext(946, 49, true);
            WriteLiteral("</textarea>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 995, "\"", 1037, 1);
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
WriteAttributeValue("", 1003, Html.Raw(localization.SaveButton), 1003, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1038, 24, true);
            WriteLiteral(" />\r\n            </form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFileManagerLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StyleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

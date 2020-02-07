#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46aff53ff379e4a9f03a6b0d8d81d5b036b645ed"
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
#line 1 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Security;

#line default
#line hidden
#line 2 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 5 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46aff53ff379e4a9f03a6b0d8d81d5b036b645ed", @"/Views/AdminPanel/FileManager/EditCssFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_FileManager_EditCssFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StyleModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/file_manager/edit_template.css";
    Context.Items["PageName"] = $"{localization.EditStylePageName} {Model.FileName}";
    User user = Context.Items["User"] as User;
    string path = Context.Items["PathToFile"] as string;

#line default
#line hidden
            BeginContext(382, 169, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/insert_tab.js\"></script>\r\n            <form id=\"edit-style\" class=\"page-container\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 551, "\"", 592, 1);
#line 12 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
WriteAttributeValue("", 559, (int)AdminPanelPages.EditStyle, 559, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(593, 53, true);
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"path\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 646, "\"", 669, 1);
#line 13 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
WriteAttributeValue("", 654, Html.Raw(path), 654, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 85, true);
            WriteLiteral(" />\r\n                <div class=\"name-block\">\r\n                    <label for=\"Name\">");
            EndContext();
            BeginContext(756, 27, false);
#line 15 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                 Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(783, 85, true);
            WriteLiteral("</label>\r\n                    <input type=\"text\" id=\"Name\" name=\"StyleModel.FileName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 868, "\"", 892, 1);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
WriteAttributeValue("", 876, Model?.FileName, 876, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(893, 82, true);
            WriteLiteral(" required />\r\n                </div>\r\n                <label for=\"TemplateSource\">");
            EndContext();
            BeginContext(976, 34, false);
#line 18 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                       Write(Html.Raw(localization.FileContent));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 86, true);
            WriteLiteral("</label>\r\n                <textarea id=\"TemplateSource\" name=\"StyleModel.FileContent\">");
            EndContext();
            BeginContext(1097, 18, false);
#line 19 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                                                       Write(Model?.FileContent);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 66, true);
            WriteLiteral("</textarea>\r\n                <input id=\"edit-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1181, "\"", 1223, 1);
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
WriteAttributeValue("", 1189, Html.Raw(localization.SaveButton), 1189, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1224, 551, true);
            WriteLiteral(@" />
            </form>
            <script>
                function errorHandler(formElement) {
                    let errorMsgElement = document.getElementById('error-msg');
                    if (errorMsgElement === null) {
                        errorMsgElement = document.createElement('span');
                        errorMsgElement.setAttribute('id', 'error-msg');
                        formElement.insertBefore(errorMsgElement, formElement.firstChild);
                    }
                    errorMsgElement.textContent = '");
            EndContext();
            BeginContext(1776, 37, false);
#line 30 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                                              Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 170, true);
            WriteLiteral("\';\r\n                }\r\n                function responseHandler(request, formElement) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(1984, 38, false);
#line 34 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\EditCssFile.cshtml"
                          Write(Html.Raw(localization.StyleFileEdited));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 555, true);
            WriteLiteral(@"');
                        location.replace(request.getResponseHeader('location'));
                    }
                    else if (request.status == 422) {
                        errorHandler(formElement);
                    }
                }
                document.getElementById('edit-button').addEventListener('click', createSendDataEventHandler('POST', 'edit-style', responseHandler, errorHandler));
                document.getElementById('TemplateSource').addEventListener('keydown', insertTabEventHandler);
            </script>");
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
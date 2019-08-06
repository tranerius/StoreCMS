#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6cad5314a0155b786a52896e910f558912e5590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Chunks_AddChunk), @"mvc.1.0.view", @"/Views/AdminPanel/Chunks/AddChunk.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Chunks/AddChunk.cshtml", typeof(AspNetCore.Views_AdminPanel_Chunks_AddChunk))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6cad5314a0155b786a52896e910f558912e5590", @"/Views/AdminPanel/Chunks/AddChunk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Chunks_AddChunk : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/templates/work_with_template.css";
    Context.Items["PageName"] = localization.AddChunkPageName;
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(282, 239, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/send_data.js\"></script>\r\n            <script src=\"/scripts/admin_panel/insert_tab.js\"></script>\r\n            <form id=\"add-chunk\" class=\"page-container\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 521, "\"", 561, 1);
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
WriteAttributeValue("", 529, (int)AdminPanelPages.AddChunk, 529, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 83, true);
            WriteLiteral(">\r\n                <div class=\"name-block\">\r\n                    <label for=\"Name\">");
            EndContext();
            BeginContext(646, 27, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                                 Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(673, 166, true);
            WriteLiteral("</label>\r\n                    <input type=\"text\" id=\"Name\" name=\"TemplateModel.Name\" required />\r\n                </div>\r\n                <label for=\"TemplateSource\">");
            EndContext();
            BeginContext(840, 35, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                                       Write(Html.Raw(localization.TemplateCode));

#line default
#line hidden
            EndContext();
            BeginContext(875, 157, true);
            WriteLiteral("</label>\r\n                <textarea id=\"TemplateSource\" name=\"TemplateModel.TemplateSource\"></textarea>\r\n                <input id=\"add-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1032, "\"", 1074, 1);
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
WriteAttributeValue("", 1040, Html.Raw(localization.SaveButton), 1040, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 551, true);
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
            BeginContext(1627, 37, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                                              Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 170, true);
            WriteLiteral("\';\r\n                }\r\n                function responseHandler(request, formElement) {\r\n                    if (request.status == 201) {\r\n                        alert(\'");
            EndContext();
            BeginContext(1835, 35, false);
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                          Write(Html.Raw(localization.ChunkCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 5, true);
            WriteLiteral("\');\r\n");
            EndContext();
#line 33 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                         if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditChunk, user, Context))
                        {

#line default
#line hidden
            BeginContext(2005, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2031, 58, true);
            WriteLiteral("location.replace(request.getResponseHeader(\'location\'));\r\n");
            EndContext();
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2173, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2199, 64, true);
            WriteLiteral("location.replace(location.origin + location.pathname + \'?pageID=");
            EndContext();
            BeginContext(2265, 27, false);
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                                                                                      Write((int)AdminPanelPages.Chunks);

#line default
#line hidden
            EndContext();
            BeginContext(2293, 5, true);
            WriteLiteral("\');\r\n");
            EndContext();
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Chunks\AddChunk.cshtml"
                        }

#line default
#line hidden
            BeginContext(2325, 466, true);
            WriteLiteral(@"                    }
                    else if (request.status == 422) {
                        errorHandler(formElement);
                    }
                }
                document.getElementById('add-button').addEventListener('click', createSendDataEventHandler('POST', 'add-chunk', responseHandler, errorHandler));
                document.getElementById('TemplateSource').addEventListener('keydown', insertTabEventHandler);
            </script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITemplatesLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

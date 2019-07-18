#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74acc2a2a827d649ec5ba1addd93a62dd83017e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_AddCategory), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/AddCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/AddCategory.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_AddCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74acc2a2a827d649ec5ba1addd93a62dd83017e5", @"/Views/AdminPanel/CategoriesAndProducts/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/categories_and_products/work_with_page.css";
    Context.Items["PageName"] = localization.AddCategoryPageName;
    UsualPage[] pages = Context.Items["UsualPages"] as UsualPage[];
    Template[] templates = Context.Items["Templates"] as Template[];

#line default
#line hidden
            BeginContext(422, 281, true);
            WriteLiteral(@"<script src=""/scripts/admin_panel/send_data.js""></script>
            <script src=""/scripts/admin_panel/insert_tab.js""></script>
            <script src=""/scripts/admin_panel/checkbox_event_handler.js""></script>
            <form id=""add-category-form"" class=""page-container"">
");
            EndContext();
            BeginContext(736, 61, true);
            WriteLiteral("                <input id=\"add-category-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 797, "\"", 839, 1);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
WriteAttributeValue("", 805, Html.Raw(localization.SaveButton), 805, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(840, 89, true);
            WriteLiteral(" />\r\n                <div class=\"blocks\">\r\n                    <div class=\"left-block\">\r\n");
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(1008, 36, false);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                      Write(Html.Raw(localization.CategoryTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 101, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required />\r\n");
            EndContext();
            BeginContext(1185, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1232, 41, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                         Write(Html.Raw(localization.CategoryBreadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 107, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required />\r\n");
            EndContext();
            BeginContext(1426, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(1480, 38, false);
#line 25 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 125, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\">\r\n");
            EndContext();
            BeginContext(1686, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(1737, 35, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 180, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\" />\r\n                    </div>\r\n                    <div class=\"right-block\">\r\n");
            EndContext();
            BeginContext(1996, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2045, 31, false);
#line 33 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 133, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\">\r\n                            <option selected>");
            EndContext();
            BeginContext(2210, 38, false);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                        Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                             foreach (var t in templates)
                            {

#line default
#line hidden
            BeginContext(2349, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2384, "\"", 2397, 1);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
WriteAttributeValue("", 2392, t.ID, 2392, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2398, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2400, 16, false);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                             Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(2458, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(2536, 50, true);
            WriteLiteral("                        <label for=\"PreviousPage\">");
            EndContext();
            BeginContext(2587, 35, false);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                             Write(Html.Raw(localization.PreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(2622, 139, true);
            WriteLiteral("</label>\r\n                        <select id=\"PreviousPage\" name=\"PageModel.PreviousPageID\">\r\n                            <option selected>");
            EndContext();
            BeginContext(2762, 42, false);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                        Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(2804, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                         foreach (var p in pages)
                        {

#line default
#line hidden
            BeginContext(2893, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2928, "\"", 2941, 1);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
WriteAttributeValue("", 2936, p.ID, 2936, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2942, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2944, 20, false);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                             Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(2964, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                        }

#line default
#line hidden
            BeginContext(3002, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(3072, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(3116, 28, false);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(3144, 86, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3230, "\"", 3251, 1);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
WriteAttributeValue("", 3238, Model?.Alias, 3238, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3252, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(3297, 495, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""Published"" name=""PageModel.Published"" value=""true"" checked />
                            <script>
                                let publishedCheckbox = document.getElementById('Published');
                                publishedCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""Published"">");
            EndContext();
            BeginContext(3793, 32, false);
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(3825, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(3906, 483, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsIndex"" name=""PageModel.IsIndex"" value=""true"" checked />
                            <script>
                                let isIndexCheckbox = document.getElementById('IsIndex');
                                isIndexCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsIndex"">");
            EndContext();
            BeginContext(4390, 30, false);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(4420, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(4502, 489, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsFollow"" name=""PageModel.IsFollow"" value=""true"" checked />
                            <script>
                                let isFollowCheckbox = document.getElementById('IsFollow');
                                isFollowCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsFollow"">");
            EndContext();
            BeginContext(4992, 31, false);
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(5023, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(5146, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(5184, 30, false);
#line 83 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(5214, 296, true);
            WriteLiteral(@"</label>
                <textarea id=""Content"" name=""PageModel.Content""></textarea>
            </form>
            <script>
                function errorHandler(formElement) {
                    let errorMsg = document.createElement('span');
                    errorMsg.textContent = '");
            EndContext();
            BeginContext(5511, 37, false);
#line 89 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                       Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(5548, 256, true);
            WriteLiteral(@"';
                    errorMsg.setAttribute('id', 'error-msg');
                    formElement.insertBefore(errorMsg, formElement.firstChild);
                }
                function successfulRequestHandler(request) {
                    alert('");
            EndContext();
            BeginContext(5805, 36, false);
#line 94 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                      Write(Html.Raw(localization.CategoryAdded));

#line default
#line hidden
            EndContext();
            BeginContext(5841, 295, true);
            WriteLiteral(@"');
                    location.replace(request.getResponseHeader('location'));
                }
                let addCategoryButton = document.getElementById('add-category-button');
                addCategoryButton.addEventListener('click', createSendDataEventHandler('POST', '?pageID=");
            EndContext();
            BeginContext(6138, 32, false);
#line 98 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddCategory.cshtml"
                                                                                                    Write((int)AdminPanelPages.AddCategory);

#line default
#line hidden
            EndContext();
            BeginContext(6171, 234, true);
            WriteLiteral("\', \'add-category-form\', successfulRequestHandler, errorHandler));\r\n                let textarea = document.getElementById(\'Content\');\r\n                textarea.addEventListener(\'keydown\', insertTabEventHandler);\r\n            </script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CMSDatabase db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICategoriesAndProductsLocalization localization { get; private set; }
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
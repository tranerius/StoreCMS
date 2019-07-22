#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d90ab540e3d12d9116af6ade445e5fb9f22f50d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_AddProduct), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/AddProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/AddProduct.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_AddProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d90ab540e3d12d9116af6ade445e5fb9f22f50d", @"/Views/AdminPanel/CategoriesAndProducts/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/categories_and_products/work_with_page.css";
    CategoryPage categoryPage = Context.Items["CategoryPage"] as CategoryPage;
    Context.Items["PageName"] = $"{localization.AddProductPageName} {categoryPage?.PageName}";
    Template[] templates = Context.Items["Templates"] as Template[];
    int? lastTemplate = Context.Items["LastTemplate"] as int?;

#line default
#line hidden
            BeginContext(502, 280, true);
            WriteLiteral(@"<script src=""/scripts/admin_panel/send_data.js""></script>
            <script src=""/scripts/admin_panel/insert_tab.js""></script>
            <script src=""/scripts/admin_panel/checkbox_event_handler.js""></script>
            <form id=""add-product-form"" class=""page-container"">
");
            EndContext();
            BeginContext(815, 60, true);
            WriteLiteral("                <input id=\"add-product-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 875, "\"", 917, 1);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
WriteAttributeValue("", 883, Html.Raw(localization.SaveButton), 883, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(918, 89, true);
            WriteLiteral(" />\r\n                <div class=\"blocks\">\r\n                    <div class=\"left-block\">\r\n");
            EndContext();
            BeginContext(1042, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(1086, 35, false);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                      Write(Html.Raw(localization.ProductTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 101, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required />\r\n");
            EndContext();
            BeginContext(1262, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1309, 40, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                         Write(Html.Raw(localization.ProductBreadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 107, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required />\r\n");
            EndContext();
            BeginContext(1491, 137, true);
            WriteLiteral("                        <div class=\"price-block\">\r\n                            <div>\r\n                                <label for=\"Price\">");
            EndContext();
            BeginContext(1629, 28, false);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                              Write(Html.Raw(localization.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 226, true);
            WriteLiteral("</label>\r\n                                <input type=\"number\" id=\"Price\" name=\"PageModel.Price\" />\r\n                            </div>\r\n                            <div>\r\n                                <label for=\"OldPrice\">");
            EndContext();
            BeginContext(1884, 31, false);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                 Write(Html.Raw(localization.OldPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 175, true);
            WriteLiteral("</label>\r\n                                <input type=\"number\" id=\"OldPrice\" name=\"PageModel.OldPrice\" />\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(2137, 54, true);
            WriteLiteral("                        <label for=\"ShortDescription\">");
            EndContext();
            BeginContext(2192, 39, false);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                 Write(Html.Raw(localization.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 148, true);
            WriteLiteral("</label>\r\n                        <textarea class=\"short-description\" rows=\"3\" id=\"ShortDescription\" name=\"PageModel.ShortDescription\"></textarea>\r\n");
            EndContext();
            BeginContext(2428, 518, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""SpecialProduct"" name=""PageModel.SpecialProduct"" value=""false"" />
                            <script>
                                let specialProductCheckbox = document.getElementById('SpecialProduct');
                                specialProductCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""SpecialProduct"">");
            EndContext();
            BeginContext(2947, 37, false);
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                   Write(Html.Raw(localization.SpecialProduct));

#line default
#line hidden
            EndContext();
            BeginContext(2984, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(3074, 524, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""AddParagraphTag"" name=""PageModel.AddParagraphTag"" value=""false"" />
                            <script>
                                let addParagraphTagCheckbox = document.getElementById('AddParagraphTag');
                                addParagraphTagCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""AddParagraphTag"">");
            EndContext();
            BeginContext(3599, 38, false);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                    Write(Html.Raw(localization.AddParagraphTag));

#line default
#line hidden
            EndContext();
            BeginContext(3637, 117, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"right-block\">\r\n");
            EndContext();
            BeginContext(3798, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(3847, 31, false);
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(3878, 88, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\">\r\n");
            EndContext();
#line 61 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                             if (lastTemplate.HasValue)
                            {

#line default
#line hidden
            BeginContext(4054, 36, true);
            WriteLiteral("                            <option>");
            EndContext();
            BeginContext(4091, 38, false);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                               Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(4129, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4236, 45, true);
            WriteLiteral("                            <option selected>");
            EndContext();
            BeginContext(4282, 38, false);
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                        Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(4320, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 68 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                            }

#line default
#line hidden
            BeginContext(4362, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                         foreach (var t in templates)
                        {
                            

#line default
#line hidden
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                             if (lastTemplate.HasValue && lastTemplate.Value == t.ID)
                            {

#line default
#line hidden
            BeginContext(4562, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4597, "\"", 4610, 1);
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
WriteAttributeValue("", 4605, t.ID, 4605, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4611, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(4622, 16, false);
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                      Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4638, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 74 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4745, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4780, "\"", 4793, 1);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
WriteAttributeValue("", 4788, t.ID, 4788, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4794, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4796, 16, false);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                             Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4812, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                            }

#line default
#line hidden
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(4881, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(4951, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(4995, 28, false);
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(5023, 91, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\" />\r\n");
            EndContext();
            BeginContext(5160, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(5214, 38, false);
#line 85 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(5252, 125, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\">\r\n");
            EndContext();
            BeginContext(5420, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(5471, 35, false);
#line 88 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(5506, 105, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\" />\r\n");
            EndContext();
            BeginContext(5651, 495, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""Published"" name=""PageModel.Published"" value=""true"" checked />
                            <script>
                                let publishedCheckbox = document.getElementById('Published');
                                publishedCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""Published"">");
            EndContext();
            BeginContext(6147, 32, false);
#line 97 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(6179, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6260, 483, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsIndex"" name=""PageModel.IsIndex"" value=""true"" checked />
                            <script>
                                let isIndexCheckbox = document.getElementById('IsIndex');
                                isIndexCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsIndex"">");
            EndContext();
            BeginContext(6744, 30, false);
#line 106 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(6774, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6856, 489, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsFollow"" name=""PageModel.IsFollow"" value=""true"" checked />
                            <script>
                                let isFollowCheckbox = document.getElementById('IsFollow');
                                isFollowCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsFollow"">");
            EndContext();
            BeginContext(7346, 31, false);
#line 115 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(7377, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(7500, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(7538, 30, false);
#line 120 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(7568, 296, true);
            WriteLiteral(@"</label>
                <textarea id=""Content"" name=""PageModel.Content""></textarea>
            </form>
            <script>
                function errorHandler(formElement) {
                    let errorMsg = document.createElement('span');
                    errorMsg.textContent = '");
            EndContext();
            BeginContext(7865, 37, false);
#line 126 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                       Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(7902, 256, true);
            WriteLiteral(@"';
                    errorMsg.setAttribute('id', 'error-msg');
                    formElement.insertBefore(errorMsg, formElement.firstChild);
                }
                function successfulRequestHandler(request) {
                    alert('");
            EndContext();
            BeginContext(8159, 35, false);
#line 131 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                      Write(Html.Raw(localization.ProductAdded));

#line default
#line hidden
            EndContext();
            BeginContext(8194, 146, true);
            WriteLiteral("\');\r\n                    location.replace(request.getResponseHeader(\'location\'));\r\n                }\r\n                let searchString = \'?pageID=");
            EndContext();
            BeginContext(8342, 31, false);
#line 134 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                        Write((int)AdminPanelPages.AddProduct);

#line default
#line hidden
            EndContext();
            BeginContext(8374, 8, true);
            WriteLiteral("&itemID=");
            EndContext();
            BeginContext(8383, 16, false);
#line 134 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\AddProduct.cshtml"
                                                                                 Write(categoryPage?.ID);

#line default
#line hidden
            EndContext();
            BeginContext(8399, 630, true);
            WriteLiteral(@"';
                let addProductButton = document.getElementById('add-product-button');
                addProductButton.addEventListener('click', createSendDataEventHandler('POST', searchString, 'add-product-form', successfulRequestHandler, errorHandler));
                let textareaShortDescription = document.getElementById('ShortDescription');
                textareaShortDescription.addEventListener('keydown', insertTabEventHandler);
                let textareaContent = document.getElementById('Content');
                textareaContent.addEventListener('keydown', insertTabEventHandler);
            </script>");
            EndContext();
        }
        #pragma warning restore 1998
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

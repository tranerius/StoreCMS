#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ffbf5721e677c43bb8c916a138353a5cc1a960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_EditProduct), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/EditProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/EditProduct.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_EditProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ffbf5721e677c43bb8c916a138353a5cc1a960", @"/Views/AdminPanel/CategoriesAndProducts/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/categories_and_products/work_with_page.css";
    Context.Items["PageName"] = $"{localization.EditProductPageName} {Model.PageName}";
    Template[] templates = Context.Items["Templates"] as Template[];

#line default
#line hidden
            BeginContext(393, 209, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/send_data.js\"></script>\r\n            <script src=\"/scripts/admin_panel/checkbox_event_handler.js\"></script>\r\n            <form id=\"edit-product-form\" class=\"page-container\">\r\n");
            EndContext();
            BeginContext(635, 55, true);
            WriteLiteral("                <input id=\"submit-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 690, "\"", 732, 1);
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 698, Html.Raw(localization.SaveButton), 698, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(733, 89, true);
            WriteLiteral(" />\r\n                <div class=\"blocks\">\r\n                    <div class=\"left-block\">\r\n");
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(901, 35, false);
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                      Write(Html.Raw(localization.ProductTitle));

#line default
#line hidden
            EndContext();
            BeginContext(936, 96, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1032, "\"", 1053, 1);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1040, Model?.Title, 1040, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1054, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1099, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1146, 40, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                         Write(Html.Raw(localization.ProductBreadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 102, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1288, "\"", 1312, 1);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1296, Model?.PageName, 1296, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1313, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1353, 137, true);
            WriteLiteral("                        <div class=\"price-block\">\r\n                            <div>\r\n                                <label for=\"Price\">");
            EndContext();
            BeginContext(1491, 28, false);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                              Write(Html.Raw(localization.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 104, true);
            WriteLiteral("</label>\r\n                                <input type=\"number\" id=\"Price\" name=\"PageModel.Price\" min=\"0\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1623, "\"", 1644, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1631, Model?.Price, 1631, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1645, 130, true);
            WriteLiteral(" />\r\n                            </div>\r\n                            <div>\r\n                                <label for=\"OldPrice\">");
            EndContext();
            BeginContext(1776, 31, false);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                 Write(Html.Raw(localization.OldPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 110, true);
            WriteLiteral("</label>\r\n                                <input type=\"number\" id=\"OldPrice\" name=\"PageModel.OldPrice\" min=\"0\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1917, "\"", 1941, 1);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1925, Model?.OldPrice, 1925, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1942, 73, true);
            WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(2062, 54, true);
            WriteLiteral("                        <label for=\"ShortDescription\">");
            EndContext();
            BeginContext(2117, 39, false);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                 Write(Html.Raw(localization.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 135, true);
            WriteLiteral("</label>\r\n                        <textarea class=\"short-description\" rows=\"3\" id=\"ShortDescription\" name=\"PageModel.ShortDescription\">");
            EndContext();
            BeginContext(2292, 23, false);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                                                                                        Write(Model?.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2315, 13, true);
            WriteLiteral("</textarea>\r\n");
            EndContext();
            BeginContext(2377, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                             if (Model == null || !Model.SpecialProduct)
                            {

#line default
#line hidden
            BeginContext(2536, 125, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"SpecialProduct\" name=\"PageModel.SpecialProduct\" value=\"false\" />\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2757, 131, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"SpecialProduct\" name=\"PageModel.SpecialProduct\" value=\"true\" checked/>\r\n");
            EndContext();
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                            }

#line default
#line hidden
            BeginContext(2919, 343, true);
            WriteLiteral(@"                            <script>
                                let specialProductCheckbox = document.getElementById('SpecialProduct');
                                specialProductCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""SpecialProduct"">");
            EndContext();
            BeginContext(3263, 37, false);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                   Write(Html.Raw(localization.SpecialProduct));

#line default
#line hidden
            EndContext();
            BeginContext(3300, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(3390, 524, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""AddParagraphTag"" name=""PageModel.AddParagraphTag"" value=""false"" />
                            <script>
                                let addParagraphTagCheckbox = document.getElementById('AddParagraphTag');
                                addParagraphTagCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""AddParagraphTag"">");
            EndContext();
            BeginContext(3915, 38, false);
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                    Write(Html.Raw(localization.AddParagraphTag));

#line default
#line hidden
            EndContext();
            BeginContext(3953, 117, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"right-block\">\r\n");
            EndContext();
            BeginContext(4108, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(4157, 31, false);
#line 65 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(4188, 97, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\" required>\r\n");
            EndContext();
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (!Model.TemplateId.HasValue)
                        {

#line default
#line hidden
            BeginContext(4370, 45, true);
            WriteLiteral("                            <option selected>");
            EndContext();
            BeginContext(4416, 38, false);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                        Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(4454, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4549, 36, true);
            WriteLiteral("                            <option>");
            EndContext();
            BeginContext(4586, 38, false);
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                               Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(4624, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 74 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(4662, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 75 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         foreach (var t in templates)
                        {
                            if (Model.TemplateId.HasValue && t.ID == Model.TemplateId.Value)
                            {

#line default
#line hidden
            BeginContext(4869, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4904, "\"", 4917, 1);
#line 79 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 4912, t.ID, 4912, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4918, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(4929, 16, false);
#line 79 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                      Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4945, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5052, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5087, "\"", 5100, 1);
#line 83 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 5095, t.ID, 5095, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5101, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5103, 16, false);
#line 83 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                             Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5119, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 84 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5188, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(5258, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(5302, 28, false);
#line 88 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(5330, 86, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5416, "\"", 5437, 1);
#line 89 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 5424, Model?.Alias, 5424, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5438, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(5489, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(5543, 38, false);
#line 91 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(5581, 122, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5703, "\"", 5734, 1);
#line 92 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 5711, Model?.PageDescription, 5711, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5735, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(5781, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(5832, 35, false);
#line 94 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(5867, 100, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5967, "\"", 5995, 1);
#line 95 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 5975, Model?.PageKeywords, 5975, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5996, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(6041, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 98 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (Model == null || Model.Published)
                        {

#line default
#line hidden
            BeginContext(6186, 118, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" checked />\r\n");
            EndContext();
#line 101 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6388, 111, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"false\" />\r\n");
            EndContext();
#line 105 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(6526, 323, true);
            WriteLiteral(@"                            <script>
                                let publishedCheckbox = document.getElementById('Published');
                                publishedCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""Published"">");
            EndContext();
            BeginContext(6850, 32, false);
#line 110 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(6882, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6963, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 114 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (Model == null || Model.IsIndex)
                        {

#line default
#line hidden
            BeginContext(7106, 114, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"true\" checked />\r\n");
            EndContext();
#line 117 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7304, 107, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"false\" />\r\n");
            EndContext();
#line 121 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(7438, 315, true);
            WriteLiteral(@"                            <script>
                                let isIndexCheckbox = document.getElementById('IsIndex');
                                isIndexCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsIndex"">");
            EndContext();
            BeginContext(7754, 30, false);
#line 126 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(7784, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(7866, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 130 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (Model == null || Model.IsFollow)
                        {

#line default
#line hidden
            BeginContext(8010, 116, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"true\" checked />\r\n");
            EndContext();
#line 133 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(8210, 109, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"false\" />\r\n");
            EndContext();
#line 137 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(8346, 319, true);
            WriteLiteral(@"                            <script>
                                let isFollowCheckbox = document.getElementById('IsFollow');
                                isFollowCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsFollow"">");
            EndContext();
            BeginContext(8666, 31, false);
#line 142 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(8697, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(8820, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(8858, 30, false);
#line 147 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(8888, 74, true);
            WriteLiteral("</label>\r\n                <textarea id=\"Content\" name=\"PageModel.Content\">");
            EndContext();
            BeginContext(8963, 14, false);
#line 148 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                           Write(Model?.Content);

#line default
#line hidden
            EndContext();
            BeginContext(8977, 222, true);
            WriteLiteral("</textarea>\r\n            </form>\r\n            <script>\r\n                function errorHandler(formElement) {\r\n                    let errorMsg = document.createElement(\'span\');\r\n                    errorMsg.textContent = \'");
            EndContext();
            BeginContext(9200, 37, false);
#line 153 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                       Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(9237, 253, true);
            WriteLiteral("\';\r\n                    errorMsg.setAttribute(\'id\', \'error-msg\');\r\n                    formElement.insertBefore(errorMsg, formElement.firstChild);\r\n                }\r\n                function successRequestHandler(request) {\r\n                    alert(\'");
            EndContext();
            BeginContext(9491, 37, false);
#line 158 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                      Write(Html.Raw(localization.CategoryEdited));

#line default
#line hidden
            EndContext();
            BeginContext(9528, 108, true);
            WriteLiteral("\');\r\n                    location.reload();\r\n                }\r\n                let searchString = \'?pageID=");
            EndContext();
            BeginContext(9638, 32, false);
#line 161 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                        Write((int)AdminPanelPages.EditProduct);

#line default
#line hidden
            EndContext();
            BeginContext(9671, 8, true);
            WriteLiteral("&itemID=");
            EndContext();
            BeginContext(9680, 8, false);
#line 161 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                                                  Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(9688, 268, true);
            WriteLiteral(@"';
                let submitButton = document.getElementById('submit-button');
                submitButton.addEventListener('click', createSendDataEventHandler('POST', searchString, 'edit-product-form', successRequestHandler, errorHandler));
            </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

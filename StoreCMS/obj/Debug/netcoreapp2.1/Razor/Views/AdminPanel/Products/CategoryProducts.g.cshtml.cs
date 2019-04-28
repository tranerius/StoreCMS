#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc4455ab95b370b577e12f8dc295ffac7eec78e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Products_CategoryProducts), @"mvc.1.0.view", @"/Views/AdminPanel/Products/CategoryProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Products/CategoryProducts.cshtml", typeof(AspNetCore.Views_AdminPanel_Products_CategoryProducts))]
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
using Treynessen.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc4455ab95b370b577e12f8dc295ffac7eec78e", @"/Views/AdminPanel/Products/CategoryProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/Products/_ViewImports.cshtml")]
    public class Views_AdminPanel_Products_CategoryProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductPage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
   
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/products/categoryProducts.css";
    int categoryID = (int)Context.Items["itemID"];
    string categoryName = Context.Items["categoryName"] as string;
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
 if (DataCheck.HasAccessTo(AdminPanelPages.AddProduct, user, Context))
{

#line default
#line hidden
            BeginContext(436, 62, true);
            WriteLiteral("            <div class=\"addProductButton\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 498, "\"", 587, 5);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 505, Context.Request.Path, 505, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 526, "?pageID=", 526, 8, true);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 534, (int)AdminPanelPages.AddProduct, 534, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 568, "&itemID=", 568, 8, true);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 576, categoryID, 576, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(588, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(590, 70, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                                                                                                        Write(Html.Raw($"{localization.AddProductInCategory} <b>{categoryName}</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(660, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
}

#line default
#line hidden
            BeginContext(689, 170, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>Title</td>\r\n                    <td>URL</td>\r\n                    <td>");
            EndContext();
            BeginContext(860, 41, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.ActionsWithProduct));

#line default
#line hidden
            EndContext();
            BeginContext(901, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(969, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1016, 14, false);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(p.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1062, 17, false);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(p.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1111, 67, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(OtherFunctions.GetUrl(p.RequestPathWithoutAlias, p.Alias)));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
             if (DataCheck.HasAccessTo(AdminPanelPages.EditPage, user, Context))
            {

#line default
#line hidden
            BeginContext(1308, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1415, "\"", 1458, 1);
#line 33 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1423, (int)AdminPanelPages.EditProduct, 1423, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1459, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1526, "\"", 1539, 1);
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1534, p.ID, 1534, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1540, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1612, "\"", 1655, 1);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1620, Html.Raw(localization.EditProduct), 1620, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1656, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(1709, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
             if (DataCheck.HasAccessTo(AdminPanelPages.ProductImages, user, Context))
            {

#line default
#line hidden
            BeginContext(1811, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1918, "\"", 1963, 1);
#line 41 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1926, (int)AdminPanelPages.ProductImages, 1926, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1964, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2031, "\"", 2044, 1);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2039, p.ID, 2039, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2045, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2117, "\"", 2162, 1);
#line 43 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2125, Html.Raw(localization.ProductImages), 2125, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2163, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(2216, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
             if (DataCheck.HasAccessTo(AdminPanelPages.DeletePage, user, Context))
            {

#line default
#line hidden
            BeginContext(2315, 96, true);
            WriteLiteral("            <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2411, "\"", 2456, 1);
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2419, (int)AdminPanelPages.DeleteProduct, 2419, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2457, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2524, "\"", 2537, 1);
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2532, p.ID, 2532, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2538, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2610, "\"", 2655, 1);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2618, Html.Raw(localization.DeleteProduct), 2618, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2656, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(2709, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
    }

#line default
#line hidden
            BeginContext(2766, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductsLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591

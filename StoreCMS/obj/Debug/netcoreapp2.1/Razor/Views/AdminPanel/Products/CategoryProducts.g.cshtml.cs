#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca50dc123c677616481ccaa41618ca800b10a2af"
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
using Treynessen.OtherTypes;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
using Treynessen.Extensions;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca50dc123c677616481ccaa41618ca800b10a2af", @"/Views/AdminPanel/Products/CategoryProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/Products/_ViewImports.cshtml")]
    public class Views_AdminPanel_Products_CategoryProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductPage>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Treynessen.TagHelpers.ImageTagHelper __Treynessen_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 7 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
   
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/products/categoryProducts.css";
    int categoryID = (int)Context.Items["itemID"];
    string categoryName = Context.Items["categoryName"] as string;
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
 if (DataCheck.HasAccessTo(AdminPanelPages.AddProduct, user, Context))
{

#line default
#line hidden
            BeginContext(566, 62, true);
            WriteLiteral("            <div class=\"addProductButton\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 628, "\"", 717, 5);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 635, Context.Request.Path, 635, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 656, "?pageID=", 656, 8, true);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 664, (int)AdminPanelPages.AddProduct, 664, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 698, "&itemID=", 698, 8, true);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 706, categoryID, 706, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(718, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(720, 70, false);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                                                                                                        Write(Html.Raw($"{localization.AddProductInCategory} <b>{categoryName}</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(790, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
}

#line default
#line hidden
            BeginContext(819, 98, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td></td>\r\n                    <td>");
            EndContext();
            BeginContext(918, 27, false);
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(945, 65, true);
            WriteLiteral("</td>\r\n                    <td>URL</td>\r\n                    <td>");
            EndContext();
            BeginContext(1011, 41, false);
#line 25 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.ActionsWithProduct));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(1120, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1166, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31ddc556583645888ecc4cf8c8762026", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                        WriteLiteral(Html.Raw($"{env.GetProductsImagesPath(true)}{p.PreviousPageID.ToString()}{p.ID.ToString()}/{p.Alias}.jpg"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1328, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1360, 54, false);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw($"{p.PageName} <b>(ID{p.ID.ToString()})</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1446, 67, false);
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
                   Write(Html.Raw(OtherFunctions.GetUrl(p.RequestPathWithoutAlias, p.Alias)));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
             if (DataCheck.HasAccessTo(AdminPanelPages.EditProduct, user, Context))
            {

#line default
#line hidden
            BeginContext(1646, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1753, "\"", 1796, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1761, (int)AdminPanelPages.EditProduct, 1761, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1797, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1864, "\"", 1877, 1);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1872, p.ID, 1872, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1878, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1950, "\"", 1993, 1);
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 1958, Html.Raw(localization.EditProduct), 1958, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1994, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 41 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(2047, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
             if (DataCheck.HasAccessTo(AdminPanelPages.ProductImages, user, Context))
            {

#line default
#line hidden
            BeginContext(2149, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2256, "\"", 2301, 1);
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2264, (int)AdminPanelPages.ProductImages, 2264, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2302, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2369, "\"", 2382, 1);
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2377, p.ID, 2377, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2383, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2455, "\"", 2500, 1);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2463, Html.Raw(localization.ProductImages), 2463, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2501, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(2554, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
             if (DataCheck.HasAccessTo(AdminPanelPages.DeleteProduct, user, Context))
            {

#line default
#line hidden
            BeginContext(2656, 96, true);
            WriteLiteral("            <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2752, "\"", 2797, 1);
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2760, (int)AdminPanelPages.DeleteProduct, 2760, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2798, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2865, "\"", 2878, 1);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2873, p.ID, 2873, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2879, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2951, "\"", 2996, 1);
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
WriteAttributeValue("", 2959, Html.Raw(localization.DeleteProduct), 2959, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2997, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(3050, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\CategoryProducts.cshtml"
    }

#line default
#line hidden
            BeginContext(3107, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductsLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment env { get; private set; }
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

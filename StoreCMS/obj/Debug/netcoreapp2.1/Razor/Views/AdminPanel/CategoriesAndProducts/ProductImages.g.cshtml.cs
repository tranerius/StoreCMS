#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9f67f19f67516f211f5ed2159c7565a9f5116e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_ProductImages), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_ProductImages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9f67f19f67516f211f5ed2159c7565a9f5116e", @"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_ProductImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
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
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/products/productImages.css";
    Context.Items["PageName"] = localization.ProductImagesPageName;
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 9 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddProductImage, user, Context))
{

#line default
#line hidden
            BeginContext(385, 125, true);
            WriteLiteral("<form method=\"post\" class=\"uploadFileForm\" enctype=\"multipart/form-data\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 510, "\"", 557, 1);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 518, (int)AdminPanelPages.AddProductImage, 518, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(558, 90, true);
            WriteLiteral(">\r\n                <div class=\"inputFileButton\">\r\n                    <label for=\"upload\">");
            EndContext();
            BeginContext(649, 36, false);
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                   Write(Html.Raw(localization.ChooseTheFile));

#line default
#line hidden
            EndContext();
            BeginContext(685, 198, true);
            WriteLiteral("</label>\r\n                    <input type=\"file\" id=\"upload\" name=\"uploadedFile\" accept=\".png, .jpg, .jpeg\" />\r\n                </div>\r\n                <input type=\"submit\" />\r\n            </form>\r\n");
            EndContext();
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
}

#line default
#line hidden
            BeginContext(886, 38, true);
            WriteLiteral("            <div class=\"imagesList\">\r\n");
            EndContext();
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
      
        int imageID = 0;
    

#line default
#line hidden
            BeginContext(965, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
            BeginContext(1003, 67, true);
            WriteLiteral("                <div class=\"imageBlock\">\r\n                    <div>");
            EndContext();
            BeginContext(1070, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9709edd3fe7346699c7f149276c780bf", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                         WriteLiteral(m);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 290;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 175;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.Quality = 80;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("quality", __Treynessen_TagHelpers_ImageTagHelper.Quality, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1140, 35, true);
            WriteLiteral("</div>\r\n                    <label>");
            EndContext();
            BeginContext(1176, 35, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                      Write(m.Substring(m.LastIndexOf('/') + 1));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 110, true);
            WriteLiteral("</label>\r\n                    <form method=\"post\">\r\n                        <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1321, "\"", 1371, 1);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 1329, (int)AdminPanelPages.DeleteProductImage, 1329, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1372, 64, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"imageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1436, "\"", 1452, 1);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 1444, imageID, 1444, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1453, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProductImage, user, Context))
                {

#line default
#line hidden
            BeginContext(1579, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1623, "\"", 1673, 1);
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 1631, Html.Raw(localization.DeleteProductImage), 1631, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1674, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1739, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1783, "\"", 1833, 1);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 1791, Html.Raw(localization.DeleteProductImage), 1791, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1834, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }

#line default
#line hidden
            BeginContext(1867, 53, true);
            WriteLiteral("                    </form>\r\n                </div>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
        imageID++;
    }

#line default
#line hidden
            BeginContext(1947, 18, true);
            WriteLiteral("            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d33d8cc8d5fa512676faa0a246f6a099f2d2832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Products_ProductImages), @"mvc.1.0.view", @"/Views/AdminPanel/Products/ProductImages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Products/ProductImages.cshtml", typeof(AspNetCore.Views_AdminPanel_Products_ProductImages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d33d8cc8d5fa512676faa0a246f6a099f2d2832", @"/Views/AdminPanel/Products/ProductImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/Products/_ViewImports.cshtml")]
    public class Views_AdminPanel_Products_ProductImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
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
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/products/productImages.css";
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
 if (DataCheck.HasAccessTo(AdminPanelPages.AddProductImage, user, Context))
{

#line default
#line hidden
            BeginContext(308, 121, true);
            WriteLiteral("    <form method=\"post\" class=\"uploadFileForm\" enctype=\"multipart/form-data\">\r\n        <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 429, "\"", 476, 1);
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
WriteAttributeValue("", 437, (int)AdminPanelPages.AddProductImage, 437, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(477, 74, true);
            WriteLiteral(">\r\n        <div class=\"inputFileButton\">\r\n            <label for=\"upload\">");
            EndContext();
            BeginContext(552, 36, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
                           Write(Html.Raw(localization.ChooseTheFile));

#line default
#line hidden
            EndContext();
            BeginContext(588, 166, true);
            WriteLiteral("</label>\r\n            <input type=\"file\" id=\"upload\" name=\"uploadedFile\" accept=\".png, .jpg, .jpeg\" />\r\n        </div>\r\n        <input type=\"submit\" />\r\n    </form>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
}

#line default
#line hidden
            BeginContext(757, 26, true);
            WriteLiteral("<div class=\"imagesList\">\r\n");
            EndContext();
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
       
        int imageID = 0;
    

#line default
#line hidden
            BeginContext(825, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
            BeginContext(863, 51, true);
            WriteLiteral("        <div class=\"imageBlock\">\r\n            <div>");
            EndContext();
            BeginContext(914, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b405f6d413d4d2b99bb3d52422fa312", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
                       WriteLiteral(m);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.FullPath = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("full-path", __Treynessen_TagHelpers_ImageTagHelper.FullPath, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 290;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 175;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
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
            BeginContext(990, 27, true);
            WriteLiteral("</div>\r\n            <label>");
            EndContext();
            BeginContext(1018, 36, false);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
              Write(m.Substring(m.LastIndexOf('\\') + 1));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 94, true);
            WriteLiteral("</label>\r\n            <form method=\"post\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1148, "\"", 1198, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
WriteAttributeValue("", 1156, (int)AdminPanelPages.DeleteProductImage, 1156, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1199, 56, true);
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"imageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1255, "\"", 1271, 1);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
WriteAttributeValue("", 1263, imageID, 1263, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1272, 39, true);
            WriteLiteral(">\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1311, "\"", 1361, 1);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
WriteAttributeValue("", 1319, Html.Raw(localization.DeleteProductImage), 1319, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1362, 42, true);
            WriteLiteral(" />\r\n            </form>\r\n        </div>\r\n");
            EndContext();
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Products\ProductImages.cshtml"
        ++imageID;
    }

#line default
#line hidden
            BeginContext(1431, 8, true);
            WriteLiteral("</div>\r\n");
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

#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b775a55a1c7e2ef42e201e7195774b85198672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Settings_product_block), @"mvc.1.0.view", @"/Settings/product_block.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Settings/product_block.cshtml", typeof(AspNetCore.Settings_product_block))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
using Treynessen.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
using Treynessen.ImagesManagement;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b775a55a1c7e2ef42e201e7195774b85198672", @"/Settings/product_block.cshtml")]
    public class Settings_product_block : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductPage>
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
            BeginContext(182, 18, true);
            WriteLiteral("<a class=\"product\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 200, "\"", 278, 1);
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
WriteAttributeValue("", 207, Model != null ? Html.Raw(Model.RequestPath) : Html.Raw(string.Empty), 207, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(279, 1, true);
            WriteLiteral(">");
            EndContext();
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                                                                                     if(Model is ProductPage && (Model as ProductPage).Price > 0 && (Model as ProductPage).OldPrice > 0) { 

#line default
#line hidden
            BeginContext(386, 39, false);
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                                                                                                                                                                                      Write(Html.Raw("<div class=\"stock\"></div>"));

#line default
#line hidden
            EndContext();
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                                                                                                                                                                                                                                    } 

#line default
#line hidden
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                                                                                                                                                                                                                                          if(Model is ProductPage && (Model as ProductPage).SpecialProduct) { 

#line default
#line hidden
            BeginContext(501, 38, false);
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                                                                                                                                                                                                                                                                                                         Write(Html.Raw("<div class=\"best\"></div>"));

#line default
#line hidden
            EndContext();
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                                                                                                                                                                                                                                                                                                                                                      } 

#line default
#line hidden
            BeginContext(545, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(546, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094210c34c6d476abdbaedb538de25d4", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 7 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
     WriteLiteral(Model is ProductPage ? "/images/products/" + (Model as ProductPage).PreviousPageID.ToString() + Model.ID.ToString() + "/" + Model.Alias + ".jpg" : string.Empty);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.Width = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("width", __Treynessen_TagHelpers_ImageTagHelper.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.Height = 115;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("height", __Treynessen_TagHelpers_ImageTagHelper.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.Quality = 90;

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
            BeginContext(768, 58, true);
            WriteLiteral("\r\n\t<div class=\"productInfo\">\r\n\t\t<span class=\"productName\">");
            EndContext();
            BeginContext(828, 89, false);
#line 9 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                              Write(Model is ProductPage ? Html.Raw((Model as ProductPage).PageName) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(918, 47, true);
            WriteLiteral("</span>\r\n\t\t<div class=\"shortDescription\"><span>");
            EndContext();
            BeginContext(967, 97, false);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                                        Write(Model is ProductPage ? Html.Raw((Model as ProductPage).ShortDescription) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 51, true);
            WriteLiteral("</span></div>\r\n\t</div>\r\n\t<div class=\"productPrice\">");
            EndContext();
            BeginContext(1118, 324, false);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Settings\product_block.cshtml"
                          Write(Model is ProductPage && (Model as ProductPage).OldPrice != 0 ? Html.Raw("<span>" + OtherFunctions.FormatPrice((Model as ProductPage).Price) + "</span><span>" + OtherFunctions.FormatPrice((Model as ProductPage).OldPrice) + "</span>") : Html.Raw("<span>" + OtherFunctions.FormatPrice((Model as ProductPage).Price) + "</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 12, true);
            WriteLiteral("</div>\r\n</a>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductPage> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aff06710fb8ff449a27020f9148c5a3a3986fd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Templates_product_page_template), @"mvc.1.0.view", @"/Views/Templates/product_page_template.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Templates/product_page_template.cshtml", typeof(AspNetCore.Views_Templates_product_page_template))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Controllers;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.ImagesManagement;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aff06710fb8ff449a27020f9148c5a3a3986fd3", @"/Views/Templates/product_page_template.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea0ac9dd8e29f1d582e77aa90a16654937768a3", @"/Views/Templates/_ViewImports.cshtml")]
    public class Views_Templates_product_page_template : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n");
            EndContext();
            BeginContext(47, 809, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d12a59c25e5b4a7fa592e5b29756f68b", async() => {
                BeginContext(53, 9, true);
                WriteLiteral("\r\n<title>");
                EndContext();
                BeginContext(64, 62, false);
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
   Write(Model != null ? Html.Raw(Model.Title) : Html.Raw(string.Empty));

#line default
#line hidden
                EndContext();
                BeginContext(127, 474, true);
                WriteLiteral(@"</title> 
<link rel=""stylesheet"" href=""/styles/common.css"">
<link rel=""stylesheet"" href=""/styles/header.css"">
<link rel=""stylesheet"" href=""/styles/menu.css"">
<link rel=""stylesheet"" href=""/styles/product_page_slider.css"">
<link rel=""stylesheet"" href=""/styles/product_page_content.css"">
<link rel=""stylesheet"" href=""/styles/footer.css"">
<link rel=""icon"" href=""/favicon.ico"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
<meta name=""description""");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 601, "\"", 686, 1);
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
WriteAttributeValue("", 611, Model != null ? Html.Raw(Model.PageDescription) : Html.Raw(string.Empty), 611, 75, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(687, 24, true);
                WriteLiteral(">\r\n<meta name=\"keywords\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 711, "\"", 793, 1);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
WriteAttributeValue("", 721, Model != null ? Html.Raw(Model.PageKeywords) : Html.Raw(string.Empty), 721, 72, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(794, 55, true);
                WriteLiteral(">\r\n<meta name=\"robots\" content=\"[Page:IsRobotIndex]\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(856, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(858, 672, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef52c6e3c9c4cfd8f01ea66acc7ce1d", async() => {
                BeginContext(864, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(876, 62, false);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/header.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
                                                                         } catch { } 

#line default
#line hidden
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(964, 60, false);
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/menu.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
                                                                       } catch { } 

#line default
#line hidden
                BeginContext(1040, 293, true);
                WriteLiteral(@"<script>
	var catalog = document.getElementById('catalog');
	var button = catalog.querySelector('.button');
	button.onclick = function() {
		catalog.classList.toggle('open');
	};
</script>
<script src=""/styles/jquery-2-min.js""></script>
<script src=""/styles/jslider-min.js""></script>
");
                EndContext();
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1343, 76, false);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/product_page_content.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
                                                                                       } catch { } 

#line default
#line hidden
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1445, 62, false);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/footer.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Templates\product_page_template.cshtml"
                                                                         } catch { } 

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1530, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page> Html { get; private set; }
    }
}
#pragma warning restore 1591

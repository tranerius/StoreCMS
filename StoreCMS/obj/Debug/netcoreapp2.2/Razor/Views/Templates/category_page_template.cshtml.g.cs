#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34bd633c8cd8c0b9d8b9591d5bbe14753ed058c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Templates_category_page_template), @"mvc.1.0.view", @"/Views/Templates/category_page_template.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Templates/category_page_template.cshtml", typeof(AspNetCore.Views_Templates_category_page_template))]
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
#line 1 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Functions;

#line default
#line hidden
#line 2 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Controllers;

#line default
#line hidden
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.ImagesManagement;

#line default
#line hidden
#line 5 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34bd633c8cd8c0b9d8b9591d5bbe14753ed058c", @"/Views/Templates/category_page_template.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a171fe621900d30ce349d435054eba87062936fb", @"/Views/Templates/_ViewImports.cshtml")]
    public class Views_Templates_category_page_template : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
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
            BeginContext(12, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"ru\">\n");
            EndContext();
            BeginContext(45, 1180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f34bd633c8cd8c0b9d8b9591d5bbe14753ed058c4176", async() => {
                BeginContext(51, 8, true);
                WriteLiteral("\n<title>");
                EndContext();
                BeginContext(61, 62, false);
#line 5 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
   Write(Model != null ? Html.Raw(Model.Title) : Html.Raw(string.Empty));

#line default
#line hidden
                EndContext();
                BeginContext(124, 500, true);
                WriteLiteral(@" по самой низкой цене в Калининграде - Магазин «Инструмент»</title> 
<link rel=""stylesheet"" href=""/styles/common.css"">
<link rel=""stylesheet"" href=""/styles/header.css"">
<link rel=""stylesheet"" href=""/styles/menu.css"">
<link rel=""stylesheet"" href=""/styles/content.css"">
<link rel=""stylesheet"" href=""/styles/category.css"">
<link rel=""stylesheet"" href=""/styles/footer.css"">
<link rel=""icon"" href=""/favicon.ico"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
<meta name=""description""");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 624, "\"", 789, 11);
#line 14 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
WriteAttributeValue("", 634, Model != null ? Html.Raw(Model.PageDescription) : Html.Raw(string.Empty), 634, 75, false);

#line default
#line hidden
                WriteAttributeValue(" ", 709, "в", 710, 2, true);
                WriteAttributeValue(" ", 711, "Калининграде", 712, 13, true);
                WriteAttributeValue(" ", 724, "по", 725, 3, true);
                WriteAttributeValue(" ", 727, "самой", 728, 6, true);
                WriteAttributeValue(" ", 733, "выгодной", 734, 9, true);
                WriteAttributeValue(" ", 742, "цене!", 743, 6, true);
                WriteAttributeValue(" ", 748, "Приходите!", 749, 11, true);
                WriteAttributeValue(" ", 759, "Постоянным", 760, 11, true);
                WriteAttributeValue(" ", 770, "клиентам", 771, 9, true);
                WriteAttributeValue(" ", 779, "скидки!!!", 780, 10, true);
                EndWriteAttribute();
                BeginContext(790, 23, true);
                WriteLiteral(">\n<meta name=\"keywords\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 813, "\"", 924, 6);
#line 15 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
WriteAttributeValue("", 823, Model != null ? Html.Raw(Model.PageKeywords) : Html.Raw(string.Empty), 823, 72, false);

#line default
#line hidden
                WriteAttributeValue("", 895, ",", 895, 1, true);
                WriteAttributeValue(" ", 896, "Калининград,", 897, 13, true);
                WriteAttributeValue(" ", 909, "по", 910, 3, true);
                WriteAttributeValue(" ", 912, "низкой", 913, 7, true);
                WriteAttributeValue(" ", 919, "цене", 920, 5, true);
                EndWriteAttribute();
                BeginContext(925, 21, true);
                WriteLiteral(">\n<meta name=\"robots\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 946, "\"", 1163, 3);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
WriteAttributeValue("", 956, Model != null ? (Model.IsIndex ? Html.Raw("index") : Html.Raw("noindex")) : Html.Raw(string.Empty), 956, 101, false);

#line default
#line hidden
                WriteAttributeValue("", 1057, ",", 1057, 1, true);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
WriteAttributeValue(" ", 1058, Model != null ? (Model.IsFollow ? Html.Raw("follow") : Html.Raw("nofollow")) : Html.Raw(string.Empty), 1059, 104, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1164, 54, true);
                WriteLiteral(">\n<meta name=\"viewport\" content=\"width=device-width\">\n");
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
            BeginContext(1225, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1226, 748, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f34bd633c8cd8c0b9d8b9591d5bbe14753ed058c9355", async() => {
                BeginContext(1232, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1243, 62, false);
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/header.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
                                                                         } catch { } 

#line default
#line hidden
#line 21 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1330, 60, false);
#line 21 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/menu.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 21 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
                                                                       } catch { } 

#line default
#line hidden
#line 22 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1415, 77, false);
#line 22 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/category_page_content.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 22 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
                                                                                        } catch { } 

#line default
#line hidden
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1517, 62, false);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/footer.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
                                                                         } catch { } 

#line default
#line hidden
                BeginContext(1594, 285, true);
                WriteLiteral(@"<script src=""/scripts/copy_event_handler.js""></script>
<script>
	let elements = document.getElementsByClassName('short-description');
	for (let i = 0; i < elements.length; ++i){
		elements.item(i).oncopy = copyEventHandler ;
	}
</script>
<script src=""/scripts/price_sort.js""></script>
");
                EndContext();
#line 32 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
   try { 

#line default
#line hidden
                BeginContext(1889, 63, false);
#line 32 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
    Write(await Html.PartialAsync("~/Views/Chunks/scripts.cshtml", Model));

#line default
#line hidden
                EndContext();
#line 32 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\Templates\category_page_template.cshtml"
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
            BeginContext(1974, 9, true);
            WriteLiteral("\n</html>\n");
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
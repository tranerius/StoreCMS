#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7f9555d92a325abde69758361d9f875927facf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chunks_product_page_content), @"mvc.1.0.view", @"/Views/Chunks/product_page_content.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chunks/product_page_content.cshtml", typeof(AspNetCore.Views_Chunks_product_page_content))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Controllers;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.ImagesManagement;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7f9555d92a325abde69758361d9f875927facf", @"/Views/Chunks/product_page_content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea0ac9dd8e29f1d582e77aa90a16654937768a3", @"/Views/Chunks/_ViewImports.cshtml")]
    public class Views_Chunks_product_page_content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
   Dictionary<int, int> counters = new Dictionary<int, int>(); 

#line default
#line hidden
            BeginContext(76, 56, true);
            WriteLiteral("<div class=\"contentBlock\">\r\n<div class=\"navigationMenu\">");
            EndContext();
            BeginContext(134, 72, false);
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                        Write(Model != null ? Html.Raw(Model.BreadcrumbsHtml) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(207, 3, true);
            WriteLiteral(" → ");
            EndContext();
            BeginContext(212, 65, false);
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                      Write(Model != null ? Html.Raw(Model.PageName) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(278, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
   if(!counters.ContainsKey(10)) { counters.Add(10, 0); } 

#line default
#line hidden
            BeginContext(352, 14, false);
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                            Write(++counters[10]);

#line default
#line hidden
            EndContext();
            BeginContext(376, 4, true);
            WriteLiteral("<br>");
            EndContext();
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                 if(!counters.ContainsKey(10)) { counters.Add(10, 0); } 

#line default
#line hidden
            BeginContext(446, 14, false);
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                                                                          Write(++counters[10]);

#line default
#line hidden
            EndContext();
            BeginContext(472, 7, true);
            WriteLiteral("</div>1");
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
#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd87aa14e8c3dd4c1e5ff077d3ab35f97a66819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Redirections), @"mvc.1.0.view", @"/Views/AdminPanel/Redirections.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Redirections.cshtml", typeof(AspNetCore.Views_AdminPanel_Redirections))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd87aa14e8c3dd4c1e5ff077d3ab35f97a66819", @"/Views/AdminPanel/Redirections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Redirections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Redirection[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
  
    Layout = "CommonPage";
    User user = Context.Items["User"] as User;
    Context.Items["PageName"] = localization.PageName;
    Context.Items["PageStyle"] = "/styles/admin_panel/redirections.css";

#line default
#line hidden
            BeginContext(283, 156, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/send_data.js\"></script>\r\n                <script>\r\n                    function error() {\r\n                        alert(\'");
            EndContext();
            BeginContext(440, 47, false);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                          Write(Html.Raw(localization.RequestCannotBeCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(487, 112, true);
            WriteLiteral("\');\r\n                    }\r\n                    function successfullyEdited() {\r\n                        alert(\'");
            EndContext();
            BeginContext(600, 40, false);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                          Write(Html.Raw(localization.RedirectionEdited));

#line default
#line hidden
            EndContext();
            BeginContext(640, 157, true);
            WriteLiteral("\');\r\n                        location.reload();\r\n                    }\r\n                    function successfullyDeleted() {\r\n                        alert(\'");
            EndContext();
            BeginContext(798, 41, false);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                          Write(Html.Raw(localization.RedirectionDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(839, 103, true);
            WriteLiteral("\');\r\n                        location.reload();\r\n                    }\r\n                    </script>\r\n");
            EndContext();
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddSynonymForString, user, Context))
{

#line default
#line hidden
            BeginContext(1034, 162, true);
            WriteLiteral("                    <form id=\"add-redirection-form\" class=\"container\">\r\n                        <div class=\"link\">\r\n                            <label for=\"link\">");
            EndContext();
            BeginContext(1197, 27, false);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                         Write(Html.Raw(localization.Link));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 241, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"link\" name=\"RedirectionModel.RequestPath\">\r\n                        </div>\r\n                        <div class=\"redirection\">\r\n                            <label for=\"redirection\">");
            EndContext();
            BeginContext(1466, 34, false);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                Write(Html.Raw(localization.Redirection));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 270, true);
            WriteLiteral(@"</label>
                            <input type=""text"" id=""redirection"" name=""RedirectionModel.RedirectionPath"">
                        </div>
                        <div class=""action"">
                            <input type=""submit"" id=""add-redirection-button""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1770, "\"", 1805, 1);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 1778, Html.Raw(localization.Add), 1778, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1806, 185, true);
            WriteLiteral(">\r\n                        </div>\r\n                    </form>\r\n                    <script>\r\n                        function successfullyAdded() {\r\n                            alert(\'");
            EndContext();
            BeginContext(1992, 39, false);
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                              Write(Html.Raw(localization.RedirectionAdded));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 276, true);
            WriteLiteral(@"');
                            location.reload();
                        }
                        let addSubmit = document.getElementById('add-redirection-button');
                        addSubmit.addEventListener('click', createSendDataEventHandler('POST', '?pageID=");
            EndContext();
            BeginContext(2309, 35, false);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                    Write((int)AdminPanelPages.AddRedirection);

#line default
#line hidden
            EndContext();
            BeginContext(2345, 87, true);
            WriteLiteral("\', \'add-redirection-form\', successfullyAdded, error));\r\n                    </script>\r\n");
            EndContext();
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
}

#line default
#line hidden
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
 foreach (var pair in Model)
{

#line default
#line hidden
            BeginContext(2468, 25, true);
            WriteLiteral("                    <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2493, "\"", 2518, 2);
            WriteAttributeValue("", 2498, "redirection-", 2498, 12, true);
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 2510, pair.ID, 2510, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2519, 79, true);
            WriteLiteral(" class=\"container\">\r\n                        <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2598, "\"", 2614, 1);
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 2606, pair.ID, 2606, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2615, 81, true);
            WriteLiteral(">\r\n                        <div class=\"link\">\r\n                            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2696, "\"", 2715, 2);
            WriteAttributeValue("", 2702, "link-", 2702, 5, true);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 2707, pair.ID, 2707, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2716, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2718, 27, false);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                  Write(Html.Raw(localization.Link));

#line default
#line hidden
            EndContext();
            BeginContext(2745, 56, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2801, "\"", 2819, 2);
            WriteAttributeValue("", 2806, "link-", 2806, 5, true);
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 2811, pair.ID, 2811, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2820, 36, true);
            WriteLiteral(" name=\"RedirectionModel.RequestPath\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2856, "\"", 2882, 1);
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 2864, pair?.RequestPath, 2864, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2883, 120, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"redirection\">\r\n                            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 3003, "\"", 3029, 2);
            WriteAttributeValue("", 3009, "redirection-", 3009, 12, true);
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3021, pair.ID, 3021, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3030, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3032, 34, false);
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                         Write(Html.Raw(localization.Redirection));

#line default
#line hidden
            EndContext();
            BeginContext(3066, 56, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3122, "\"", 3147, 2);
            WriteAttributeValue("", 3127, "redirection-", 3127, 12, true);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3139, pair.ID, 3139, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3148, 40, true);
            WriteLiteral(" name=\"RedirectionModel.RedirectionPath\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3188, "\"", 3218, 1);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3196, pair?.RedirectionPath, 3196, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3219, 82, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"actions\">\r\n");
            EndContext();
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
             if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditSynonymForString, user, Context))
            {

#line default
#line hidden
            BeginContext(3418, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3466, "\"", 3503, 2);
            WriteAttributeValue("", 3471, "edit-redirection-button-", 3471, 24, true);
#line 62 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3495, pair.ID, 3495, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3504, "\"", 3540, 1);
#line 62 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3512, Html.Raw(localization.Edit), 3512, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3541, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3592, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3640, "\"", 3676, 1);
#line 66 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3648, Html.Raw(localization.Edit), 3648, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3677, 12, true);
            WriteLiteral(" disabled>\r\n");
            EndContext();
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
            }

#line default
#line hidden
            BeginContext(3704, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 68 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
             if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteSynonymForString, user, Context))
            {

#line default
#line hidden
            BeginContext(3823, 36, true);
            WriteLiteral("                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3859, "\"", 3898, 2);
            WriteAttributeValue("", 3864, "delete-redirection-button-", 3864, 26, true);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3890, pair.ID, 3890, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3899, "\"", 3937, 1);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 3907, Html.Raw(localization.Delete), 3907, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3938, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3989, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4037, "\"", 4075, 1);
#line 74 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
WriteAttributeValue("", 4045, Html.Raw(localization.Delete), 4045, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4076, 12, true);
            WriteLiteral(" disabled>\r\n");
            EndContext();
#line 75 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
            }

#line default
#line hidden
            BeginContext(4103, 130, true);
            WriteLiteral("                        </div>\r\n                    </form>\r\n                    <script>\r\n                        let editButton_");
            EndContext();
            BeginContext(4235, 7, false);
#line 79 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                   Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4243, 52, true);
            WriteLiteral(" = document.getElementById(\'edit-redirection-button-");
            EndContext();
            BeginContext(4297, 7, false);
#line 79 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                 Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4305, 40, true);
            WriteLiteral("\');\r\n                        editButton_");
            EndContext();
            BeginContext(4347, 7, false);
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                               Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4355, 71, true);
            WriteLiteral(".addEventListener(\'click\', createSendDataEventHandler(\'POST\', \'?pageID=");
            EndContext();
            BeginContext(4428, 36, false);
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                                Write((int)AdminPanelPages.EditRedirection);

#line default
#line hidden
            EndContext();
            BeginContext(4465, 16, true);
            WriteLiteral("\', \'redirection-");
            EndContext();
            BeginContext(4483, 7, false);
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                                                                                       Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4491, 74, true);
            WriteLiteral("\', successfullyEdited, error));\r\n                        let deleteButton_");
            EndContext();
            BeginContext(4567, 7, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                     Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4575, 54, true);
            WriteLiteral(" = document.getElementById(\'delete-redirection-button-");
            EndContext();
            BeginContext(4631, 7, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                     Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4639, 42, true);
            WriteLiteral("\');\r\n                        deleteButton_");
            EndContext();
            BeginContext(4683, 7, false);
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                 Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4691, 73, true);
            WriteLiteral(".addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'?pageID=");
            EndContext();
            BeginContext(4766, 38, false);
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                                    Write((int)AdminPanelPages.DeleteRedirection);

#line default
#line hidden
            EndContext();
            BeginContext(4805, 16, true);
            WriteLiteral("\', \'redirection-");
            EndContext();
            BeginContext(4823, 7, false);
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
                                                                                                                                                                             Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4831, 65, true);
            WriteLiteral("\', successfullyDeleted, error));\r\n                    </script>\r\n");
            EndContext();
#line 84 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Redirections.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRedirectionsLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Redirection[]> Html { get; private set; }
    }
}
#pragma warning restore 1591

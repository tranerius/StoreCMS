#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac3145baf321cb7dc0cd5958fe554e5dbe7d9960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_FileManager_Index), @"mvc.1.0.view", @"/Views/AdminPanel/FileManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/FileManager/Index.cshtml", typeof(AspNetCore.Views_AdminPanel_FileManager_Index))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
using Treynessen.FileManagerManagement;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac3145baf321cb7dc0cd5958fe554e5dbe7d9960", @"/Views/AdminPanel/FileManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_FileManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileManagerObject[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/file_manager/index.css";
    Context.Items["PageName"] = localization.FileManagerPageName;
    LinkedList<KeyValuePair<string, string>> breadcrumbs = Context.Items["CurrentDirectoryBreadcrumbs"] as LinkedList<KeyValuePair<string, string>>;
    // Key - название, Value - путь
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(535, 30, true);
            WriteLiteral("<div class=\"breadcrumbList\">\r\n");
            EndContext();
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
     for (LinkedListNode<KeyValuePair<string, string>> node = breadcrumbs.First; node != null; node = node.Next)
    {
        if (node.Next != null)
        {

#line default
#line hidden
            BeginContext(729, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 747, "\"", 905, 4);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 754, Context.Request.Path, 754, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 775, "?pageID=", 775, 8, true);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 783, (int)AdminPanelPages.FileManager, 783, 35, false);

#line default
#line hidden
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 818, !string.IsNullOrEmpty(node.Value.Value) ? $"&path={node.Value.Value}" : string.Empty, 818, 87, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(906, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(908, 24, false);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                                                                                             Write(Html.Raw(node.Value.Key));

#line default
#line hidden
            EndContext();
            BeginContext(932, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(974, 21, true);
            WriteLiteral("                <div>");
            EndContext();
            BeginContext(996, 24, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                Write(Html.Raw(node.Value.Key));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1046, 58, true);
            WriteLiteral("            </div>\r\n            <div class=\"actionList\">\r\n");
            EndContext();
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
     if (SecurityFunctions.HasAccessTo(AdminPanelPages.UploadFile, user, Context))
    {

#line default
#line hidden
            BeginContext(1195, 145, true);
            WriteLiteral("                <form method=\"post\" class=\"uploadFileForm\" enctype=\"multipart/form-data\">\r\n                    <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1340, "\"", 1382, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 1348, (int)AdminPanelPages.UploadFile, 1348, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1383, 55, true);
            WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"path\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1438, "\"", 1475, 1);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 1446, breadcrumbs.Last.Value.Value, 1446, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1476, 98, true);
            WriteLiteral(">\r\n                    <div class=\"inputFileButton\">\r\n                        <label for=\"upload\">");
            EndContext();
            BeginContext(1575, 36, false);
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                       Write(Html.Raw(localization.ChooseTheFile));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 243, true);
            WriteLiteral("</label>\r\n                        <input type=\"file\" id=\"upload\" name=\"uploadedFile\" accept=\".png, .jpg, .jpeg, .bmp, .gif, .css, .js, .ico\" />\r\n                    </div>\r\n                    <input type=\"submit\" />\r\n                </form>\r\n");
            EndContext();
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1861, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
     if (SecurityFunctions.HasAccessTo(AdminPanelPages.CreateFolder, user, Context))
    {

#line default
#line hidden
            BeginContext(1954, 126, true);
            WriteLiteral("                <form method=\"post\" class=\"createFolerOrTemplateFile\">\r\n                    <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2080, "\"", 2124, 1);
#line 41 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2088, (int)AdminPanelPages.CreateFolder, 2088, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2125, 55, true);
            WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"path\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2180, "\"", 2217, 1);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2188, breadcrumbs.Last.Value.Value, 2188, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2218, 45, true);
            WriteLiteral(" />\r\n                    <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2263, "\"", 2301, 1);
#line 43 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2271, Html.Raw(localization.Create), 2271, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2302, 55, true);
            WriteLiteral(" />\r\n                    <input type=\"text\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2357, "\"", 2405, 1);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2371, Html.Raw(localization.FolderName), 2371, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2406, 30, true);
            WriteLiteral(" />\r\n                </form>\r\n");
            EndContext();
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2443, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
     if (SecurityFunctions.HasAccessTo(AdminPanelPages.CreateStyle, user, Context))
    {

#line default
#line hidden
            BeginContext(2535, 126, true);
            WriteLiteral("                <form method=\"post\" class=\"createFolerOrTemplateFile\">\r\n                    <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2661, "\"", 2704, 1);
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2669, (int)AdminPanelPages.CreateStyle, 2669, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2705, 55, true);
            WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"path\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2760, "\"", 2797, 1);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2768, breadcrumbs.Last.Value.Value, 2768, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2798, 45, true);
            WriteLiteral(" />\r\n                    <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2843, "\"", 2881, 1);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2851, Html.Raw(localization.Create), 2851, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2882, 55, true);
            WriteLiteral(" />\r\n                    <input type=\"text\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2937, "\"", 2986, 1);
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 2951, Html.Raw(localization.CssFileName), 2951, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2987, 30, true);
            WriteLiteral(" />\r\n                </form>\r\n");
            EndContext();
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3024, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
     if (SecurityFunctions.HasAccessTo(AdminPanelPages.CreateScript, user, Context))
    {

#line default
#line hidden
            BeginContext(3117, 126, true);
            WriteLiteral("                <form method=\"post\" class=\"createFolerOrTemplateFile\">\r\n                    <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3243, "\"", 3287, 1);
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 3251, (int)AdminPanelPages.CreateScript, 3251, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3288, 55, true);
            WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"path\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3343, "\"", 3380, 1);
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 3351, breadcrumbs.Last.Value.Value, 3351, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3381, 45, true);
            WriteLiteral(" />\r\n                    <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3426, "\"", 3464, 1);
#line 61 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 3434, Html.Raw(localization.Create), 3434, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3465, 55, true);
            WriteLiteral(" />\r\n                    <input type=\"text\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 3520, "\"", 3572, 1);
#line 62 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 3534, Html.Raw(localization.ScriptFileName), 3534, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3573, 30, true);
            WriteLiteral(" />\r\n                </form>\r\n");
            EndContext();
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3610, 87, true);
            WriteLiteral("            </div>\r\n            <table>\r\n                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(3698, 27, false);
#line 68 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                   Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3725, 61, true);
            WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
     foreach (var f in Model)
    {

#line default
#line hidden
            BeginContext(3824, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 74 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
             if (f.Type == FileManagerObjectType.Folder)
            {

#line default
#line hidden
            BeginContext(3919, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3945, "\"", 4034, 5);
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 3952, Context.Request.Path, 3952, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3973, "?pageID=", 3973, 8, true);
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 3981, (int)AdminPanelPages.FileManager, 3981, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 4016, "&path=", 4016, 6, true);
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 4022, f.ShortPath, 4022, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4035, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4037, 29, false);
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                                Write(Html.Raw(localization.Folder));

#line default
#line hidden
            EndContext();
            BeginContext(4066, 5, true);
            WriteLiteral(": <b>");
            EndContext();
            BeginContext(4072, 16, false);
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                                                                   Write(Html.Raw(f.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4088, 15, true);
            WriteLiteral("</b></a></td>\r\n");
            EndContext();
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
            }
            else if (f.Type == FileManagerObjectType.Image)
            {

#line default
#line hidden
            BeginContext(4194, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4220, "\"", 4258, 2);
            WriteAttributeValue("", 4227, "/", 4227, 1, true);
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 4228, f.ShortPath.Replace('>', '/'), 4228, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4259, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4261, 28, false);
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                             Write(Html.Raw(localization.Image));

#line default
#line hidden
            EndContext();
            BeginContext(4289, 5, true);
            WriteLiteral(": <b>");
            EndContext();
            BeginContext(4295, 16, false);
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                               Write(Html.Raw(f.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4311, 15, true);
            WriteLiteral("</b></a></td>\r\n");
            EndContext();
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
            }
            else if (f.Type == FileManagerObjectType.Script)
            {
                if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditScript, user, Context))
                {

#line default
#line hidden
            BeginContext(4532, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4558, "\"", 4646, 5);
#line 86 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 4565, Context.Request.Path, 4565, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4586, "?pageID=", 4586, 8, true);
#line 86 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 4594, (int)AdminPanelPages.EditScript, 4594, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 4628, "&path=", 4628, 6, true);
#line 86 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 4634, f.ShortPath, 4634, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4647, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4649, 29, false);
#line 86 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                               Write(Html.Raw(localization.Script));

#line default
#line hidden
            EndContext();
            BeginContext(4678, 5, true);
            WriteLiteral(": <b>");
            EndContext();
            BeginContext(4684, 16, false);
#line 86 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                                                                  Write(Html.Raw(f.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4700, 15, true);
            WriteLiteral("</b></a></td>\r\n");
            EndContext();
#line 87 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4775, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4801, "\"", 4839, 2);
            WriteAttributeValue("", 4808, "/", 4808, 1, true);
#line 90 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 4809, f.ShortPath.Replace('>', '/'), 4809, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4840, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4842, 29, false);
#line 90 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                             Write(Html.Raw(localization.Script));

#line default
#line hidden
            EndContext();
            BeginContext(4871, 5, true);
            WriteLiteral(": <b>");
            EndContext();
            BeginContext(4877, 16, false);
#line 90 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                Write(Html.Raw(f.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4893, 15, true);
            WriteLiteral("</b></a></td>\r\n");
            EndContext();
#line 91 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                }
            }
            else
            {
                if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditStyle, user, Context))
                {

#line default
#line hidden
            BeginContext(5088, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5114, "\"", 5201, 5);
#line 97 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 5121, Context.Request.Path, 5121, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 5142, "?pageID=", 5142, 8, true);
#line 97 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 5150, (int)AdminPanelPages.EditStyle, 5150, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 5183, "&path=", 5183, 6, true);
#line 97 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 5189, f.ShortPath, 5189, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5202, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5204, 28, false);
#line 97 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                              Write(Html.Raw(localization.Style));

#line default
#line hidden
            EndContext();
            BeginContext(5232, 5, true);
            WriteLiteral(": <b>");
            EndContext();
            BeginContext(5238, 16, false);
#line 97 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                                                                                Write(Html.Raw(f.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5254, 15, true);
            WriteLiteral("</b></a></td>\r\n");
            EndContext();
#line 98 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5329, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5355, "\"", 5393, 2);
            WriteAttributeValue("", 5362, "/", 5362, 1, true);
#line 101 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 5363, f.ShortPath.Replace('>', '/'), 5363, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5394, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5396, 28, false);
#line 101 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                             Write(Html.Raw(localization.Style));

#line default
#line hidden
            EndContext();
            BeginContext(5424, 5, true);
            WriteLiteral(": <b>");
            EndContext();
            BeginContext(5430, 16, false);
#line 101 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                                                                                               Write(Html.Raw(f.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5446, 15, true);
            WriteLiteral("</b></a></td>\r\n");
            EndContext();
#line 102 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(5495, 26, true);
            WriteLiteral("                    <td>\r\n");
            EndContext();
#line 105 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteFileOrFolder, user, Context))
                {
                    if (f.CanDelete)
                    {

#line default
#line hidden
            BeginContext(5705, 108, true);
            WriteLiteral("                        <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5813, "\"", 5863, 1);
#line 110 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 5821, (int)AdminPanelPages.DeleteFileOrFolder, 5821, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5864, 63, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"path\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5927, "\"", 5947, 1);
#line 111 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 5935, f.ShortPath, 5935, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5948, 74, true);
            WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"deleteButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6022, "\"", 6060, 1);
#line 112 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 6030, Html.Raw(localization.Delete), 6030, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6061, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 114 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(6171, 82, true);
            WriteLiteral("                        <input type=\"submit\" class=\"disabledDeleteButton\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6253, "\"", 6291, 1);
#line 117 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
WriteAttributeValue("", 6261, Html.Raw(localization.Delete), 6261, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6292, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 118 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(6339, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 122 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\FileManager\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(6396, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFileManagerLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileManagerObject[]> Html { get; private set; }
    }
}
#pragma warning restore 1591

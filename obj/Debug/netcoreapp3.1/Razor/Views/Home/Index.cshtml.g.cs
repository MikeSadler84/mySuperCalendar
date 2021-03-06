#pragma checksum "C:\Users\MikeS\Desktop\107\myCalendar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a74e19e8bac783a2727f07d908024b77ae88e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\MikeS\Desktop\107\myCalendar\Views\_ViewImports.cshtml"
using myCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MikeS\Desktop\107\myCalendar\Views\_ViewImports.cshtml"
using myCalendar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a74e19e8bac783a2727f07d908024b77ae88e7e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abcf888c2739078333327bef060c7866b9e1419", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MikeS\Desktop\107\myCalendar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- puts content into the styles section in the head -->\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n<link href=\"/css/todo.css\" rel=\"stylesheet\">\r\n<link href=\"/lib/fontawesome-free-5.14.0-web/css/all.css\" rel=\"stylesheet\">\r\n");
            }
            );
            WriteLiteral(@"
<div class=""parent-container"">

    <div class=""content"">
        <h4>My Tasks</h4>
        <i class=""fas fa-plus""></i>
    
    <div id=""tasks"" class=""section-tasks"">

    </div>
    <div><button type=""button"" class=""btn btn-primary"">Completed</button></div>
    </div>
    <div class=""details"">
        <h4>New Task</h4>
        <div class=""details-section"">
            <input id=""txtTitle"" type=""text"" placeholder=""Task title"">
        </div>
        <div class=""details-section"">
            <label class = ""important"" for=""chkImportant"">Important</label>
            <input id=""chkImportant"" type=""checkbox"">
        </div>
        <div class=""details-section"">
            <textarea id=""txtNotes"" placeholder=""Notes"" rows=""6""></textarea>
        </div>
        <div class=""details-section"">
            <button id=""btnSave"" class=""btn btn-info"">Save Task</button>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"js/calendar.js\"></script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

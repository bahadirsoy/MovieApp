#pragma checksum "C:\Users\oxika\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ccae7b7a01cbf24949bda58ccec88a5aba523d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
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
#line 1 "C:\Users\oxika\OneDrive\Masaüstü\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ccae7b7a01cbf24949bda58ccec88a5aba523d", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c92b9af2d7f3720007eaf698f18f72afe418292", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    \r\n");
#nullable restore
#line 5 "C:\Users\oxika\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 7 "C:\Users\oxika\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
                                                              Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\oxika\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
                                                                             Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 8 "C:\Users\oxika\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591

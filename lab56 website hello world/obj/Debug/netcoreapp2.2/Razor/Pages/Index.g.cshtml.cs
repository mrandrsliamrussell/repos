#pragma checksum "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17521a989aab43c3f34ba09865a671064ae3201d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(lab56_website_hello_world.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(lab56_website_hello_world.Pages.Pages_Index), null)]
namespace lab56_website_hello_world.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\_ViewImports.cshtml"
using lab56_website_hello_world;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17521a989aab43c3f34ba09865a671064ae3201d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7950d33855ed065738506e8515d6844cbd7edf6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 197, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n<ul>\r\n");
            EndContext();
#line 12 "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\Index.cshtml"
     for (int i = 0; i < 10; i++)
{

#line default
#line hidden
            BeginContext(306, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(319, 19, false);
#line 14 "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\Index.cshtml"
       Write(myClass.myMethod(i));

#line default
#line hidden
            EndContext();
            BeginContext(338, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 15 "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\Index.cshtml"

}

#line default
#line hidden
            BeginContext(350, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 18 "C:\Users\LRussell\source\repos\lab56 website hello world\Pages\Index.cshtml"
      

       public static class myClass{

           public static int myMethod(int i)
           {
               return i * 3;
           }

       }



   

#line default
#line hidden
            BeginContext(542, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

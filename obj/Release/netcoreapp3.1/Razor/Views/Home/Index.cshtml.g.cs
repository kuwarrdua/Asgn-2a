#pragma checksum "C:\Users\kuwar\source\repos\CarStockingg\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6031cec89b69813c97db8feb5b77b9c70e2a1a4a"
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
#line 1 "C:\Users\kuwar\source\repos\CarStockingg\Views\_ViewImports.cshtml"
using CarStockingg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kuwar\source\repos\CarStockingg\Views\_ViewImports.cshtml"
using CarStockingg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6031cec89b69813c97db8feb5b77b9c70e2a1a4a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c464307a29b51081bfef674c6687e344e2b84609", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kuwar\source\repos\CarStockingg\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div style=""text-align:center; color:#000000; font-style:italic"">
    <h1 style=""border: 2px outset black; text-shadow:5px; border-radius:50px;"">
        Welcome To<br />
        Kuwar's Car World
    </h1>
    <br />
    <h3>Sad because of low Credit Score! ;(</h3>
    <h5>Don't worry.. We approve all</h5>
</div>
<div>
    <p>
        Basically, I have created a car stocking system in which i have two tables one containing information about the supplier from where I buy the vehicles and the second table contains information about my car stocks that I have for the customers to sell.
    </p>
    <p>
        I have created a parent-child relationship between the two tables using the SupplierId field so that I could remeber the name and other details of person from where I bought the vehicle in case something misfortune happens
    </p>
    <p>Supplier table contains Supplier Name, Email, Contact.My Stock Table contains CarMake, Price, Location and SupplierId </p>
    <p>Linking the a");
            WriteLiteral("pplication with sql database is done perfectly. I used scaffolding to create the crud functionality for my controllers which made it easier. Use of entity framework was done as well.</p>\r\n</div>\r\n\r\n");
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

#pragma checksum "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Pages\dtable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d13f26576c8a5e07938f0485305e2c8816f438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECommerce.Api.Pages.Pages_dtable), @"mvc.1.0.razor-page", @"/Pages/dtable.cshtml")]
namespace ECommerce.Api.Pages
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
#line 1 "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Pages\_ViewImports.cshtml"
using ECommerce.Api;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d13f26576c8a5e07938f0485305e2c8816f438", @"/Pages/dtable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf01d4d2a9037785eae4e74278da8334dfa5d4d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_dtable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Pages\dtable.cshtml"
  
    ViewData["Title"] = "Data Table";
    Layout = "~/Pages/Shared/_LayoutSite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">

    <!-- Default box -->
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title"">Projects</h3>

            <div class=""card-tools"">
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                    <i class=""fas fa-minus""></i>
                </button>
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" title=""Remove"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
        </div>
        <div class=""card"">

            <script language=""JavaScript"">
    function yenisayfaac(url, width, height) {
                    window.open(url, '', 'toolbar=0,scrollbars=2,location=0,statusbar=1,menubar=0,resizable=0,width=' + width + ',height=' + height + ',left = 200,top = 100');
                }</script>
            <a href=""JavaScript:yenisayfaac('CategoryAdd1','940','760');"" type=""button"" class=""");
            WriteLiteral(@"btn btn-danger mb-1"" style=""width: 200px"">Add Category</a>
        </div>

        <div class=""card-body p-0"">
            <table id=""categoryDataTable"" class=""table table-striped projects"">
                <thead>
                    <tr>
                        
                        <th style=""width: 28%"">
                            CategoryName
                        </th>
                        <th style=""width: 28%"">
                            CategoryDescription
                        </th>

                    </tr>
                </thead>
                <tbody id=""output"">
");
            WriteLiteral(@"                    <tr>
                        <td> </td>
                        <td> </td>
                        <td> </td>

                    </tr>
                </tbody>
            </table>
        </div>
        <!-- /.card-body -->
    </div>
    <!-- /.card -->

</section>
<script type=""text/javascript"">
    fetch(""https://localhost:44306/api/category/GetAll"").then(
        res => {
            res.json().then(
                data => {
                    console.log(data);
                    if (data.length > 0) {



                        var temp = """";
                        data.forEach((itemData) => {
                            temp += ""<tr>"";
                            temp += ""<td>"" + itemData.CategoryName + ""</td>"";
                            temp += ""<td>"" + itemData.CategoryDescription + ""</td></tr>"";

                        });
                        document.getElementById('output').innerHTML = temp;
                    }
                }");
            WriteLiteral("\n            )\r\n        }\r\n    )\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.Api.Pages.dtableModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ECommerce.Api.Pages.dtableModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ECommerce.Api.Pages.dtableModel>)PageContext?.ViewData;
        public ECommerce.Api.Pages.dtableModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Pages\dt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e243deec9a656295f6cca4f04bc65a27bdd98c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECommerce.Api.Pages.Pages_dt), @"mvc.1.0.razor-page", @"/Pages/dt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e243deec9a656295f6cca4f04bc65a27bdd98c7", @"/Pages/dt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf01d4d2a9037785eae4e74278da8334dfa5d4d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_dt : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Pages\dt.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e243deec9a656295f6cca4f04bc65a27bdd98c73262", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e243deec9a656295f6cca4f04bc65a27bdd98c74321", async() => {
                WriteLiteral(@"
    <div style=""width: 500px"">
        <table class=""table table-bordered table-striped table-responsive"">
            <thead>
                <tr>
                    <td>CategoryName</td>
                    <td><input type=""text"" id=""txtName"" class=""form-control"" /></td>
                </tr>
                <tr>
                    <td>CategoryDescription</td>
                    <td><input type=""text"" id=""txtCountry"" class=""form-control"" /></td>
                </tr>
                <tr>
                    <td colspan=""2"" align=""center"">
                        <input type=""button"" id=""btnAdd"" value=""Add"" class=""btn btn-primary"" />
                    </td>
                </tr>
            </thead>
        </table>
        <br />
        <table id=""tblCategories"" cellpadding=""0"" cellspacing=""0"" border=""1"" style=""border-collapse:collapse"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Descripti");
                WriteLiteral(@"on</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody></tbody>
        </table>
    </div>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css"" />
    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css"" />
    <script type=""text/javascript"">
        $(function () {
            $.ajax({
                type: ""GET"",
                url: ""https://localhost:44306/api/Category/GetAll"",
                data: '{}',
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    $(""#tblCategories"").DataTable({
      ");
                WriteLiteral(@"                  bLengthChange: true,
                        lengthMenu: [[5, 10, -1], [5, 10, ""All""]],
                        bFilter: true,
                        bSort: true,
                        bPaginate: true,
                        data: response,
                        columns: [
                            { data: 'categoryId' },
                            { data: 'categoryName' },
                            { data: 'categoryDescription' },
                            {
                                data: null,
                            //    //""data"": ""CategoryId"", ""render"": function (data) { // <-- `ID` instead of `id`
                            //    //    return "" <a class='btn btn-danger' onclick=Delete("" + data + "")><i class='glyphicon glyphicon-trash'></i> Delete<a/>"";
                                  
                                render: function (data, type, row) {
                                    return ""<input type='button' id='btnDelete' onclick='Del");
                WriteLiteral(@"ete(this)' value='Delete' class='btn btn-danger' data-id='"" + data.categoryId + ""' />"";
                                }
                            }
                                    

                            //        /*<a class='btn btn-success' onclick=Edit("" + data + "") style = 'margin-left:12px' > <i class='glyphicon glyphicon-edit'></i> Edit Record < a />*/
                            
                            
                        ]
                    });
                },
                failure: function (r) {
                    alert(r.responseText);
                },
                error: function (r) {
                    alert(r.responseText);
                }
            });

            $('[id*=btnAdd]').on('click', function () {
                var category = {};
                category.CategoryName = $('[id*=txtName]').val();
                category.CategoryDescription = $('[id*=txtCountry]').val();
                $.ajax({
                    ty");
                WriteLiteral(@"pe: ""POST"",
                    url: ""https://localhost:44306/api/Category/Create"",
                    data: JSON.stringify(category),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (r) {
                        window.location.reload();
                    }
                });
            });
            function Delete(obj) {
                var ele = $(obj);
                var Id = ele.data(""data-id"");
                var url = ""https://localhost:44306/api/Category/Delete"" + Id;
                $.ajax({
                    url: url,
                    type: ""POST"",

                    success: function () {

                        ele.closest(""tr"").remove();
                    },

                    error: function () {
                        alert(""Fails"");
                    }

                });
            }
            //$('[id*=btnDelete]').on('click', function () {");
                WriteLiteral(@"
            //    var category = {};
            //    category.categoryId = $('[id*=txtId]').val();
            //    $.ajax({
            //        type: ""DELETE"",
            //        url: ""https://localhost:44306/api/Category/DeleteCategory"",
            //        data: JSON.stringify(category),
            //        contentType: ""application/json; charset=utf-8"",
            //        dataType: ""json"",
            //        success: function (r) {
            //            window.location.reload();
            //        }
            //    });
            //});
        //    $('#tblCategories tbody').on('click', '[id*=btnDelete]', function () {
        //        if (confirm('Are you sure delete this record?')) {
        //            var category = {};
        //            category.categoryId = $(this).attr('data-id');
        //            $.ajax({
        //                type: ""POST"",
        //                url: ""https://localhost:44306/api/Category/Delete"",
        //     ");
                WriteLiteral(@"           data: JSON.stringify(category),
        //                contentType: ""application/json; charset=utf-8"",
        //                dataType: ""json"",
        //                success: function (r) {
        //                    window.location.reload();
        //                }
        //            });
        //        }
            //});
        
        //});
        //        function Delete(id) {
        //    // First check if a <tbody> tag exists, add one if not
        //    if ($(""#tblCategories tbody"").length == 0) {
        //        $(""#tblCategories"").append(""<tbody></tbody>"");
        //    }

        //    // Append product to the table
        //    $(""#tblCategories tbody"").append(
        //        ""<tr>"" +
        //        ""<td>"" + $(""#CategoryId"").val() + ""</td>"" +
        //        ""<td>"" + $(""#CategoryName"").val() + ""</td>"" +
        //        ""<td>"" + $(""#CategoryDescription"").val() + ""</td>"" +

        //        ""<td>"" + 
        //        ""<b");
                WriteLiteral(@"utton type='button' onclick = 'productDelete(this);' class= 'btn btn-default' > "" + "" < span class= 'glyphicon glyphicon-remove' /> "" +
        //    ""</button>"" +
        //        ""</td>"" +
        //        ""</tr>"");
        //}
        //function productDelete(ctl) {
        //    $(ctl).parents(""tr"").remove();
        //}
    </script>
");
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
            WriteLiteral(@"
</html>
<!--
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<link href=""~/lib/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" />

<link href=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"" type=""text/css"" rel=""stylesheet"" />

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
<script>


    $(document).ready(function() {
        $(""#example"").DataTable({
            pageLength: 2,
            ajax: {
                url: 'handler=display',
                dataSrc : ''
            },

            ""columns"": [

                {
                    title: 'CategoryId',
                    data: 'categoryId'
                },
                {
                    title: 'CategoryName',
                    data: 'categoryName'
                },
                {
                    title: 'CategoryDescription',
   ");
            WriteLiteral("                 data: \'categoryDescription\'\r\n                }\r\n            ]\r\n\r\n        });\r\n    });\r\n</script>\r\n-->\r\n<!--");
            WriteLiteral(@"-->
<!--<!--<div class=""container"">
    <br />
    <div style=""width:90%; margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>CategoryId</th>
                    <th>CategoryName</th>
                    <th>CategoryDescription</th>
                </tr>
            </thead>
        </table>
    </div>
</div>
<script>


    $(document).ready(function() {
        $(""#example"").DataTable({
            pageLength: 2,
            ajax: {
                url: 'handler=display',
                dataSrc : ''
            },

            ""columns"": [

                {
                    title: 'CategoryId',
                    data: 'CategoryId'
                },
                {
                    title: 'CategoryName',
                    data: 'CategoryName'
                },
                {
                    title: 'Ca");
            WriteLiteral("tegoryDescription\',\r\n                    data: \'CategoryDescription\'\r\n                },\r\n            ]\r\n\r\n        });\r\n    });-->\r\n-->\r\n<!--");
            WriteLiteral("-->\r\n<!--</script>--> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.Api.Pages.dtModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ECommerce.Api.Pages.dtModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ECommerce.Api.Pages.dtModel>)PageContext?.ViewData;
        public ECommerce.Api.Pages.dtModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
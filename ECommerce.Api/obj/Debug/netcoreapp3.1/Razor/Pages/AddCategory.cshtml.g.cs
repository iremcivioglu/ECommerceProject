#pragma checksum "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Pages\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4394b82ac7c6e0b1e68b393614ec4b4f3c0c761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECommerce.Api.Pages.Pages_AddCategory), @"mvc.1.0.view", @"/Pages/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4394b82ac7c6e0b1e68b393614ec4b4f3c0c761", @"/Pages/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf01d4d2a9037785eae4e74278da8334dfa5d4d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--<section class=""content"">
    <div class=""card"">
        <h4 class=""card-title"">Kategori Ekleme</h4>
    </div>
    <div class=""card-body"">
        <div class=""card mb-4"">
            <div class=""card-body"">
                <form id=""CategoryAdd"">
                    <div class=""form-group"">
                        <div class=""input-group-append"">
                            <label>Kategori Adı</label>
                            <input type=""text"" name=""categoryName"" class=""form-control"" id=""exampleInputTitle1"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""input-group-append"">
                            <label>Kategori Tanımı</label>
                            <input type=""text"" name=""categoryDescription"" class=""form-control"" id=""exampleInputDescription1"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col");
            WriteLiteral(@"-4"">
                            <button type=""submit"" name=""AddCategory"" class=""btn btn-primary"" id=""AddCategory"">Kategori Ekle</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <script src=""~/plugins/jquery/jquery.min.js""></script>
    <script src=""~/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""~/plugins/jquery-validation/jquery.validate.min.js""></script>
</section>

<script>
    $(function () {
        $.validator.setDefaults({
            submitHandler: function () {
                alert(""Kategori başarıyla eklendi"");
            }
        });
        $('#CategoryAdd').validate({
            rules: {

                categoryName: {
                    required: true,
                    maxlength: 20
                },
                categoryDescription: {
                    required: true,
                    minlength: 20
                },
            ");
            WriteLiteral(@"},
            messages: {

                categoryName: {
                    required: ""Lütfen bir kategori adı girin"",
                    maxlength: ""Başlık 20 karakter uzunluğunda olmalı""
                },
                categoryDescription: {
                    required: ""Bir tanım girin"",
                    maxlength: ""Tanım 20 karakter uzunlugunda olmalı""
                },

            },
            errorElement: 'span',
            errorPlacement: function (error, element) {
                error.addClass('invalid-feedback');
                element.closest('.form-group').append(error);
            },
            highlight: function (element, errorClass, validClass) {
                $(element).addClass('is-invalid');
            },
            unhighlight: function (element, errorClass, validClass) {
                $(element).removeClass('is-invalid');
            }
        });
    });
</script>

<script type=""text/javascript"">
    $(""#AddCategory"").click(functio");
            WriteLiteral(@"n () {
        var model = {
            categoryName: $(""[name='categoryName']"").val(),
            categoryDescription: $(""[name='categoryDescription']"").val(),
        };
        console.log(JSON.stringify(model));
        var category = JSON.stringify(model);
        $.ajax({
            type: 'POST',
            url: 'https://localhost:44306/api/category/create',
            contentType: 'application/json;charset=utf-8',
            dataType: 'json',
            data: category,
            success: function (response) {
                $(""AddCategory"").removeAttr(""disabled"");
                alert(""Kayıt işlemeniz başarılı"")
            },
            error: function (error) {
                $(""AddCategory"").removeAttr(""disabled"");
            }
        });
    });

</script>-->
<!--<!DOCTYPE html>
    <html>
    <head>
    <h1> Kategori Ekle </h1>
    </head>
    <body>
        <form>
            <table>
                <tr>
                    <td>
                   ");
            WriteLiteral(@"     Kategori Adı :
                    </td>

                    <td>
                        <input type=""text"" name=""CategoryName"">
                    </td>
                </tr>
                <tr>
                    <td>
                        Kategori Tanımı :
                    </td>

                    <td>
                        <input type=""text"" name=""CategoryDescription"">
                    </td>
                </tr>
            </table>
            <button type=""submit"" class=""btn btn-primary btn-block"" id=""addcategory"">Kaydol</button>
        </form>
        <script type=""text/javascript"">
            $(""#addcategory"").click(function () {
                var model = {
                    CategoryName: $(""[name='CategoryName']"").val(),
                    CategoryDescription: $(""[name='CategoryDescription']"").val(),
                };
                console.log(JSON.stringify(model));
                var category = JSON.stringify(model);
                $.aja");
            WriteLiteral(@"x({
                    type: 'POST',
                    url: 'https://localhost:44306/api/category/create',
                    contentType: 'application/json;charset=utf-8',
                    dataType: 'json',
                    data: category,
                    success: function (response) {

                    },
                    error: function (error) {

                    }
                });
            });
        </script>
    </body>
    </html>-->
");
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
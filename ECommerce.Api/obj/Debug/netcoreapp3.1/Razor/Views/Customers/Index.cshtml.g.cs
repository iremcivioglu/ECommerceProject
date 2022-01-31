#pragma checksum "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03436c0526fd82db2ffff1a39766c2eee44cd35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03436c0526fd82db2ffff1a39766c2eee44cd35", @"/Views/Customers/Index.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.Entities.Model.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\IREM\source\repos\ECommerceSolution\ECommerce.Api\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<link href=""https://cdn.datatables.net/1.11.3/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
<script type=""text/javascript"" href=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js""></script>
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03436c0526fd82db2ffff1a39766c2eee44cd354001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<input type=""text"" id=""txtCustomerId"" placeholder=""Customer Id"" style=""display:none;"" />
<input type=""text"" id=""txtCustomerName"" placeholder=""Customer Name"" style=""margin-right:5px;"" />
<input type=""text"" id=""txtCustomerSurname"" placeholder=""Customer Surname"" style=""margin-right:5px;"" />
<input type=""text"" id=""txtPhoneNumber"" placeholder=""Phone"" style=""margin-right:5px;"" />
<input type=""text"" id=""txtCustomerAdress"" placeholder=""Customer Address"" style=""margin-right:5px;"" />
<input type=""email"" id=""email"" placeholder=""Email"" style=""margin-right:5px"" />

<button id=""btnSave"" class=""btn btn-success"" style=""margin-right:5px;"">Save</button>
<button id=""btnAddNew"" class=""btn btn-primary"" style=""margin-right:5px;"">Add New</button>

<br />
<br />

<table id=""customerTable"" class=""table table-striped table-bordered"" style=""width:100%"">
    <thead>
        <tr>
            <th>
         ");
            WriteLiteral(@"       ID
            </th>
            <th>
                Ad
            </th>
            <th>
                Soyad
            </th>
            <th>
                Telefon
            </th>
            <th>
                Adres
            </th>
            <th>
                Email
            </th>
            <th>Edit</th>
            <th>Delete</th>
        </tr>
    </thead>
</table>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#customerTable"").DataTable({
            ""ajax"": {
                ""url"": ""/Customers/GetData"",
                //""type"": ""GET"",
                //""datatype"": ""json"",
                ""dataSrc"": """"
            },
            ""columns"": [
                { ""data"": ""customerId"" },
                { ""data"": ""customerName"" },
                { ""data"": ""customerSurname"" },
                { ""data"": ""phoneNumber"" },
                { ""data"": ""customerAdress"" },
                { ""data"": ""email"" },
         ");
            WriteLiteral(@"       {
                    ""data"": ""CustomerId"", ""render"": function (data, type, row, meta) {
                        return ""<button class='btn btn-primary' style='margin-right:5px; onclick=Edit("" + JSON.stringify(row) + "")'>Edit</button>"" +
                            ""<button class='btn btn-danger' style='margin-right:5px; onclick=Delete("" + JSON.stringify(row) + "")'>Delete</button>""
                    },
                }
            ]
        });

        $(""#btnSave"").click(function () {
            var customer = {
                CustomerId: $.trim($(""#txtCustomerId"").val()) == """" ? 0 : $(""#txtCustomerId"").val(),
                CustomerName: $(""#txtCustomerName"").val(),
                CustomerSurname: $(""#txtCustomerSurname"").val(),
                PhoneNumber: $(""#txtPhoneNumber"").val(),
                CustomerAdress: $(""#txtCustomerAdress"").val(),
                Email: $(""#email"").val(),
            }
            $.post(""api/Customer"", { customer: customer })
              ");
            WriteLiteral(@"  .done(function (data) {
                    Reset();
                    ReloadGrid();
                    alert(""saved"");
                });
        });
        $(""#btnAddNew"").click(function () {
            Reset();
        })
    });
    function Edit(oCustomer) {
        $(""#txtCustomerId"").val(oCustomer.CustomerId);
        $(""#txtCustomerName"").val(oCustomer.CustomerName);
        $(""#txtCustomerSurname"").val(oCustomer.CustomerSurname);
        $(""#txtPhoneNumber"").val(oCustomer.PhoneNumber);
        $(""#txtCustomerAdress"").val(oCustomer.CustomerAdress);
        $(""email"").val(oCustomer.Email);
    }
    function Delete(oCustomer) {
        $.Delete(""api/Customer?id="" + oCustomer.CustomerId, function () {
            alert(""Deleted"");
            ReloadGrid();
        });
    }
    function Reset() {
        $(""#txtCustomerId"").val(0);
        $(""#txtCustomerName"").val("""");
        $(""#txtCustomerSurname"").val("""");
        $(""#txtPhoneNumber"").val("""");
        $(""#txtCus");
            WriteLiteral("tomerAdress\").val(\"\");\r\n        $(\"#email\").val(\"\");\r\n    }\r\n    function ReloadGrid() {\r\n        $(\"#customerTable\").DataTable().clear();\r\n        $(\"#customerTable\").DataTable().ajax.reload();\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.Entities.Model.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
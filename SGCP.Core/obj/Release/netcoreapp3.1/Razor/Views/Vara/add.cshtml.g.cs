#pragma checksum "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Vara\add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0205beb0a330d736689047cc26254d255ddb70a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vara_add), @"mvc.1.0.view", @"/Views/Vara/add.cshtml")]
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
#line 1 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\_ViewImports.cshtml"
using SGCP.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\_ViewImports.cshtml"
using SGCP.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0205beb0a330d736689047cc26254d255ddb70a", @"/Views/Vara/add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b2d3036cb0a39e16e6b0a85aff339a52fa99d95", @"/Views/_ViewImports.cshtml")]
    public class Views_Vara_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Vara\add.cshtml"
  
    ViewBag.Title = "add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container mt-5 pt-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-9 col-md-7 col-lg-5 mx-5\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">Cadastro de Vara</h5>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0205beb0a330d736689047cc26254d255ddb70a3674", async() => {
                WriteLiteral(@"
                    <div class=""form-group mx-auto"">
                        <label for=""name"">Nome da Vara</label>
                        <input class=""form-control"" type=""text"" name=""nome"" id=""nome"" />
                    </div>
                    <div class=""form-group mx-auto"">
                        <label for=""name"">Juiz:</label>
                        <input class=""form-control"" type=""text"" name=""juiz"" id=""juiz"" />
                    </div>
                    <div class=""form-group mx-auto"">
                        <label for=""name"">Cidade:</label>
                        <input class=""form-control"" type=""text"" name=""cidade"" id=""cidade"" />
                    </div>
                    <div class=""form-group mx-auto"">
                        <label for=""name"">Estado:</label>
                        <input class=""form-control"" type=""text"" name=""estado"" id=""estado"" />
                    </div>

                    <div class=""form-group mx-auto"">
                        <button");
                WriteLiteral(" type=\"button\" class=\"btn btn-success\" onclick=\"add()\">Criar</button>\r\n                        <button type=\"button\" class=\"btn btn-danger\" onclick=\"window.location.href=\'/Vara/index\'\">voltar</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    function add() {

        var _nome = document.getElementById(""nome"").value
        var _juiz = document.getElementById(""juiz"").value
        var _cidade = document.getElementById(""cidade"").value
        var _estade = document.getElementById(""estado"").value

        var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText
                if (re === ""ok"") {
                    window.location.href = ""/Vara/index?execut=ok""
                }
                else {
                    document.getElementById(""mens"").innerHTML = re;
                    toastr.error(re,""SGCP"")
                    //window.location.href = ""/Falha/Index?mensage="" + re;
                }
            }
        }
        xhp.open(""Post"", `/Vara/add?nome=${_nome}&juiz=${_juiz}&cidade=${_cidade}&");
            WriteLiteral("estado=${_estade}`);\r\n        xhp.send();\r\n    }\r\n\r\n\r\n</script>");
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

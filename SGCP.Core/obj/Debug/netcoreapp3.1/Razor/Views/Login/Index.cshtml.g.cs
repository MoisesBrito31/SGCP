#pragma checksum "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8ca5b8155d5a847a23117c3b45a05ac3189b06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8ca5b8155d5a847a23117c3b45a05ac3189b06", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b2d3036cb0a39e16e6b0a85aff339a52fa99d95", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Files/Imagens/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-9 col-md-7 col-lg-5 mx-auto\">\r\n            <div class=\"card card-signin my-5\">\r\n                <div class=\"mx-auto my-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd8ca5b8155d5a847a23117c3b45a05ac3189b065251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title text-center\">Login de Usuário</h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8ca5b8155d5a847a23117c3b45a05ac3189b066620", async() => {
                WriteLiteral(@"
                        <div class=""form-label-group"">
                            <label for=""Nome"">Usuário</label>
                            <input type=""text"" name=""Nome"" id=""Nome"" class=""form-control"" style=""max-width: 100%"" placeholder=""Usuário""
                                   onclick=""document.getElementById('falha').setAttribute('class', 'invisible');"">
                        </div>

                        <div class=""form-label-group mb-4"">
                            <label for=""Senha"">Senha</label>
                            <input type=""password"" name=""Senha"" id=""Senha"" class=""form-control"" style=""max-width: 100%"" placeholder=""Senha""
                                   onclick=""document.getElementById('falha').setAttribute('class', 'invisible');"">
                        </div>

                        <button type=""button"" id=""butLogar"" class=""btn btn-lg btn-primary btn-block text-uppercase borde"" onclick=""enviaLogin()"">Sign in</button>
                        <div class=""for");
                WriteLiteral(@"m-check mx-auto text-center my-1"">
                            <a href=""#"">Esqueci minha Senha</a>
                        </div>
                        <div id=""falha"" class=""alert-danger mb-4 h-100 p-2 text-center invisible"">
                            Usuário ou senha incoretos
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Login\Index.cshtml"
 if (ViewBag.banco == "conectado")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script type=""text/javascript"">
        setTimeout(function () {
             toastr.options = {
                 ""closeButton"": true,                 
                 ""positionClass"": ""toast-bottom-center"",                 
             }
            toastr.success(""Banco de dados Online"", ""SGCP"")

        }, 100)
    </script>
");
#nullable restore
#line 61 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Login\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script type=""text/javascript"">
        setTimeout(function () {
            toastr.options = {
                 ""closeButton"": true,                 
                 ""positionClass"": ""toast-bottom-center"",                 
             }
            toastr.error(""Falha no banco de Dados"", ""SGCP"")
        }, 100)
    </script>
");
#nullable restore
#line 73 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Login\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function enviaLogin() {
        var usuario = document.getElementById(""Nome"").value
        var senha = document.getElementById(""Senha"").value
        var xhttp = new XMLHttpRequest();
         xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            var retorno = this.responseText;
            switch (retorno) {
                case ""ok"":
                    window.location.href = ""/Home/Index"";
                    break;
                case ""loginErro"":
                    document.getElementById(""falha"").setAttribute(""class"", ""alert-danger mb-4 h-100 p-2 text-center visible"");
                    document.getElementById(""butLogar"").innerHTML = ""Sign in"";
                    break;
                default:
                    document.body.innerHTML = retorno;
                    break;
            }

        }
    };
    xhttp.open(""POST"", `/Login/Loga?usuario=${usuario}&senha=${senha}`, true);
    xhttp.send();");
            WriteLiteral("\r\n}\r\n</script>\r\n");
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

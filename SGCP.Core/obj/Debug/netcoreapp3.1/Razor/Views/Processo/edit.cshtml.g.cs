#pragma checksum "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e074a5e1282eba5cf91fefa8b754378b7b0e87c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Processo_edit), @"mvc.1.0.view", @"/Views/Processo/edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e074a5e1282eba5cf91fefa8b754378b7b0e87c", @"/Views/Processo/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b2d3036cb0a39e16e6b0a85aff339a52fa99d95", @"/Views/_ViewImports.cshtml")]
    public class Views_Processo_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGCP.Web.MVC.Models.processo>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
  
    ViewBag.Title = "edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    input {\r\n        max-width: 100%;\r\n    }\r\n\r\n    textarea {\r\n        max-width: 100%;\r\n    }\r\n</style>\r\n\r\n<div class=\"container-fluid mt-5 pt-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col \">\r\n            <h2 class=\"h2\">Processo Nº.: ");
#nullable restore
#line 21 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                    Write(Model.numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

        </div>
        <div class=""col text-right"">
            <button class=""btn btn-primary"" type=""button"" onclick=""document.location.href='/processo/relatorio'"">Gerar Relatório</button>
        </div>
    </div>
</div>

<hr />

<div class=""container "">
    <div class=""row"">
        <div class=""col m-1"">
            <div class=""m-1 form-group my-2"">
                <label for=""name"">Numero do Processo</label>
                <input type=""text"" class=""form-control"" id=""numero""");
            BeginWriteAttribute("value", " value=\"", 849, "\"", 870, 1);
#nullable restore
#line 37 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 857, Model.numero, 857, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>

            <div class=""m-1 form-group my-2"">
                <label for=""name"">Vara</label>
                <div class=""row"">
                    <div class=""col"">
                        <select class=""form-control"" id=""vara"">
");
#nullable restore
#line 45 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                             foreach (SGCP.Web.MVC.Models.vara vara in ViewBag.varas)
                            {

                                if (vara.id == Model.vara)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e074a5e1282eba5cf91fefa8b754378b7b0e87c5476", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 52 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                   Write(vara.get_nome());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                       WriteLiteral(vara.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e074a5e1282eba5cf91fefa8b754378b7b0e87c8084", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 58 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                   Write(vara.get_nome());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                       WriteLiteral(vara.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col "">
                        <button class=""btn btn-primary"" type=""button"" onclick=""window.location.href='/vara/index'"">geranciar</button>
                    </div>

                </div>
            </div>

            <div class=""m-1 form-group my-2"">
                <label for=""name"">Requerido</label>
                <input type=""text"" class=""form-control"" id=""rqrd""");
            BeginWriteAttribute("value", " value=\"", 2390, "\"", 2414, 1);
#nullable restore
#line 73 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 2398, Model.requerido, 2398, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"m-1 form-group my-2\">\r\n                <label for=\"name\">Inicio do Trabalho</label>\r\n                <input type=\"date\" class=\"form-control\" id=\"ini_tra\"");
            BeginWriteAttribute("value", " value=\"", 2619, "\"", 2649, 1);
#nullable restore
#line 78 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 2627, Model.inicio_trabalho, 2627, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"m-1 form-group my-2\">\r\n                <label for=\"name\">Honorário Propósto</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"HPro\"");
            BeginWriteAttribute("value", " value=\"", 2851, "\"", 2879, 1);
#nullable restore
#line 83 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 2859, Model.honorario_pro, 2859, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"m-1 form-group my-2\">\r\n                <label for=\"obs\">Observações</label>\r\n                <textarea class=\"form-control\" rows=\"4\" id=\"obs\">");
#nullable restore
#line 88 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                                            Write(Model.obs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col m-1\">\r\n            <div class=\"m-1 form-group my-2\">\r\n");
#nullable restore
#line 94 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                 if (Model.intimacao.Month.ToString().Length == 1) { ViewBag.mes = "0" + Model.intimacao.Month; }
                else { ViewBag.mes = Model.intimacao.Month; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                 if (Model.intimacao.Day.ToString().Length == 1) { ViewBag.dia = "0" + Model.intimacao.Day; }
                else { ViewBag.dia = Model.intimacao.Day; }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label for=\"name\">Data da Intimação</label>\r\n                <input class=\"form-control\" type=\"date\" id=\"intimacao\"");
            BeginWriteAttribute("value", " value=\"", 3693, "\"", 3775, 1);
#nullable restore
#line 99 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 3701, string.Format("{0}-{1}-{2}",Model.intimacao.Year,ViewBag.mes,ViewBag.dia), 3701, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"m-1 form-group my-2\">\r\n                <label for=\"name\">Requerente</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"rqrt\"");
            BeginWriteAttribute("value", " value=\"", 3967, "\"", 3992, 1);
#nullable restore
#line 103 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 3975, Model.requerente, 3975, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"m-1 form-group my-2\">\r\n                <label for=\"name\">Prazo:</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"entrega\"");
            BeginWriteAttribute("value", " value=\"", 4185, "\"", 4207, 1);
#nullable restore
#line 108 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 4193, Model.entrega, 4193, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"m-1 form-group my-2\">\r\n                <label for=\"name\">Honorário aprovado </label>\r\n                <input type=\"text\" class=\"form-control\" id=\"Hapro\"");
            BeginWriteAttribute("value", " value=\"", 4411, "\"", 4435, 1);
#nullable restore
#line 113 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
WriteAttributeValue("", 4419, Model.honorario, 4419, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>

        </div>

    </div>
    <div class=""row"">
        <div class=""col  "">
            <div class=""form-group my-4 text-right"">
                <button type=""button"" class=""btn btn-success "" onclick=""add()"">Salvar</button>
            </div>
        </div>
        <div class=""col  "">
            <div class=""form-group my-4 text-left"">
                <button type=""button"" class=""btn btn-danger "" onclick=""window.location.href='/processo/index'"">Voltar</button>
            </div>
        </div>
    </div>

</div>





<script type=""text/javascript"">
    function add() {

        var vara = document.getElementById(""vara"").value
        var numero = document.getElementById(""numero"").value
        var intimacao = document.getElementById(""intimacao"").value
        var rqrd = document.getElementById(""rqrd"").value
        var rqrt = document.getElementById(""rqrt"").value
        var obs = document.getElementById(""obs"").value
        var ini_tra = document.get");
            WriteLiteral(@"ElementById(""ini_tra"").value
        var HPro = document.getElementById(""HPro"").value
        var Hapro = document.getElementById(""Hapro"").value
        var entrega = document.getElementById(""entrega"").value

        var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText
                if (re === ""ok"") {
                    window.location.href = ""/processo/index?execut=ok""
                }
                else {
                    //document.getElementById(""mens"").innerHTML = re;
                    toastr.error(re,""SGCP"")
                    //window.location.href = ""/Falha/Index?mensage="" + re;
                }
            }
        }
        xhp.open(""Post"", `/processo/edit?_id=${");
#nullable restore
#line 166 "C:\Users\Moises Brito\Documents\GitHub\SGCP\SGCP.Core\Views\Processo\edit.cshtml"
                                          Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("}&_vara=${vara}&_numero=${numero}\r\n&_intimacao=${intimacao}&_reqd=${rqrd}&_reqt=${rqrt}&_obs=${obs}&_ini_tra=${ini_tra}&_Hpro=${HPro}&_Hapro=${Hapro}&_entrega=${entrega}`);\r\n        xhp.send();\r\n    }\r\n\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGCP.Web.MVC.Models.processo> Html { get; private set; }
    }
}
#pragma warning restore 1591

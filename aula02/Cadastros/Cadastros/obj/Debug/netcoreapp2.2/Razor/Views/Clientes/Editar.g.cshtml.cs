#pragma checksum "D:\maurilio\aula02\Cadastros\Cadastros\Views\Clientes\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c217e22905ca4f333efe525585c016075ff418a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Editar), @"mvc.1.0.view", @"/Views/Clientes/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Editar.cshtml", typeof(AspNetCore.Views_Clientes_Editar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c217e22905ca4f333efe525585c016075ff418a", @"/Views/Clientes/Editar.cshtml")]
    public class Views_Clientes_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastros.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\maurilio\aula02\Cadastros\Cadastros\Views\Clientes\Editar.cshtml"
  
    ViewData["Title"] = "Editar";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 138, true);
            WriteLiteral("\r\n<h1>Editar Cliente</h1>\r\n<form action=\"/\" method=\"post\">\r\n    <div>\r\n        <label>Nome</label>\r\n        <input type=\"text\" name=\"nome\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 263, "\"", 282, 1);
#line 11 "D:\maurilio\aula02\Cadastros\Cadastros\Views\Clientes\Editar.cshtml"
WriteAttributeValue("", 271, Model.Nome, 271, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(283, 99, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <label>Idade</label>\r\n        <input type=\"number\" name=\"idade\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 382, "\"", 402, 1);
#line 15 "D:\maurilio\aula02\Cadastros\Cadastros\Views\Clientes\Editar.cshtml"
WriteAttributeValue("", 390, Model.Idade, 390, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(403, 143, true);
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <div>\r\n        <button type=\"submit\">Salvar</button>\r\n        <a href=\"/Cliente/Index\">Voltar</a>\r\n    </div>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadastros.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e57388823f37c47889c38faa6df971f3a4266f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Index), @"mvc.1.0.view", @"/Views/Categorias/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categorias/Index.cshtml", typeof(AspNetCore.Views_Categorias_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e57388823f37c47889c38faa6df971f3a4266f2", @"/Views/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 272, true);
            WriteLiteral(@"
<h1>Index</h1>

<h1 class=""mt-5"">Categorias</h1>
<p class=""lead"">Listagens de cCategorias</p>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Acao</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml"
         foreach (var categoria in Model)
        {

#line default
#line hidden
            BeginContext(369, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(420, 14, false);
#line 22 "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml"
                           Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(434, 102, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">\r\n                    <a class=\"btn btn-outline-success btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 536, "\"", 590, 3);
#line 24 "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 543, Url.Action("Edit", "Categorias"), 543, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 576, "/", 576, 1, true);
#line 24 "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 577, categoria.Id, 577, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(591, 139, true);
            WriteLiteral(">Editar</a>\r\n                    <button class=\"btn btn-outline-danger btn-sm\">Excluir</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Maurilio Filho\Source\Repos\mauriliofilho\MCSA-WEB-Developer-Acelerado-20480-20486\aula04\LineOnCode.Store\LineOnCode.Store.UI\Views\Categorias\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(741, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

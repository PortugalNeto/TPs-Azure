#pragma checksum "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c1d9c8824b170e91fd4db82678f0b92a7b0479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Index), @"mvc.1.0.view", @"/Views/Tarefas/Index.cshtml")]
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
#line 1 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\_ViewImports.cshtml"
using MVC.AT_Azure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\_ViewImports.cshtml"
using MVC.AT_Azure.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c1d9c8824b170e91fd4db82678f0b92a7b0479", @"/Views/Tarefas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c8980509c70619aa84b20fdef995a136e4a993", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
  
    List<Tarefa> tarefas = ViewBag.ListTarefas;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nome Tarefa</th>
            <th scope=""col"">Descrição</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Para quem:</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
         foreach (var tarefa in tarefas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 19 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
                           Write(tarefa.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 20 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
               Write(tarefa.NomeTarefa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
               Write(tarefa.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
               Write(tarefa.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
               Write(tarefa.Quem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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

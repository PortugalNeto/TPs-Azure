#pragma checksum "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86cdf27019d70265bbc2f9a2c386449b280649b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Detalhes), @"mvc.1.0.view", @"/Views/Tarefas/Detalhes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86cdf27019d70265bbc2f9a2c386449b280649b4", @"/Views/Tarefas/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c8980509c70619aa84b20fdef995a136e4a993", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
  
    Tarefa result = ViewBag.Tarefa;
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>Tarefa</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => result.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayFor(model => result.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => result.ToDo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayFor(model => result.ToDo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => result.NomeTarefa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayFor(model => result.NomeTarefa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => result.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayFor(model => result.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => result.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayFor(model => result.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => result.Quem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "D:\OneDrive - RADIX ENGENHARIA E DESENVOLVIMENTO DE SOFTWARE S A (ISV)\Documentos\GitHub\TPs-Azure\AT\MVC.AT-Azure\Views\Tarefas\Detalhes.cshtml"
       Write(Html.DisplayFor(model => result.Quem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a href=\"/tarefas/Index\">Voltar ?? Lista</a>\r\n</div>\r\n");
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

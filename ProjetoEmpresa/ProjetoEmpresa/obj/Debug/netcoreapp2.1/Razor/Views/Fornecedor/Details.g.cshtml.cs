#pragma checksum "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72d9b712f28be97c1b85dbd7d770c2fa18d068b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedor_Details), @"mvc.1.0.view", @"/Views/Fornecedor/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedor/Details.cshtml", typeof(AspNetCore.Views_Fornecedor_Details))]
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
#line 1 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\_ViewImports.cshtml"
using ProjetoEmpresa;

#line default
#line hidden
#line 2 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\_ViewImports.cshtml"
using ProjetoEmpresa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72d9b712f28be97c1b85dbd7d770c2fa18d068b", @"/Views/Fornecedor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e5ad4cd1caa81ea6cbe786fa8f927029ed62f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoEmpresa.Models.Fornecedor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 125, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Fornecedor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(212, 43, false);
#line 14 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empresa));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 52, false);
#line 17 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empresa.nomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(351, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(395, 40, false);
#line 20 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(479, 36, false);
#line 23 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(559, 42, false);
#line 26 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pessoa));

#line default
#line hidden
            EndContext();
            BeginContext(601, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(645, 38, false);
#line 29 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.pessoa));

#line default
#line hidden
            EndContext();
            BeginContext(683, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(727, 44, false);
#line 32 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cpf_cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(771, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(815, 40, false);
#line 35 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.cpf_cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(899, 38, false);
#line 38 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.rg));

#line default
#line hidden
            EndContext();
            BeginContext(937, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(981, 34, false);
#line 41 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.rg));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1059, 44, false);
#line 44 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.datahora));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1147, 40, false);
#line 47 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.datahora));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1231, 46, false);
#line 50 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1321, 42, false);
#line 53 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1407, 44, false);
#line 56 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1495, 40, false);
#line 59 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
       Write(Html.DisplayFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1582, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e68b3bea0e584b07afbf747eca64c8d6", async() => {
                BeginContext(1638, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\cinth\Desktop\ProjetoEmpresa\ProjetoEmpresa\Views\Fornecedor\Details.cshtml"
                           WriteLiteral(Model.idfornecedor);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1648, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1656, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175a4f00b3aa481cbeecf78072837b6e", async() => {
                BeginContext(1678, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1688, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoEmpresa.Models.Fornecedor> Html { get; private set; }
    }
}
#pragma warning restore 1591

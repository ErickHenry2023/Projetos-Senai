#pragma checksum "C:\Users\23516467894\Documents\Exercicios\RoleTopMvc\Views\Cadastro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ac5685dfda839eef82e2824769bf7e6bf152ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index), @"mvc.1.0.view", @"/Views/Cadastro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Index.cshtml", typeof(AspNetCore.Views_Cadastro_Index))]
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
#line 1 "C:\Users\23516467894\Documents\Exercicios\RoleTopMvc\Views\_ViewImports.cshtml"
using RoleTopMvc;

#line default
#line hidden
#line 2 "C:\Users\23516467894\Documents\Exercicios\RoleTopMvc\Views\_ViewImports.cshtml"
using RoleTopMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ac5685dfda839eef82e2824769bf7e6bf152ed", @"/Views/Cadastro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a1b6a35e855e3bf7e86af114d09287816f6194", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 227, true);
            WriteLiteral("<main>\r\n\r\n    <h1>CRIAR UMA CONTA <br>\r\n        COM</h1>\r\n\r\n    <div id=\"img-social\">\r\n        <img src=\"img/1.png\">\r\n        <img src=\"img/4.png\">\r\n        <img src=\"img/3.png\">\r\n    </div>\r\n\r\n    <div id=\"tabela\">\r\n\r\n        ");
            EndContext();
            BeginContext(227, 1093, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52ac5685dfda839eef82e2824769bf7e6bf152ed3604", async() => {
                BeginContext(233, 1080, true);
                WriteLiteral(@"
            <p><label for=""cNome"">
                    <!--Nome:--></label>
                <input type=""text"" name=""tName"" id=cNome size=""20"" maxlength=""30"" placeholder=""Nome Completo"" /></p>
            <p><label for=""cMail"">
                    <!--E-mail:--></label>
                <input type=""email"" name=""tMail>"" id=cMail size=""20"" maxlength=""40"" placeholder=""E-mail"" /></p>
            <p><label for=""cSenha"">
                    <!--Senha:<--></label>
                <input type=""password"" name=""tSenha"" id=cSenha size=""8"" maxlength=""8"" placeholder=""Senha"" /></p>
            <p><label for=""cCPF/CNPJ"">
                    <!--CPF/CNPJ:--></label>
                <input type=""text"" name=""tCPF/CNPJ"" id=cCPF/CNPJ size=20 maxlength=""11"" placeholder=""CPF/CNPJ"" />
            </p>
            <p><label for=""cTel"">
                    <!--Telefone:--></label>
                <input type=""tel"" name=""tTel"" id=cTel size=""12"" maxlength=""12"" placeholder=""Telefone"" /></p>
            <input type=""sub");
                WriteLiteral("mit\" name=\"Inscreva-se\" value=\"Inscreva-se\">\r\n\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(1320, 21, true);
            WriteLiteral("\r\n    </div>\r\n</main>");
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

#pragma checksum "C:\Users\josem\Documents\Misión TIC\Proyecto ciclo 3\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\Estaciones\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7d3fbc5aa9f383b4f412b822bfa6729e9e8abd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Estaciones.Pages_Estaciones_Create), @"mvc.1.0.razor-page", @"/Pages/Estaciones/Create.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Estaciones
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
#line 1 "C:\Users\josem\Documents\Misión TIC\Proyecto ciclo 3\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7d3fbc5aa9f383b4f412b822bfa6729e9e8abd", @"/Pages/Estaciones/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estaciones_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"text-center\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7d3fbc5aa9f383b4f412b822bfa6729e9e8abd3592", async() => {
                WriteLiteral(@"
    <div class=""container"">
      <div class=""row justify-content-md-center"">
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""idEstacion"" class=""form-label"">Digite el ID de la Estacion:</label>
          <input type=""number"" class=""form-control"" id=""idEstacion"" name=""idEstacion"" placeholder=""Id de Estacion"">
        </div>
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""nombreEstacion"" class=""form-label"">Digite el Nombre de la Estacion:</label>
          <input type=""text"" class=""form-control"" id=""nombreEstacion"" name=""nombreEstacion"" placeholder=""Nombre de Estacion"">
        </div>
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""coorx"" class=""form-label"">Digite la Coordenada X:</label>
          <input type=""number"" class=""form-control"" id=""coorx"" name=""coorx"" placeholder=""Coordenada X"">
        </div>
        <div class=""col-6 col-md-4 col-lg-4"">
          <label for=""coorY"" class=""form-label"">Digite la Coordenada Y</label");
                WriteLiteral(@">
          <input type=""number"" class=""form-control"" id=""coorY"" name=""coorY"" placeholder=""Coordenada Y"">
        </div>
        <div class=""col-6 col-md-4 col-lg-4"">
          <label for=""tipo"" class=""form-label"">Digite el Tipo de Estacion:</label>
          <input type=""number"" class=""form-control"" id=""tipo"" name=""tipo""
            placeholder=""Tipo de Estacion"">
        </div>
      </div>
      <br>

    </div>


    <hr>
    <button onclick=""myFunction()"" type=""submit"" class=""btn btn-success"" style=""font-family: cursive;color:black"">&nbspEnviar&nbsp </button>

    <script>
      function myFunction() {
        alert(""HOLA"");
        
      }
    </script>

  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Estaciones_Create> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Estaciones_Create> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Estaciones_Create>)PageContext?.ViewData;
        public Pages_Estaciones_Create Model => ViewData.Model;
    }
}
#pragma warning restore 1591

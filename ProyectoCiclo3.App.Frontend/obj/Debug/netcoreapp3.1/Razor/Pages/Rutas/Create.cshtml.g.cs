<<<<<<< HEAD
#pragma checksum "D:\AVP\MISIONTIC\CICLO 3\DESARROLLO DE SOFTWARE\PROYECTO GRUPAL\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\Rutas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3210c20c35b3f6191ca55c61cb5fa518b66d76eb"
=======
#pragma checksum "C:\Users\Sebas\Desktop\ProyectoDev5.App\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\Rutas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95450302efcfce4bc7caa149bae6bce9a2d9be74"
>>>>>>> 2f24115f66df35fe7c7fed94e4ad3bd10c957a4e
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Rutas.Pages_Rutas_Create), @"mvc.1.0.razor-page", @"/Pages/Rutas/Create.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Rutas
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
#line 1 "C:\Users\Sebas\Desktop\ProyectoDev5.App\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3210c20c35b3f6191ca55c61cb5fa518b66d76eb", @"/Pages/Rutas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rutas_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"text-center\">\r\n  ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3210c20c35b3f6191ca55c61cb5fa518b66d76eb3529", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95450302efcfce4bc7caa149bae6bce9a2d9be743481", async() => {
>>>>>>> 2f24115f66df35fe7c7fed94e4ad3bd10c957a4e
                WriteLiteral(@"
    <div class=""container"">
      <div class=""row justify-content-md-center"">
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""id"" class=""form-label"">Digite el ID:</label>
          <input type=""number"" class=""form-control"" id=""id"" name=""id"" placeholder=""Id"" required>
        </div>
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""marca"" class=""form-label"">Digite el origen:</label>
          <input type=""number"" class=""form-control"" id=""origen"" name=""origen"" placeholder=""Origen"" required>
        </div>
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""modelo"" class=""form-label"">Digite el destino:</label>
          <input type=""number"" class=""form-control"" id=""destino"" name=""destino"" placeholder=""Destino"" required>
        </div>
        <div class=""col-6 col-md-4 col-lg-4"">
          <label for=""kilometraje"" class=""form-label"">Digite tiempo estimado:</label>
          <input type=""number"" class=""form-control"" id=""tiempo_estima");
                WriteLiteral(@"do"" name=""tiempo_estimado"" placeholder=""Tiempo_estimado"" required>
        </div>
      </div>
      <br>

    </div>


    <hr>
    <button type=""submit"" class=""btn btn-success"" style=""font-family: cursive;color:black"">  &nbspEnviar&nbsp  </button>


  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.FormRutasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.FormRutasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.FormRutasModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.FormRutasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

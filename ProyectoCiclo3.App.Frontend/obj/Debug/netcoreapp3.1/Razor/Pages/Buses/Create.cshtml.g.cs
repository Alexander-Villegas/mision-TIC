#pragma checksum "C:\Users\Sebas\Desktop\ProyectoDev5.App\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\Buses\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7bf9a168e3bae37270e7c2b1526b9a0968bd58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Buses.Pages_Buses_Create), @"mvc.1.0.razor-page", @"/Pages/Buses/Create.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Buses
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7bf9a168e3bae37270e7c2b1526b9a0968bd58", @"/Pages/Buses/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buses_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7bf9a168e3bae37270e7c2b1526b9a0968bd583531", async() => {
                WriteLiteral(@"
    <div class=""container"">
      <div class=""row justify-content-md-center"">
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""id"" class=""form-label"">Digite el ID:</label>
          <input type=""text"" class=""form-control"" id=""id"" name=""id"" placeholder=""Id del bus"">
        </div>
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""marca"" class=""form-label"">Digite la marca:</label>
          <input type=""text"" class=""form-control"" id=""marca"" name=""marca"" placeholder=""Marca del bus"">
        </div>
        <div class=""col-6 col-md-auto col-lg-4"">
          <label for=""modelo"" class=""form-label"">Digite el modelo:</label>
          <input type=""number"" class=""form-control"" id=""modelo"" name=""modelo"" placeholder=""Modelo del bus"">
        </div>
        <div class=""col-6 col-md-4 col-lg-4"">
          <label for=""kilometraje"" class=""form-label"">Digite el kilometraje</label>
          <input type=""number"" class=""form-control"" id=""kilometraje"" name=""kilometraje");
                WriteLiteral(@""" placeholder=""kilometraje del bus"">
        </div>
        <div class=""col-6 col-md-4 col-lg-4"">
          <label for=""numero_asientos"" class=""form-label"">Digite el numero de asientos:</label>
          <input type=""number"" class=""form-control"" id=""numero_asientos"" name=""numero_asientos""placeholder=""# de asientos"">
        </div>
        <div class=""col-6 col-md-4 col-lg-4"">
          <label for=""Placa"" class=""form-label"">Digite la placa del bus:</label>
          <input type=""text"" class=""form-control"" id=""placa"" name=""Placa"" placeholder=""Placa del bus"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Buses_Create> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Buses_Create> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Buses_Create>)PageContext?.ViewData;
        public Pages_Buses_Create Model => ViewData.Model;
    }
}
#pragma warning restore 1591

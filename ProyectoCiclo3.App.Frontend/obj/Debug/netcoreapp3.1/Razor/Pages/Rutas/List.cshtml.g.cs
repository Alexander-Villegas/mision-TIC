#pragma checksum "C:\Users\josem\Documents\Misión TIC\Proyecto ciclo 3 copia\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\Rutas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c893acfb2d18313b7727fd6155d6ff0b6e9af40d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Rutas.Pages_Rutas_List), @"mvc.1.0.razor-page", @"/Pages/Rutas/List.cshtml")]
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
#line 1 "C:\Users\josem\Documents\Misión TIC\Proyecto ciclo 3 copia\mision-TIC\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c893acfb2d18313b7727fd6155d6ff0b6e9af40d", @"/Pages/Rutas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rutas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 
<table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">ID</th>
      <th scope=""col"">Origen</th>
      <th scope=""col"">Destino</th>
      <th scope=""col"">Tiempo_estimado</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope=""row"">1</th>
      <td>Portal norte</td>
      <td>Portal Sur</td>
      <td>120</td>
    </tr>
    <tr>
      <th scope=""row"">2</th>
      <td>Portal sur</td>
      <td>Ricaurte</td>
      <td>60</td>
    </tr>
    <tr>
      <th scope=""row"">3</th>
      <td>Portal norte</td>
      <td>Portal 80</td>
      <td>50</td>
    </tr>
  </tbody>
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Rutas_List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Rutas_List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Rutas_List>)PageContext?.ViewData;
        public Pages_Rutas_List Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ffcf85c869e39a493711987eae383d5f788dc84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Andres\Desktop\Trabajo3\Views\_ViewImports.cshtml"
using Trabajo;

#line default
#line hidden
#line 2 "C:\Users\Andres\Desktop\Trabajo3\Views\_ViewImports.cshtml"
using Trabajo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ffcf85c869e39a493711987eae383d5f788dc84", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fbd0b8a33b2434a1051cc58dd6617c3ae1449c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Evento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
 foreach(var evento in Model) {

#line default
#line hidden
            BeginContext(103, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(112, 13, false);
#line 8 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
   Write(evento.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(125, 29, true);
            WriteLiteral(" </h2>\r\n    <h3>Descripcion: ");
            EndContext();
            BeginContext(155, 18, false);
#line 9 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
                Write(evento.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(173, 27, true);
            WriteLiteral(" </h3>\r\n    <h3>Direccion: ");
            EndContext();
            BeginContext(201, 16, false);
#line 10 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
              Write(evento.Direccion);

#line default
#line hidden
            EndContext();
            BeginContext(217, 23, true);
            WriteLiteral(" </h3>\r\n    <h3>Fecha: ");
            EndContext();
            BeginContext(241, 12, false);
#line 11 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
          Write(evento.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(253, 17, true);
            WriteLiteral("? </h3>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 270, "\"", 288, 1);
#line 12 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
WriteAttributeValue("", 276, evento.Foto, 276, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(289, 17, true);
            WriteLiteral(" width=\"300\" />\r\n");
            EndContext();
#line 13 "C:\Users\Andres\Desktop\Trabajo3\Views\Home\Index.cshtml"
    
}

#line default
#line hidden
            BeginContext(315, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591

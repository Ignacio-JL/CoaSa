#pragma checksum "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c235915891664b305e29bbda567c53ef8810e2aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaUsuario), @"mvc.1.0.view", @"/Views/Home/ListaUsuario.cshtml")]
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
#line 1 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\_ViewImports.cshtml"
using CoaSaAPI_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\_ViewImports.cshtml"
using CoaSaAPI_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c235915891664b305e29bbda567c53ef8810e2aa", @"/Views/Home/ListaUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56837aa56bbabc016c095528c835eb2c2ce152da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
  
    ViewData["Title"] = "ListaUsuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Lista de usuarios</h1>

<div class=""col-md-12"">
    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Id Usuario</th>
                <th scope=""col"">Nombre Usuario</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Teléfono</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
             foreach (var usuarios in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
#nullable restore
#line 26 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
                           Write(usuarios.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
               Write(usuarios.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
               Write(usuarios.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
               Write(usuarios.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
               Write(usuarios.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
               Write(Html.ActionLink("Eliminar", "Eliminar", new {@usuarios.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
               Write(Html.ActionLink("Editar", "Editar", new { @usuarios.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\ListaUsuario.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n<hr />\r\n<div class=\"col-md-12 text-center\">\r\n    <a class=\"btn btn-danger\" href=\"https://localhost:44382/Home/Crear\" style=\"margin: 20px auto;\">Crear usuario</a>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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

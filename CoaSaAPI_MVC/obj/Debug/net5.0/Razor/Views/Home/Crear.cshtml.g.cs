#pragma checksum "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d529ce8146b291ae87f10a2b1fa633e1d1414ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Crear), @"mvc.1.0.view", @"/Views/Home/Crear.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d529ce8146b291ae87f10a2b1fa633e1d1414ae1", @"/Views/Home/Crear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56837aa56bbabc016c095528c835eb2c2ce152da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Crear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Crear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formCrear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
  
    ViewData["Title"] = "Crear";

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
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                 foreach (var usuarios in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                            <td scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                                       Write(usuarios.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                           Write(usuarios.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                           Write(usuarios.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                           Write(usuarios.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                           Write(usuarios.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Ignacio\source\repos\DatabaseAPI\CoaSaAPI_MVC\Views\Home\Crear.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n  \r\n</div>\r\n\r\n<hr />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        \r\n        <div class=\"col\">\r\n            <h2 class=\"text-center col-md-12\">Crear Usuario</h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d529ce8146b291ae87f10a2b1fa633e1d1414ae17422", async() => {
                WriteLiteral(@"
                <div class=""col-md-6"">
                    <label for=""UserName"" class=""form-label""></label>
                    <input type=""text"" id=""UserName"" name=""UserName"" placeholder=""nombreUsuario"" class=""form-control"" required />
                    <div class=""invalid-feedback"">Este campo es obligatorio</div>
                </div>
                <div class=""col-md-6"">
                    <label for=""Nombre"" class=""form-label""></label>
                    <input type=""text"" id=""Nombre"" name=""Nombre"" placeholder=""nombre"" class=""form-control"" required />
                    <div class=""invalid-feedback"">Este campo es obligatorio</div>
                </div>
                <div class=""col-md-6"">
                    <label for=""Email"" class=""form-label""></label>
                    <input type=""email"" id=""Email"" name=""Email"" placeholder=""example@example.com"" class=""form-control"" required />
                    <div class=""invalid-feedback"">Este campo es obligatorio</div>
              ");
                WriteLiteral(@"  </div>
                <div class=""col-md-6"">
                    <label for=""Telefono"" class=""form-label""></label>
                    <input type=""text"" id=""Telefono"" name=""Telefono"" placeholder=""teleefono"" class=""form-control"" />
                </div>
                
                <div class=""col-md-12 text-center"">
                    <button type=""submit"" class=""btn btn-danger"" style=""margin: 20px auto;"">Crear usuario</button>
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    
    // Example starter JavaScript for disabling form submissions if there are invalid fields
    (function () {
        'use strict'

        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        
        var forms = document.querySelectorAll('.needs-validation')

        // Loop over them and prevent submission
        Array.prototype.slice.call(forms)
            .forEach(function (form) {
                form.addEventListener('submit', function (event) {
                    if (!form.checkValidity()) {
                        event.preventDefault()
                        event.stopPropagation()
                    }

                    form.classList.add('was-validated')
                }, false)
            })
    })()
</script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
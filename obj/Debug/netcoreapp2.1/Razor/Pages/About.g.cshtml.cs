#pragma checksum "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8342819f48ae95afb0750d1c6d8f3bf9e64108c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(survey.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(survey.Pages.Pages_About), null)]
namespace survey.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/unarix/Documentos/code/usurvey/Pages/_ViewImports.cshtml"
using survey;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8342819f48ae95afb0750d1c6d8f3bf9e64108c", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6b59649e01d8906f1bda3d0fdfeca3966a761b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("En grados celsius"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("temperatura"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("basic-addon1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
  
    ViewData["Title"] = "Comprobar";

#line default
#line hidden
            BeginContext(75, 164, true);
            WriteLiteral("\r\n\r\n<div class=\"py-5 text-center\">\r\n    <!--img class=\"d-block mx-auto mb-4\" src=\"images/covid.png\" alt=\"\" width=\"100\"-->\r\n    <h2>Comprobar DDJJ</h2>\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 14 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
 if (@Model.temperatura == null)
{


#line default
#line hidden
            BeginContext(278, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(282, 572, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87177da7861e488ca8731f176efde6a5", async() => {
                BeginContext(302, 234, true);
                WriteLiteral("\r\n        <h4>Ingrese temperatura </h4>\r\n        <br>\r\n        <div class=\"input-group mb-3\">\r\n        <div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\" id=\"basic-addon1\">Cº</span>\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(536, 170, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f7abd9d1278c406abbc3f17e73b80e55", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 24 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.temperatura);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("autofocus", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(706, 141, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        \r\n        <button class=\"btn btn-danger btn-primary btn-lg btn-block\" type=\"submit\">Finalizar DDJJ</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(854, 97, true);
            WriteLiteral("\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <h4>Datos del empleado</h4>\r\n    <br>\r\n    <p><b>Nombre:</b> ");
            EndContext();
            BeginContext(952, 12, false);
#line 35 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                 Write(Model.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(964, 24, true);
            WriteLiteral("</p>\r\n    <P><b>DNI</b> ");
            EndContext();
            BeginContext(989, 9, false);
#line 36 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
             Write(Model.dni);

#line default
#line hidden
            EndContext();
            BeginContext(998, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(1010, 80, true);
            WriteLiteral("    <hr class=\"mb-4\">  \r\n    <h4>Sintomas</h4>\r\n    <br>\r\n    <p><b>Fiebre:</b> ");
            EndContext();
            BeginContext(1091, 12, false);
#line 41 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                 Write(Model.fiebre);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 25, true);
            WriteLiteral("</p>\r\n    <p><b>Tos:</b> ");
            EndContext();
            BeginContext(1129, 9, false);
#line 42 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
              Write(Model.tos);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 36, true);
            WriteLiteral("</p>\r\n    <p><b>Dolor Garganta:</b> ");
            EndContext();
            BeginContext(1175, 14, false);
#line 43 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                         Write(Model.garganta);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 47, true);
            WriteLiteral("</p>\r\n    <p><b>Perdida de olfato y gusto:</b> ");
            EndContext();
            BeginContext(1237, 12, false);
#line 44 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                                    Write(Model.olfato);

#line default
#line hidden
            EndContext();
            BeginContext(1249, 44, true);
            WriteLiteral("</p>\r\n    <p><b>Dificultar al respirar:</b> ");
            EndContext();
            BeginContext(1294, 14, false);
#line 45 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                                 Write(Model.respirar);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 29, true);
            WriteLiteral("</p>\r\n    <p><b>Diarrea:</b> ");
            EndContext();
            BeginContext(1338, 13, false);
#line 46 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                  Write(Model.diarrea);

#line default
#line hidden
            EndContext();
            BeginContext(1351, 28, true);
            WriteLiteral("</p>\r\n    <p><b>Vómito:</b> ");
            EndContext();
            BeginContext(1380, 12, false);
#line 47 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                 Write(Model.vomito);

#line default
#line hidden
            EndContext();
            BeginContext(1392, 40, true);
            WriteLiteral("</p>\r\n    <p><b>Erupciones de piel:</b> ");
            EndContext();
            BeginContext(1433, 16, false);
#line 48 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                             Write(Model.erupciones);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 37, true);
            WriteLiteral("</p>\r\n    <p><b>Dolor de cabeza:</b> ");
            EndContext();
            BeginContext(1487, 12, false);
#line 49 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                          Write(Model.cabeza);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 36, true);
            WriteLiteral("</p>\r\n    <p><b>Dolor muscular:</b> ");
            EndContext();
            BeginContext(1536, 14, false);
#line 50 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                         Write(Model.muscular);

#line default
#line hidden
            EndContext();
            BeginContext(1550, 38, true);
            WriteLiteral("</p>\r\n    <p><b>Sangrado anormal:</b> ");
            EndContext();
            BeginContext(1589, 14, false);
#line 51 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                           Write(Model.sangrado);

#line default
#line hidden
            EndContext();
            BeginContext(1603, 43, true);
            WriteLiteral("</p>\r\n    <p><b>Piel u ojos amarillos:</b> ");
            EndContext();
            BeginContext(1647, 10, false);
#line 52 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                                Write(Model.piel);

#line default
#line hidden
            EndContext();
            BeginContext(1657, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(1669, 25, true);
            WriteLiteral("    <hr class=\"mb-4\">  \r\n");
            EndContext();
            BeginContext(1696, 104, true);
            WriteLiteral("    <h4><b>Estuve en contacto cercano con personas que hayan manifestado los síntomas del COVID-19:</b> ");
            EndContext();
            BeginContext(1801, 14, false);
#line 56 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                                                                                                   Write(Model.contacto);

#line default
#line hidden
            EndContext();
            BeginContext(1815, 47, true);
            WriteLiteral("</h4>\r\n    <p><b>Descripcion del contacto:</b> ");
            EndContext();
            BeginContext(1863, 19, false);
#line 57 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                                   Write(Model.contacto_desc);

#line default
#line hidden
            EndContext();
            BeginContext(1882, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(1894, 75, true);
            WriteLiteral("    <hr class=\"mb-4\">  \r\n    <h4><b>Me he realizo un test de COVID-19:</b> ");
            EndContext();
            BeginContext(1970, 10, false);
#line 60 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                                             Write(Model.test);

#line default
#line hidden
            EndContext();
            BeginContext(1980, 37, true);
            WriteLiteral("</h4>\r\n    <p><b>Fecha del test:</b> ");
            EndContext();
            BeginContext(2018, 16, false);
#line 61 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                         Write(Model.fecha_test);

#line default
#line hidden
            EndContext();
            BeginContext(2034, 31, true);
            WriteLiteral("</p>\r\n    <p><b>Resultado:</b> ");
            EndContext();
            BeginContext(2066, 15, false);
#line 62 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
                    Write(Model.test_desc);

#line default
#line hidden
            EndContext();
            BeginContext(2081, 31, true);
            WriteLiteral("</p>\r\n    <hr class=\"mb-4\">  \r\n");
            EndContext();
#line 64 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(2126, 26, true);
            WriteLiteral("    <center>\r\n        <h4>");
            EndContext();
            BeginContext(2153, 13, false);
#line 69 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
       Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2166, 171, true);
            WriteLiteral("</h4>\r\n        <br>\r\n        <button type=\"button\" onclick=\"window.location=\'https://usurvey.azurewebsites.net/\';\" class=\"btn btn-success\">Cerrar</button>\r\n    </center>\r\n");
            EndContext();
#line 73 "/home/unarix/Documentos/code/usurvey/Pages/About.cshtml"
}

#line default
#line hidden
            BeginContext(2340, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComprobarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComprobarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComprobarModel>)PageContext?.ViewData;
        public ComprobarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

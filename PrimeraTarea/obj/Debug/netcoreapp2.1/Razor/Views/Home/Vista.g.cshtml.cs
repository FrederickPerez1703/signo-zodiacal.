#pragma checksum "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\Home\Vista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ad1163ad769ddd99268a12c6ae7db9b0cfaf5cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vista), @"mvc.1.0.view", @"/Views/Home/Vista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Vista.cshtml", typeof(AspNetCore.Views_Home_Vista))]
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
#line 1 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\_ViewImports.cshtml"
using PrimeraTarea;

#line default
#line hidden
#line 2 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\_ViewImports.cshtml"
using PrimeraTarea.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ad1163ad769ddd99268a12c6ae7db9b0cfaf5cb", @"/Views/Home/Vista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b810286f69fcdcedfaac927e5a2afa65e921948", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Vista"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\Home\Vista.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb767f3e3667417eaa47a8ff0e04292c", async() => {
                BeginContext(64, 304, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Vista</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(375, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(379, 2607, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a132c4c7243443ca5c801bb258b67ea", async() => {
                BeginContext(385, 339, true);
                WriteLiteral(@"
    <h1 style=""margin:90px"">  Bienvenido </h1>

    <div class=""card bg-dark text-white"">

        <div style=""background-color:cadetblue; width:60%; height:50%; margin:auto; padding:69px; opacity:0.9"">

            <h2 style=""text-align:center; color:black; height:auto;"">Signo Zodiacoles </h2>
            <br />

            ");
                EndContext();
                BeginContext(724, 1599, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef70ff97f064b90ab771c77d9fe4149", async() => {
                    BeginContext(765, 336, true);
                    WriteLiteral(@"

                <div style=""width:auto;"">


                    <div>
                        <label style=""padding:0px; color:black;"">Inserte el Dia de nacimiento:</label>

                        <input style=""padding-left:5px;"" size=""8"" ; type=""number"" name=""Dia"" required autofocus placeholder=""inserte el dia"" />  <span> ");
                    EndContext();
                    BeginContext(1102, 11, false);
#line 33 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\Home\Vista.cshtml"
                                                                                                                                                   Write(ViewBag.msj);

#line default
#line hidden
                    EndContext();
                    BeginContext(1113, 315, true);
                    WriteLiteral(@";</span>
                    </div>

                    <div style=""padding-top:30px;"">
                        <label style=""padding-top:0px; color:black;"">Inserte el mes de nacimiento:</label>
                        <input size=""6"" ; type=""number"" name=""mes"" required placeholder=""inserte el mes"" /> <span>");
                    EndContext();
                    BeginContext(1429, 11, false);
#line 38 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\Home\Vista.cshtml"
                                                                                                             Write(ViewBag.msj);

#line default
#line hidden
                    EndContext();
                    BeginContext(1440, 164, true);
                    WriteLiteral(";</span>\r\n                    </div>\r\n                    <br />\r\n\r\n                    <div>\r\n                        <label style=\"color:black;\">Signo zodiacal : ");
                    EndContext();
                    BeginContext(1605, 17, false);
#line 43 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\Home\Vista.cshtml"
                                                                Write(ViewData["Signo"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1622, 153, true);
                    WriteLiteral("</label>\r\n                    </div>\r\n                    <br />\r\n                    <div>\r\n                        <label style=\"color:black;\"> Astro: ");
                    EndContext();
                    BeginContext(1776, 17, false);
#line 47 "C:\Users\Frederick\source\repos\PrimeraTarea\PrimeraTarea\Views\Home\Vista.cshtml"
                                                       Write(ViewData["Astro"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1793, 523, true);
                    WriteLiteral(@"  </label>
                    </div>
                    <h5 style=""color:black""> No puede dejar ninguna campo vacio tampoco poner numeros negativos </h5>
                    <div>
                        <br />
                        <hr />
                    </div>
                    <div style=""padding-top:-50px; padding-left:100px;"">
                        <button style=""width:29rem; height:4rem;"" type=""submit"">Enviar</button>
                    </div>


                </div>



            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2323, 656, true);
                WriteLiteral(@"



        </div>
        </div>  

        <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
        <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2986, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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

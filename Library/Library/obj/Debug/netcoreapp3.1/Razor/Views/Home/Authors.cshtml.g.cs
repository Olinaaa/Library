#pragma checksum "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87adf7fed92225359acc2fea984b9b78fad397dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Authors), @"mvc.1.0.view", @"/Views/Home/Authors.cshtml")]
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
#line 1 "C:\Users\alina\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alina\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87adf7fed92225359acc2fea984b9b78fad397dd", @"/Views/Home/Authors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Authors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 2 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
  
    ViewData["Title"] = "Authors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Список авторов</h1>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87adf7fed92225359acc2fea984b9b78fad397dd3310", async() => {
                WriteLiteral(@"
    <div>
        <table>
            <tr>
                <th><p><center>Автор</center></p></th>
                <th><p><center>Код автора</center></p></th>
                <th><p><center>День рождения</center></p></th>
                <th><p><center>Страна рождения</center></p></th>
                <th></th>
            </tr>
");
#nullable restore
#line 19 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
             foreach (Авторы b in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td><p>");
#nullable restore
#line 22 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
              Write(b.ФиоАвтора);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n            <td><p><center>");
#nullable restore
#line 23 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
                      Write(b.КодАвтора);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center></p></td>\r\n            <td><p><center>");
#nullable restore
#line 24 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
                      Write(b.ДеньРождения);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center></p></td>\r\n            <td><p><center>");
#nullable restore
#line 25 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
                      Write(b.Страна);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center></p></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\alina\source\repos\Library\Library\Views\Home\Authors.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
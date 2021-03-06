#pragma checksum "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58472feab815a8a24639826832c5c08ed1fe310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\_ViewImports.cshtml"
using WebProjekt_Beispiel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
using WebProjekt_Beispiel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58472feab815a8a24639826832c5c08ed1fe310", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec914608260d73a09cbc2bb0931cf8a27881a654", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
   
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
 if ((Model == null || Model.Count == 0))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Es sind keine Artikel im Shop vorhanden.\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
}
else
{
    // alle Artikel in Tabellenform ausgeben

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table>
    <thead>
        <tr>
            <td colspan=5>
                Shopartikel
            </td>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Artikel-ID</td>
            <td>Name</td>
            <td>Beschreibung</td>
            <td>Erscheinungsdatum</td>
            <td>Preis</td>
        </tr>
");
#nullable restore
#line 37 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
         foreach (Article a in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
           Write(a.ArticleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
           Write(a.Articlename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
           Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
           Write(a.ReleaseDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
           Write(a.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58472feab815a8a24639826832c5c08ed1fe3106521", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"l??schen\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1070, "/shop/delete/", 1070, 13, true);
#nullable restore
#line 46 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 1083, a.ArticleId, 1083, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=5>\r\n                    alle Artikel unseres Shops\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 61 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shop\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591

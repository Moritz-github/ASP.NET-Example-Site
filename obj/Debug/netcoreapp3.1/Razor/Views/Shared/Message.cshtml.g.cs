#pragma checksum "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8963520efeeec58a7939601feea950f2fe74d25f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Message), @"mvc.1.0.view", @"/Views/Shared/Message.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8963520efeeec58a7939601feea950f2fe74d25f", @"/Views/Shared/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec914608260d73a09cbc2bb0931cf8a27881a654", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProjekt_Beispiel.Models.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
 if (Model != null) {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 5 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
   Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("    <b>Meldung</b>\r\n    <p>\r\n        ");
#nullable restore
#line 9 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
   Write(Model.Messagetext);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 13 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
     if (Model.Solution != null && Model.Solution.Trim() != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>L??sung</b>\r\n        <p>\r\n            ");
#nullable restore
#line 17 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
       Write(Model.Solution);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 19 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
     
    
} 
else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Es wurde keine Meldung ??bergeben!\r\n    </p>\r\n");
#nullable restore
#line 26 "C:\Users\mo\Desktop\MEGAsync\Coding\C# Schule\ASP_NET_Core\WebProjekt-Beispiel\Views\Shared\Message.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProjekt_Beispiel.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591

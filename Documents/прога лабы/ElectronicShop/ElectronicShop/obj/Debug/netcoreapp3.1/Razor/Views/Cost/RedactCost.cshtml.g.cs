#pragma checksum "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f62609d7d69ad93a9b9c9e76c28fc9572f40cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cost_RedactCost), @"mvc.1.0.view", @"/Views/Cost/RedactCost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f62609d7d69ad93a9b9c9e76c28fc9572f40cc6", @"/Views/Cost/RedactCost.cshtml")]
    public class Views_Cost_RedactCost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElectronicShop.Storage.Entity.Cost>
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
#nullable restore
#line 2 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
  
    ViewData["Title"] = "RedactCost";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Изменить ценник</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f62609d7d69ad93a9b9c9e76c28fc9572f40cc62852", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
     using (Html.BeginForm("Redact", "Cost", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 235, "\"", 252, 1);
#nullable restore
#line 10 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
WriteAttributeValue("", 243, Model.id, 243, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"FId\"");
                BeginWriteAttribute("value", " value=\"", 297, "\"", 320, 1);
#nullable restore
#line 11 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
WriteAttributeValue("", 305, Model.DeviceId, 305, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <label>В долларах</label>\r\n        <input type=\"text\" name=\"CostInDollars\"");
                BeginWriteAttribute("value", " value=\"", 408, "\"", 436, 1);
#nullable restore
#line 13 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
WriteAttributeValue("", 416, Model.costInDollars, 416, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n        <label>В рублях</label>\r\n        <input type=\"text\" name=\"CostInRub\"");
                BeginWriteAttribute("value", " value=\"", 524, "\"", 548, 1);
#nullable restore
#line 15 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
WriteAttributeValue("", 532, Model.costInRub, 532, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n");
                WriteLiteral("        <input type=\"submit\" value=\"Изменить\">\r\n");
#nullable restore
#line 18 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
     using (Html.BeginForm("Output", "Cost", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <input type=\"submit\" value=\"Вернуться\">\r\n\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\Cost\RedactCost.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElectronicShop.Storage.Entity.Cost> Html { get; private set; }
    }
}
#pragma warning restore 1591

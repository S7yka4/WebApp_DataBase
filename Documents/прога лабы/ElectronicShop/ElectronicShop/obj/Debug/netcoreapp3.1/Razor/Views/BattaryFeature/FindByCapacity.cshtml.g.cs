#pragma checksum "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b26dc8052b77df356c1b3dc6f7de2dbd43251e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BattaryFeature_FindByCapacity), @"mvc.1.0.view", @"/Views/BattaryFeature/FindByCapacity.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b26dc8052b77df356c1b3dc6f7de2dbd43251e", @"/Views/BattaryFeature/FindByCapacity.cshtml")]
    public class Views_BattaryFeature_FindByCapacity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElectronicShop.Storage.Entity.BattaryFeature>>
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
#line 2 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
  
    ViewData["Title"] = "Output";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Результаты поиска</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b26dc8052b77df356c1b3dc6f7de2dbd43251e2957", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
     foreach (var tmp in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Id</label><br />");
#nullable restore
#line 10 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
                          Write(tmp.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        <label>Емкость Аккумулятора</label><br />");
#nullable restore
#line 11 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
                                            Write(tmp.battaryCapacity);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        <label>Напряжение Аккумулятора</label><br />");
#nullable restore
#line 12 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
                                               Write(tmp.voltage);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        <label>Токоотдача Аккумулятора</label><br />");
#nullable restore
#line 13 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
                                               Write(tmp.currentOutput);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 14 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
         using (Html.BeginForm("RedactBattery", "BattaryFeature", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 569, "\"", 613, 2);
                WriteAttributeValue("", 576, "/BattaryFeature/Redactbattery/", 576, 30, true);
#nullable restore
#line 16 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
WriteAttributeValue("", 606, tmp.id, 606, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редактировать Характеристики</a>\r\n");
#nullable restore
#line 17 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
         using (Html.BeginForm("DeleteBattery", "BattaryFeature", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 769, "\"", 813, 2);
                WriteAttributeValue("", 776, "/BattaryFeature/DeleteBattery/", 776, 30, true);
#nullable restore
#line 20 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
WriteAttributeValue("", 806, tmp.id, 806, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Удалить</a>\r\n");
#nullable restore
#line 21 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 25 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
         using (Html.BeginForm("Output", "BattaryFeature", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <input type=\"submit\" value=\"Вернуться\">\r\n\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\BattaryFeature\FindByCapacity.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElectronicShop.Storage.Entity.BattaryFeature>> Html { get; private set; }
    }
}
#pragma warning restore 1591

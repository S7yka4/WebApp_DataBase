#pragma checksum "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\ResponsibleConsultant\AddNewResponsibleConsultant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26cb7776c9ea970e2d9a62bb1d2dfa1acf341898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ResponsibleConsultant_AddNewResponsibleConsultant), @"mvc.1.0.view", @"/Views/ResponsibleConsultant/AddNewResponsibleConsultant.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26cb7776c9ea970e2d9a62bb1d2dfa1acf341898", @"/Views/ResponsibleConsultant/AddNewResponsibleConsultant.cshtml")]
    public class Views_ResponsibleConsultant_AddNewResponsibleConsultant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guid>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\ResponsibleConsultant\AddNewResponsibleConsultant.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26cb7776c9ea970e2d9a62bb1d2dfa1acf3418983085", async() => {
                WriteLiteral("\r\n    <h1>Добавление консультанта</h1>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26cb7776c9ea970e2d9a62bb1d2dfa1acf3418984091", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\ResponsibleConsultant\AddNewResponsibleConsultant.cshtml"
     using (Html.BeginForm("CreateNewResponsibleConsultant", "ResponsibleConsultant", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Имя</label>\r\n        <input type=\"text\" name=\"Name\" /><br />\r\n        <label>Оценка</label>\r\n        <input type=\"text\" name=\"Mark\" /><br />\r\n        <input type=\"submit\" value=\"Добавить\">\r\n");
#nullable restore
#line 16 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\ResponsibleConsultant\AddNewResponsibleConsultant.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\ResponsibleConsultant\AddNewResponsibleConsultant.cshtml"
     using (Html.BeginForm("Output", "ResponsibleConsultant", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <input type=\"submit\" value=\"Вернуться\">\r\n\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\S7yka4\Documents\прога лабы\ElectronicShop\ElectronicShop\Views\ResponsibleConsultant\AddNewResponsibleConsultant.cshtml"
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guid> Html { get; private set; }
    }
}
#pragma warning restore 1591

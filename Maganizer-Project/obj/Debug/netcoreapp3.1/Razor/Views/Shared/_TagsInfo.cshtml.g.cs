#pragma checksum "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_TagsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eedeb7b05e2a621af6187ed4e3ccd4c8a6676b70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TagsInfo), @"mvc.1.0.view", @"/Views/Shared/_TagsInfo.cshtml")]
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
#line 1 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\_ViewImports.cshtml"
using Maganizer_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eedeb7b05e2a621af6187ed4e3ccd4c8a6676b70", @"/Views/Shared/_TagsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453525a32fad66d68d7c3da0bc175a93fafb212f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TagsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganizer_Project.WEB.Models.TagsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <ul class=\"all-post-tags \">\r\n");
#nullable restore
#line 4 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_TagsInfo.cshtml"
         foreach (var x in Model.Tags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("title", " title=\"", 155, "\"", 170, 1);
#nullable restore
#line 6 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_TagsInfo.cshtml"
WriteAttributeValue("", 163, x.Name, 163, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_TagsInfo.cshtml"
                              Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 7 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_TagsInfo.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganizer_Project.WEB.Models.TagsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

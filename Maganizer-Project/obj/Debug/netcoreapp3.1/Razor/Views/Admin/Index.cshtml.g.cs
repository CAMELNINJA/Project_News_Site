<<<<<<< HEAD
#pragma checksum "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce65ff73bdae50c93e2f19ab08625ea072c0c7e6"
=======
#pragma checksum "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b24fc9c51387e25510011e4d6a74e5eca063fc4"
>>>>>>> c917c2518d98559f9c61a8630e084cfa6882acf2
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce65ff73bdae50c93e2f19ab08625ea072c0c7e6", @"/Views/Admin/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b24fc9c51387e25510011e4d6a74e5eca063fc4", @"/Views/Admin/Index.cshtml")]
>>>>>>> c917c2518d98559f9c61a8630e084cfa6882acf2
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453525a32fad66d68d7c3da0bc175a93fafb212f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganizer_Project.Models.AdminIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Active"] = "Index";
    ViewData["Title"] = "Lists | Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce65ff73bdae50c93e2f19ab08625ea072c0c7e64483", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b24fc9c51387e25510011e4d6a74e5eca063fc44380", async() => {
>>>>>>> c917c2518d98559f9c61a8630e084cfa6882acf2
                WriteLiteral(@"
  <!--Основные таблицы-->
  <div class=""lime-container"">
    <div class=""lime-body"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-8"">
            <div class=""card"">
              <div class=""card-body"">
                <h5 class=""card-title"">Users</h5>
                <div class=""table-responsive"">
                  <table class=""table"">
                    <thead>
                      <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Username</th>
                      </tr>
                    </thead>
                    <tbody class=""elastic"">

");
#nullable restore
#line 29 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       foreach (var item in Model.Users)
                      {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <tr >\r\n                        <td>");
#nullable restore
#line 32 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       Write(item.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                       Write(item.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                       </tr>\r\n");
#nullable restore
#line 36 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                  </table>
                </div>
              </div>
            </div>
          </div>
          <div class=""col-md-4"">
            <div class=""card"">
              <div class=""card-body"">
                <h5 class=""card-title"">Tags</h5>
                <div class=""social-media-list"" >
");
#nullable restore
#line 48 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                   foreach (var item in Model.Tags)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"social-media-item\">\r\n                        <div class=\"social-text\">\r\n                            \r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce65ff73bdae50c93e2f19ab08625ea072c0c7e67840", async() => {
                    WriteLiteral("\r\n                                <p>\r\n                                    ");
#nullable restore
#line 55 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
                    WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                                </p>\r\n                                <input hidden name=\"tag\"");
                    BeginWriteAttribute("value", " value=\"", 2108, "\"", 2126, 1);
#nullable restore
#line 58 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2116, item.Name, 2116, 10, false);
=======
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b24fc9c51387e25510011e4d6a74e5eca063fc47903", async() => {
                    WriteLiteral("\r\n                                    <input hidden name=\"tag\"");
                    BeginWriteAttribute("value", " value=\"", 1880, "\"", 1898, 1);
#nullable restore
#line 53 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1888, item.Name, 1888, 10, false);
>>>>>>> c917c2518d98559f9c61a8630e084cfa6882acf2

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                \r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
                WriteLiteral("\r\n                            \r\n                        </div>\r\n                  </div>\r\n");
#nullable restore
#line 64 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
=======
                WriteLiteral("\r\n                             </p>\r\n                            \r\n                        </div>\r\n                  </div>\r\n");
#nullable restore
#line 60 "C:\NewProgram\GithubRepository\Project_News_Site\Maganizer-Project\Views\Admin\Index.cshtml"
>>>>>>> c917c2518d98559f9c61a8630e084cfa6882acf2
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  
                </div>
              </div>
            </div>
          </div>
        </div>

      </div>
    </div>
    <div class=""lime-footer"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <span class=""footer-text"">2021 © develop</span>
          </div>
        </div>
      </div>
    </div>
  </div>

");
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
            WriteLiteral(@"
<script>
  document.addEventListener('DOMContentLoaded', () => {

    const getSort = ({ target }) => {
      const order = (target.dataset.order = -(target.dataset.order || -1));
      const index = [...target.parentNode.cells].indexOf(target);
      const collator = new Intl.Collator(['en', 'ru'], { numeric: true });
      const comparator = (index, order) => (a, b) => order * collator.compare(
        a.children[index].innerHTML,
        b.children[index].innerHTML
      );

      for (const tBody of target.closest('table').tBodies)
        tBody.append(...[...tBody.rows].sort(comparator(index, order)));

      for (const cell of target.parentNode.cells)
        cell.classList.toggle('sorted', cell === target);
    };

    document.querySelectorAll('.table thead').forEach(tableTH => tableTH.addEventListener('click', () => getSort(event)));

  });
</script>

<style>
  .table_sort table {
    border-collapse: collapse;
  }
  .table_sort th {
    cursor: pointer;
  }
  th.sort");
            WriteLiteral(@"ed[data-order=""1""],
  th.sorted[data-order=""-1""] {
    position: relative;
  }

    th.sorted[data-order=""1""]::after,
    th.sorted[data-order=""-1""]::after {
      right: 8px;
      position: absolute;
    }

    th.sorted[data-order=""-1""]::after {
      content: ""▼""
    }

    th.sorted[data-order=""1""]::after {
      content: ""▲""
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganizer_Project.Models.AdminIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

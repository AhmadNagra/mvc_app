#pragma checksum "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0ee3c46d559c0d98e66ed71ff78869f42aaa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_user_ShowData), @"mvc.1.0.view", @"/Views/user/ShowData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/user/ShowData.cshtml", typeof(AspNetCore.Views_user_ShowData))]
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
#line 1 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\_ViewImports.cshtml"
using mvc_app;

#line default
#line hidden
#line 2 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\_ViewImports.cshtml"
using mvc_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0ee3c46d559c0d98e66ed71ff78869f42aaa9a", @"/Views/user/ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b1abf854b28eb3fdf3ad32069409924807a7cf", @"/Views/_ViewImports.cshtml")]
    public class Views_user_ShowData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mvc_app.Models.UserModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
  
    ViewData["Title"] = "ShowData";

#line default
#line hidden
            BeginContext(92, 5155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd9c40178faf49278f7b12322b759fbd", async() => {
                BeginContext(98, 84, true);
                WriteLiteral("\r\n\r\n    <input type=\"button\" class=\"btn-primary\" style=\"float:right;\" value=\"Create\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 182, "\"", 239, 3);
                WriteAttributeValue("", 192, "location.href=\'", 192, 15, true);
#line 8 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
WriteAttributeValue("", 207, Url.Action("userpage", "User"), 207, 31, false);

#line default
#line hidden
                WriteAttributeValue("", 238, "\'", 238, 1, true);
                EndWriteAttribute();
                BeginContext(240, 211, true);
                WriteLiteral(" />\r\n    <div><h3>Users Data</h3></div>\r\n    <table class=\"table table-striped table-bordered\"  id=\"myTable\">\r\n        <thead>\r\n            <tr>\r\n                <th onclick=\"sortTable(0)\">\r\n                    ");
                EndContext();
                BeginContext(452, 38, false);
#line 14 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(490, 90, true);
                WriteLiteral("\r\n                </th>\r\n                <th onclick=\"sortTable(1)\">\r\n                    ");
                EndContext();
                BeginContext(581, 40, false);
#line 17 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(621, 90, true);
                WriteLiteral("\r\n                </th>\r\n                <th onclick=\"sortTable(2)\">\r\n                    ");
                EndContext();
                BeginContext(712, 41, false);
#line 20 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(753, 90, true);
                WriteLiteral("\r\n                </th>\r\n                <th onclick=\"sortTable(3)\">\r\n                    ");
                EndContext();
                BeginContext(844, 44, false);
#line 23 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
                EndContext();
                BeginContext(888, 90, true);
                WriteLiteral("\r\n                </th>\r\n                <th onclick=\"sortTable(4)\">\r\n                    ");
                EndContext();
                BeginContext(979, 42, false);
#line 26 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayNameFor(model => model.Choice));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 90, true);
                WriteLiteral("\r\n                </th>\r\n                <th onclick=\"sortTable(5)\">\r\n                    ");
                EndContext();
                BeginContext(1112, 45, false);
#line 29 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayNameFor(model => model.FileNames));

#line default
#line hidden
                EndContext();
                BeginContext(1157, 206, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Download link\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 40 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1420, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1481, 37, false);
#line 44 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1518, 69, true);
                WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1588, 39, false);
#line 48 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1627, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1695, 40, false);
#line 51 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1735, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1803, 43, false);
#line 54 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comments));

#line default
#line hidden
                EndContext();
                BeginContext(1846, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1914, 41, false);
#line 57 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Choice));

#line default
#line hidden
                EndContext();
                BeginContext(1955, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2023, 44, false);
#line 60 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.FileNames));

#line default
#line hidden
                EndContext();
                BeginContext(2067, 47, true);
                WriteLiteral("\r\n                </td>\r\n                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2114, "\"", 2203, 2);
#line 62 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
WriteAttributeValue("", 2121, Url.Action("DownloadDiffFiles", "user", new {FileToDownload =   item.FileNames}), 2121, 81, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2202, "", 2203, 1, true);
                EndWriteAttribute();
                BeginContext(2204, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2206, 14, false);
#line 62 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
                                                                                                            Write(item.FileNames);

#line default
#line hidden
                EndContext();
                BeginContext(2220, 53, true);
                WriteLiteral("</a></td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2274, 57, false);
#line 64 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.ActionLink("Edit", "EditUser", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(2331, 24, true);
                WriteLiteral(" |\r\n                    ");
                EndContext();
                BeginContext(2356, 66, false);
#line 65 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
               Write(Html.ActionLink("Delete User", "DeleteUser", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(2422, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 68 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\ShowData.cshtml"
            }

#line default
#line hidden
                BeginContext(2481, 2759, true);
                WriteLiteral(@"        </tbody>
    </table>

    <script>
        function sortTable(n) {
            var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
            table = document.getElementById(""myTable"");
            switching = true;
            //Set the sorting direction to ascending:
            dir = ""asc"";
            /*Make a loop that will continue until
            no switching has been done:*/
            while (switching) {
                //start by saying: no switching is done:
                switching = false;
                rows = table.rows;
                /*Loop through all table rows (except the
                first, which contains table headers):*/
                for (i = 1; i < (rows.length - 1); i++) {
                    //start by saying there should be no switching:
                    shouldSwitch = false;
                    /*Get the two elements you want to compare,
                    one from current row and one from the next:*/
           ");
                WriteLiteral(@"         x = rows[i].getElementsByTagName(""TD"")[n];
                    y = rows[i + 1].getElementsByTagName(""TD"")[n];
                    /*check if the two rows should switch place,
                    based on the direction, asc or desc:*/
                    if (dir == ""asc"") {
                        if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                            //if so, mark as a switch and break the loop:
                            shouldSwitch = true;
                            break;
                        }
                    } else if (dir == ""desc"") {
                        if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                            //if so, mark as a switch and break the loop:
                            shouldSwitch = true;
                            break;
                        }
                    }
                }
                if (shouldSwitch) {
                    /*If a switch has been marked, make the ");
                WriteLiteral(@"switch
                    and mark that a switch has been done:*/
                    rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                    switching = true;
                    //Each time a switch is done, increase this count by 1:
                    switchcount++;
                } else {
                    /*If no switching has been done AND the direction is ""asc"",
                    set the direction to ""desc"" and run the while loop again.*/
                    if (switchcount == 0 && dir == ""asc"") {
                        dir = ""desc"";
                        switching = true;
                    }
                }
            }
        }
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mvc_app.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

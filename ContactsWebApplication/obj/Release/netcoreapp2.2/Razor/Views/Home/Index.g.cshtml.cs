#pragma checksum "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39922bee566ce3f4378d01508e6d7c77fef1eb0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\_ViewImports.cshtml"
using ContactsWebApplication;

#line default
#line hidden
#line 2 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\_ViewImports.cshtml"
using ContactsWebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39922bee566ce3f4378d01508e6d7c77fef1eb0f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca7f846ea655de39931f0722fdf10b2529578d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(75, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(87, 35, false);
#line 7 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(122, 85, true);
            WriteLiteral("\r\n</p>\r\n\r\n<style>\r\n    .delete-section {\r\n        display: inline;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(208, 23, false);
#line 15 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(231, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(293, 37, false);
#line 19 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(374, 36, false);
#line 22 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(410, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(454, 33, false);
#line 25 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(531, 39, false);
#line 28 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(570, 66, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 33 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
     foreach (var contact in Model)
    {

#line default
#line hidden
            BeginContext(680, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(729, 39, false);
#line 37 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(x => contact.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(768, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(824, 38, false);
#line 40 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(x => contact.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(862, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(918, 35, false);
#line 43 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(x => contact.Email));

#line default
#line hidden
            EndContext();
            BeginContext(953, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1009, 41, false);
#line 46 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(x => contact.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1106, 62, false);
#line 49 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = contact.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 123, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div class=\"delete-section\">\r\n                <a class=\"delete-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1291, "\"", 1342, 1);
#line 53 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 1298, Url.Action("Delete", new {id = contact.Id}), 1298, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1343, 110, true);
            WriteLiteral(">Delete</a>\r\n                <div class=\"btn btn-primary delete-confirm\" style=\"display:none\" data-delete-id=\"");
            EndContext();
            BeginContext(1454, 10, false);
#line 54 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
                                                                                            Write(contact.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 96, true);
            WriteLiteral("\">Confirm Delete</div>\r\n                </div>\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 59 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1567, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1596, 584, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(function () {
        $(""a.delete-link"").click(function () {
            var deleteLink = $(this);
            deleteLink.hide();
            var confirmButton = deleteLink.siblings("".delete-confirm"");
            confirmButton.show();

            var cancelDelete =  function () {
                removeEvents();
                showDeleteLink();
            };

            var deleteItem = function () {
                removeEvents();
                confirmButton.hide();
                $.post(
                    '");
                EndContext();
                BeginContext(2181, 20, false);
#line 80 "D:\Swati\POCs\Contacts\ContactsWebApplication\ContactsWebApplication\Views\Home\Index.cshtml"
                Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(2201, 1494, true);
                WriteLiteral(@"',
                    AddAntiForgeryToken({ id: confirmButton.attr('data-delete-id') }))
                   .done(function () {
                       var parentRow = deleteLink.parents(""tr:first"");
                       parentRow.fadeOut('fast', function () {
                           parentRow.remove();
                       });
                   }).fail(function (data) {
                       alert(""error"");
                   });
                return false;
            };

            var removeEvents = function () {
                confirmButton.off(""click"", deleteItem);
                $(document).on(""click"", cancelDelete);
                $(document).off(""keypress"", onKeyPress);
            };

            var showDeleteLink = function () {
                confirmButton.hide();
                deleteLink.show();
            };

            var onKeyPress = function (e) {
                //Cancel if escape key pressed
                if (e.which == 27) {
              ");
                WriteLiteral(@"      cancelDelete();
                }
            };

            confirmButton.on(""click"", deleteItem);
            $(document).on(""click"", cancelDelete);
            $(document).on(""keypress"", onKeyPress);

            return false;
        });

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
    });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3698, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

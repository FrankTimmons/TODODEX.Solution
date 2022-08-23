#pragma checksum "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e25fb95ef20e335b8a1e0ef85923b4a9ce98263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDos_Index), @"mvc.1.0.view", @"/Views/ToDos/Index.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/_ViewImports.cshtml"
using ToDoClient.Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
using ToDoClient.Solution.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e25fb95ef20e335b8a1e0ef85923b4a9ce98263", @"/Views/ToDos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b342d05df0d6b78ae0edad84545d664f9b9665", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ToDos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>To-Dos</h2>\n<br>\n");
#nullable restore
#line 7 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
   ApplicationUser user = await userManager.GetUserAsync(@User); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
 if(user.ToDos == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>\"What are you waiting for? add some todos :]\"</h3>\n");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
}
else
{ 
  var result = user.ToDos.Split(":");
  int[] ints = Array.ConvertAll(result, r => Int32.TryParse(r, out var x) ? x : -1);

  for(int i=1; i<ints.Length; i++){
    int id = (ints[i]);
    ToDo todo = ToDo.GetDetails(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"box todo-box\">\n      <div class=\"row\">\n        <div class=\"col-3\">\n          <img");
            BeginWriteAttribute("src", " src=", 620, "", 636, 1);
#nullable restore
#line 22 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
WriteAttributeValue("", 625, todo.Image, 625, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-box\" />\n        </div>\n        <div class=\"col-9\">\n          <table class=\"table\">\n            <tr>\n              <th>");
#nullable restore
#line 27 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
             Write(todo.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &emsp;</th>\n              <th style=\"text-align:right\">PP: ");
#nullable restore
#line 28 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
                                          Write(todo.PP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            </tr>\n            <tr colspan=\"2\">\n              <td colspan=\"2\">Category: ");
#nullable restore
#line 31 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
                                   Write(todo.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr colspan=\"2\">\n              <td colspan=\"2\">");
#nullable restore
#line 34 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
                         Write(todo.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n          </table>\n        </div>\n        <br>\n      </div>\n    </div>\n    <br>\n");
#nullable restore
#line 42 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
  }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\'", 1165, "\'", 1190, 1);
#nullable restore
#line 44 "/Users/difalcoa/Desktop/TODODEX.Solution/ToDoClient.Solution/Views/ToDos/Index.cshtml"
WriteAttributeValue("", 1172, Url.Action("Add"), 1172, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Add a ToDo to your roster!</button></a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

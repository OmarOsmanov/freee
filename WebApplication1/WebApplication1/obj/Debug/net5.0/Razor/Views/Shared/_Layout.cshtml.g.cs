#pragma checksum "C:\Users\Hp-pavilion\Desktop\cars\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe9eb18d26658029801ad92bcef1fb882cd8278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Hp-pavilion\Desktop\cars\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp-pavilion\Desktop\cars\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe9eb18d26658029801ad92bcef1fb882cd8278", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe9eb18d26658029801ad92bcef1fb882cd82783316", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""icon"" type=""image/x-icon"" href=""assets/favicon.ico"" />
    <script src=""https://use.fontawesome.com/releases/v5.15.4/js/all.js"" crossorigin=""anonymous""></script>
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic"" rel=""stylesheet""
          type=""text/css"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css""
          integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""ano");
                WriteLiteral("nymous\" />\r\n\r\n    <link rel=\"stylesheet\" href=\"sytle.css\">\r\n\r\n    <title>Document</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe9eb18d26658029801ad92bcef1fb882cd82785495", async() => {
                WriteLiteral(@"


    <nav class=""navbar navbar-expand-lg"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#"">Start Bootstrap</a>
            <button class=""navbar-toggler navbar_btn"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNav""
                    aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""><i class=""fas fa-bars""></i></span>
            </button>

            <div class=""collapse navbar-collapse "" id=""navbarNav"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link active rounded"" href=""#"">Portfolio</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link rounded"" href=""#"">About</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link rounded"" href=""#"">Contact</a>
                    ");
                WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n    ");
#nullable restore
#line 50 "C:\Users\Hp-pavilion\Desktop\cars\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

    <footer class=""footer text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 mb-5 mb-lg-0"">
                    <h4 class=""text-uppercase mb-4"">Location</h4>
                    <p class=""lead mb-0"">
                        2215 John Daniel Drive
                        <br />
                        Clark, MO 65243
                    </p>
                </div>
                <div class=""col-lg-4 mb-5 mb-lg-0"">
                    <h4 class=""text-uppercase mb-4"">Around the Web</h4>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-facebook-f""></i></a>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-twitter""></i></a>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-linkedin-in""></i></a>
                    <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i cl");
                WriteLiteral(@"ass=""fab fa-fw fa-dribbble""></i></a>
                </div>
                <div class=""col-lg-4"">
                    <h4 class=""text-uppercase mb-4"">About Freelancer</h4>
                    <p class=""lead mb-0"">
                        Freelance is a free to use, MIT licensed Bootstrap theme created by
                        <a href=""http://startbootstrap.com"">Start Bootstrap</a>
                    </p>
                </div>
            </div>
        </div>
    </footer>
    <!-- Copyright Section-->
    <div class=""copyright py-4 text-center text-white"">
        <div class=""container""><small>Copyright  Your Website 2021</small></div>
    </div>


 

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM""
            crossorigin=""anonymous""></script>
    <script");
                BeginWriteAttribute("src", " src=\"", 4257, "\"", 4336, 3);
                WriteAttributeValue("", 4263, "https://cdn.jsdelivr.net/npm/", 4263, 29, true);
#nullable restore
#line 91 "C:\Users\Hp-pavilion\Desktop\cars\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4292, popper.js, 4292, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4302, "/core@2.9.2/dist/umd/popper.min.js", 4302, 34, true);
                EndWriteAttribute();
                WriteLiteral(@"
            integrity=""sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js""
            integrity=""sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF""
            crossorigin=""anonymous""></script>

    <script src=""script.js""></script>
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

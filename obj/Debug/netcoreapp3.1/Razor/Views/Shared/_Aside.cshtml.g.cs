#pragma checksum "C:\Users\Usuario\source\repos\WebApplication2\Views\Shared\_Aside.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "799df4b5e6b66bc34344e1a2eb0fdfe8715f99f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Aside), @"mvc.1.0.view", @"/Views/Shared/_Aside.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Aside.cshtml", typeof(AspNetCore.Views_Shared__Aside))]
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
#line 1 "C:\Users\Usuario\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Usuario\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 3 "C:\Users\Usuario\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799df4b5e6b66bc34344e1a2eb0fdfe8715f99f3", @"/Views/Shared/_Aside.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efaf419c376776692f4d03e2a260fdad840af22", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efaf419c376776692f4d03e2a260fdad840af22", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Aside : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 22779, true);
            WriteLiteral(@"<aside class=""main-sidebar sidebar-dark-primary elevation-4"">
    <!-- Brand Logo -->
    <a href=""../../index3.html"" class=""brand-link"">
        <img src=""../../dist/img/AdminLTELogo.png""
             alt=""AdminLTE Logo""
             class=""brand-image img-circle elevation-3""
             style=""opacity: .8"">
        <span class=""brand-text font-weight-light"">AdminLTE 3</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"">
        <!-- Sidebar user panel (optional) -->
        <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
            <div class=""image"">
                <img src=""../../dist/img/user2-160x160.jpg"" class=""img-circle elevation-2"" alt=""User Image"">
            </div>
            <div class=""info"">
                <a href=""#"" class=""d-block"">Alexander Pierce</a>
            </div>
        </div>

        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=");
            WriteLiteral(@"""false"">
                <!-- Add icons to the links using the .nav-icon class
                 with font-awesome or any other icon font library -->
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-tachometer-alt""></i>
                        <p>
                            Dashboard
                            <i class=""right fas fa-angle-left""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../../index.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Dashboard v1</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../../index2.html"" class=""nav-link"">
                    ");
            WriteLiteral(@"            <i class=""far fa-circle nav-icon""></i>
                                <p>Dashboard v2</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../../index3.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Dashboard v3</p>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item"">
                    <a href=""../widgets.html"" class=""nav-link"">
                        <i class=""nav-icon fas fa-th""></i>
                        <p>
                            Widgets
                            <span class=""right badge badge-danger"">New</span>
                        </p>
                    </a>
                </li>
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
 ");
            WriteLiteral(@"                       <i class=""nav-icon fas fa-copy""></i>
                        <p>
                            Layout Options
                            <i class=""fas fa-angle-left right""></i>
                            <span class=""badge badge-info right"">6</span>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../layout/top-nav.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Top Navigation</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../layout/top-nav-sidebar.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Top Navigation + Sidebar</p>
                            </a>
              ");
            WriteLiteral(@"          </li>
                        <li class=""nav-item"">
                            <a href=""../layout/boxed.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Boxed</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../layout/fixed-sidebar.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Fixed Sidebar</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../layout/fixed-topnav.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Fixed Navbar</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
      ");
            WriteLiteral(@"                      <a href=""../layout/fixed-footer.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Fixed Footer</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../layout/collapsed-sidebar.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Collapsed Sidebar</p>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item has-treeview menu-open"">
                    <a href=""#"" class=""nav-link active"">
                        <i class=""nav-icon fas fa-chart-pie""></i>
                        <p>
                            Charts
                            <i class=""right fas fa-angle-left""></i>
                        </p>
                    </");
            WriteLiteral(@"a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""chartjs.html"" class=""nav-link active"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>ChartJS</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""flot.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Flot</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""inline.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Inline</p>
                            </a>
                        </li>
                    </ul>
                </li>
              ");
            WriteLiteral(@"  <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-tree""></i>
                        <p>
                            UI Elements
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../UI/general.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>General</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../UI/icons.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Icons</p>
                            </a>
                        </li>
               ");
            WriteLiteral(@"         <li class=""nav-item"">
                            <a href=""../UI/buttons.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Buttons</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../UI/sliders.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Sliders</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../UI/modals.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Modals & Alerts</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../UI/navbar.html"" class");
            WriteLiteral(@"=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Navbar & Tabs</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../UI/timeline.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Timeline</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../UI/ribbons.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Ribbons</p>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas f");
            WriteLiteral(@"a-edit""></i>
                        <p>
                            Forms
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../forms/general.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>General Elements</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../forms/advanced.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Advanced Elements</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../forms/editors.html"" class=""nav-link"">
  ");
            WriteLiteral(@"                              <i class=""far fa-circle nav-icon""></i>
                                <p>Editors</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../forms/validation.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Validation</p>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-table""></i>
                        <p>
                            Tables
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                    ");
            WriteLiteral(@"        <a href=""../tables/simple.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Simple Tables</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../tables/data.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>DataTables</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../tables/jsgrid.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>jsGrid</p>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-header"">EXAMPLES</li>
                <li class=""nav-item"">
         ");
            WriteLiteral(@"           <a href=""../calendar.html"" class=""nav-link"">
                        <i class=""nav-icon far fa-calendar-alt""></i>
                        <p>
                            Calendar
                            <span class=""badge badge-info right"">2</span>
                        </p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../gallery.html"" class=""nav-link"">
                        <i class=""nav-icon far fa-image""></i>
                        <p>
                            Gallery
                        </p>
                    </a>
                </li>
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon far fa-envelope""></i>
                        <p>
                            Mailbox
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
    ");
            WriteLiteral(@"                <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../mailbox/mailbox.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Inbox</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../mailbox/compose.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Compose</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../mailbox/read-mail.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Read</p>
                            </a>
                        </li>
                    </ul>
              ");
            WriteLiteral(@"  </li>
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon fas fa-book""></i>
                        <p>
                            Pages
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../examples/invoice.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Invoice</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/profile.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Profile</p>
                            </a>
             ");
            WriteLiteral(@"           </li>
                        <li class=""nav-item"">
                            <a href=""../examples/e-commerce.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>E-commerce</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/projects.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Projects</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/project-add.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Project Add</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
 ");
            WriteLiteral(@"                           <a href=""../examples/project-edit.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Project Edit</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/project-detail.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Project Detail</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/contacts.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Contacts</p>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item has-treeview"">
  ");
            WriteLiteral(@"                  <a href=""#"" class=""nav-link"">
                        <i class=""nav-icon far fa-plus-square""></i>
                        <p>
                            Extras
                            <i class=""fas fa-angle-left right""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""../examples/login.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Login</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/register.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Register</p>
                            </a>
                        </li>
                        <li class=""nav-");
            WriteLiteral(@"item"">
                            <a href=""../examples/forgot-password.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Forgot Password</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/recover-password.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Recover Password</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/lockscreen.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Lockscreen</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a hre");
            WriteLiteral(@"f=""../examples/legacy-user-menu.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Legacy User Menu</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/language-menu.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Language Menu</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/404.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Error 404</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/500.html"" class=""nav-link"">
          ");
            WriteLiteral(@"                      <i class=""far fa-circle nav-icon""></i>
                                <p>Error 500</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/pace.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Pace</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../examples/blank.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Blank Page</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""../../starter.html"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                             ");
            WriteLiteral("   <p>Starter Page</p>\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n        <!-- /.sidebar-menu -->\r\n    </div>\r\n    <!-- /.sidebar -->\r\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

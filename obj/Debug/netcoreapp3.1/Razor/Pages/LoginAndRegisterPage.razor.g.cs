#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a24e0de9b923b06dc1c81992628faf628a4e4a"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment2_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using DNP_Assignment2_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using DNP_Assignment2_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
using DNP_Assignment2_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
using DNP_Assignment2_Client.Models.Unit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class LoginAndRegisterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn-primary");
            __builder.AddAttribute(5, "style", "float: right;position: relative;width:auto;right:15%;height: 40px;border-radius: 5px");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                                                       ChangeState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, 
#nullable restore
#line 10 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                                                                     otherTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "margin: auto");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "h1");
            __builder.AddAttribute(17, "style", "text-align: center");
            __builder.AddContent(18, 
#nullable restore
#line 14 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                        title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "background: gray;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(22, "\r\n            <span class=\"oi oi-person\" style=\"float: left;width:50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n            ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "placeholder", "User Name");
            __builder.AddAttribute(26, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                            newUser.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.UserName = __value, newUser.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "background: gray;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(33, "\r\n            <span class=\"oi oi-key\" style=\"float: left;width:50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n            ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "password");
            __builder.AddAttribute(36, "placeholder", "Password");
            __builder.AddAttribute(37, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                               newUser.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.Password = __value, newUser.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 23 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
         if (title.Equals("Register"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
             if (newUser.Password==confirmPassword&&!string.IsNullOrEmpty(confirmPassword))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "background: green;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(45, "\r\n                    <span class=\"oi oi-circle-check\" style=\"float: left;width: 50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "password");
            __builder.AddAttribute(48, "placeholder", "Confirm Password");
            __builder.AddAttribute(49, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                                               confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 31 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "background: red;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(57, "\r\n                    <span class=\"oi oi-circle-x\" style=\"float: left;width: 50px;height: 50px;color: white;font-size: xx-large;line-height:50px;text-align: center\"></span>\r\n                    ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "password");
            __builder.AddAttribute(60, "placeholder", "Confirm Password");
            __builder.AddAttribute(61, "style", "float: left;width:250px;height: 50px");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                                               confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 38 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "style", "margin: 0px auto;width: 300px;height: auto");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "p");
            __builder.AddAttribute(71, "style", "color: red");
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.AddContent(73, 
#nullable restore
#line 42 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                 error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 45 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
         switch (title)
        {
            case "Login":

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "style", "background: #1b6ec2;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "class", "btn btn-primary");
            __builder.AddAttribute(83, "style", "width: 100%;height: 100%;border-radius: 0px");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                                  Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 51 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                break;
            case "Register":

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "style", "background: #1b6ec2;margin: 40px auto;width: 300px;height: 50px");
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-primary");
            __builder.AddAttribute(94, "style", "width: 100%;height: 100%;border-radius: 0px");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                                                                                                                  Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, "Confirm");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 56 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
                break;
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\LoginAndRegisterPage.razor"
       
    private string title;
    private string otherTitle;
    private string error;
    private User newUser;
    private string confirmPassword;

    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            NavigationManager.NavigateTo("AllFamily");
        }
        else
        {
            newUser = new User
            {
                UserName = null, 
                Password = null
            };
            title = "Login";
            otherTitle = "Register";
            confirmPassword = null;
            error = null;
        }
        
    }

    private void ChangeState()
    {
        if (title.Equals("Login"))
        {
            title = "Register";
            otherTitle = "Login";
        }
        else if (title.Equals("Register"))
        {
            title = "Login";
            otherTitle = "Register";
        }
        newUser = new User
        {
            UserName = null,
            Password = null
        };
        confirmPassword = null;
        error = null;
    }

    private async Task Login()
    {
        var result = await ModelManager.LoginAsync(newUser);
        if (result)
        {
            MainLayout.Login();
            UserInformation.SetInfo(newUser.UserName);
            NavigationManager.NavigateTo("AllFamily");
        }
        else
        {
            error = "Wrong user name or password.";
        }
    }

    private async Task Register()
    {
        if (!string.IsNullOrEmpty(newUser.Password)&&!string.IsNullOrWhiteSpace(newUser.UserName)&&!string.IsNullOrEmpty(newUser.UserName))
        {
            if (newUser.Password==confirmPassword)
            {
                error = await ModelManager.AddUserAsync(newUser);
                if (string.IsNullOrEmpty(error))
                {
                    MainLayout.Login();
                    UserInformation.SetInfo(newUser.UserName);
                    NavigationManager.NavigateTo("AllFamily");
                }
            }
            else
            {
                error = "Please write a correct confirm password.";
            }
        }
        else
        {
            error = "Please write a username and password.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df6ca093e1be51fd055b35cea88dc3a945ea197"
// <auto-generated/>
#pragma warning disable 1591
namespace MySpace.Pages
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using MySpace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using MySpace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class Temp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\r\n    .suggestion-container {\r\n        position: relative;\r\n    }\r\n\r\n    .tagsinput, .tagsinput * {\r\n        box-sizing: border-box\r\n    }\r\n\r\n    .tagsinput {\r\n        display: -webkit-box;\r\n        display: -webkit-flex;\r\n        display: -ms-flexbox;\r\n        display: flex;\r\n        -webkit-flex-wrap: wrap;\r\n        -ms-flex-wrap: wrap;\r\n        flex-wrap: wrap;\r\n        background: #fff;\r\n        font-size: 14px;\r\n        line-height: 20px;\r\n        color: #556270;\r\n        padding: 5px 5px 0;\r\n        border: 1px solid #ccc;\r\n        border-radius: .250em;\r\n        width:100%;\r\n    }\r\n\r\n        .tagsinput.focus {\r\n            border-color: #333;\r\n        }\r\n\r\n        .tagsinput .tag {\r\n            position: relative;\r\n            background: #ADD8E6;\r\n            display: block;\r\n            max-width: 100%;\r\n            word-wrap: break-word;\r\n            color: #0000FF;\r\n            padding: 5px 30px 5px 5px;\r\n            border-radius: 2px;\r\n            margin: 0 5px 5px 0\r\n        }\r\n\r\n            .tagsinput .tag .tag-remove {\r\n                position: absolute;\r\n                background: 0 0;\r\n                display: block;\r\n                width: 30px;\r\n                height: 30px;\r\n                top: 0;\r\n                right: 0;\r\n                cursor: pointer;\r\n                text-decoration: none;\r\n                text-align: center;\r\n                color: #ff6b6b;\r\n                line-height: 30px;\r\n                padding: 0;\r\n                border: 0\r\n            }\r\n\r\n                .tagsinput .tag .tag-remove:after, .tagsinput .tag .tag-remove:before {\r\n                    background: #0000FF;\r\n                    position: absolute;\r\n                    display: block;\r\n                    width: 10px;\r\n                    height: 2px;\r\n                    top: 14px;\r\n                    left: 10px;\r\n                    content: \'\'\r\n                }\r\n\r\n                .tagsinput .tag .tag-remove:before {\r\n                    -webkit-transform: rotateZ(45deg);\r\n                    transform: rotateZ(45deg)\r\n                }\r\n\r\n                .tagsinput .tag .tag-remove:after {\r\n                    -webkit-transform: rotateZ(-45deg);\r\n                    transform: rotateZ(-45deg)\r\n                }\r\n\r\n        .tagsinput div {\r\n            -webkit-box-flex: 1;\r\n            -webkit-flex-grow: 1;\r\n            -ms-flex-positive: 1;\r\n            flex-grow: 1\r\n        }\r\n\r\n            .tagsinput div input {\r\n                background: 0 0;\r\n                display: block;\r\n                width: 100%;\r\n                font-size: 14px;\r\n                line-height: 20px;\r\n                padding: 5px;\r\n                border: 0;\r\n                margin: 0 5px 5px 0\r\n            }\r\n\r\n                .tagsinput div input:hover {\r\n                    border: 1px solid #333;\r\n                }\r\n                    .tagsinput div input:focus {\r\n                    color: #495057;\r\n                    background-color: #fff;\r\n                    border-color: #333;\r\n                    outline: 0;\r\n                }\r\n\r\n                .tagsinput div input.error {\r\n                    color: #ff6b6b\r\n                }\r\n\r\n                .tagsinput div input::-ms-clear {\r\n                    display: none\r\n                }\r\n\r\n                .tagsinput div input::-webkit-input-placeholder {\r\n                    color: #ccc;\r\n                    opacity: 1\r\n                }\r\n\r\n                .tagsinput div input:-moz-placeholder {\r\n                    color: #ccc;\r\n                    opacity: 1\r\n                }\r\n\r\n                .tagsinput div input::-moz-placeholder {\r\n                    color: #ccc;\r\n                    opacity: 1\r\n                }\r\n\r\n                .tagsinput div input:-ms-input-placeholder {\r\n                    color: #ccc;\r\n                    opacity: 1\r\n                }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "suggestion-container ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", 
#nullable restore
#line 146 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
               $"{Id}_tagsinput"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "tagsinput");
#nullable restore
#line 148 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
         if (Tags != null && Tags.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
             foreach (var tag in Tags)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "tag");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "tag-text");
            __builder.AddContent(10, 
#nullable restore
#line 153 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                                            tag

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "tag-remove");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 154 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                                                       () => DeleteTag(tag)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 156 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id", 
#nullable restore
#line 159 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                   $"{Id}_addTag"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", 
#nullable restore
#line 160 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                          IsContainSpecialCharacter ? "tag-tooltip" : string.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "id", 
#nullable restore
#line 161 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                             $"{Id}_tag"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "tag-input");
            __builder.AddAttribute(22, "placeholder", "Add next");
            __builder.AddAttribute(23, "autocomplete", "off");
            __builder.AddAttribute(24, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 167 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                                 AddTags

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 165 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                                    Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Value = __value, Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 169 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                 if (IsContainSpecialCharacter)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<div class=\"error-right d-inline-flex p-2\"><i class=\"oi oi-warning text-warning p-1\"></i>\r\n                        <p class=\"text-left m-0 p-1\">Invalid Email Address</p>\r\n                        <i></i></div>");
#nullable restore
#line 176 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 182 "C:\Users\Shiv\OneDrive\Desktop\MySpace\MySpace\MySpace\Pages\Temp.razor"
      

    private Guid Id => Guid.NewGuid();
    protected string Value { get; set; }
    protected bool MenuVisibility { get; set; }
    protected bool IsContainSpecialCharacter { get; set; }
    protected List<string> Tags { get; set; } = new List<string>();

    public bool IsValidEmail(string email)
    {
        if (email.Trim().EndsWith("."))
        {
            return false; // suggested by @TK-421
        }
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }


    protected void AddTags(KeyboardEventArgs eventArgs)
    {
        IsContainSpecialCharacter = false;

        if (!String.IsNullOrEmpty(Value))
        {
            if (eventArgs.Key.Equals("Enter"))
            {
                if (IsValidEmail(Value))
                {
                    if (!Tags.Exists(t => t.Equals(Value, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        Tags.Add(Value);
                    }

                    Value = string.Empty;
                }
                else
                {
                    IsContainSpecialCharacter = true;
                }
            }
        }
    }

    protected void DeleteTag(string value)
    {
        if (String.IsNullOrEmpty(value)) return;

        var tag = Tags.FirstOrDefault(t => t == value);
        if (tag == null) return;

        Tags.Remove(tag);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

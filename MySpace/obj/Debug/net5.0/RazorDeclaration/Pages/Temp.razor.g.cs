// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MySpace.Pages
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using MySpace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using MySpace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\Pages\Temp.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/temp")]
    public partial class Temp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace\MySpace\MySpace\Pages\Temp.razor"
       

    private Guid Id => Guid.NewGuid();
    protected string Value { get; set; }
    protected bool MenuVisibility { get; set; }
    protected bool IsContainSpecialCharacter { get; set; }
    protected List<string> Tags { get; set; } = new List<string>();

    protected void AddTags(KeyboardEventArgs eventArgs)
    {
        IsContainSpecialCharacter = false;

        if (!String.IsNullOrEmpty(Value))
        {
            if (eventArgs.Key.Equals("Enter"))
            {
                var regex = new Regex(@"[^a-zA-Z0-9\s]");
                if (!regex.IsMatch(Value))
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

#pragma checksum "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\AddUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc29babb704535a8377369b2dc44d312bb06797"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\AddUser.razor"
using DNP1_A1.Login;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddUser")]
    public partial class AddUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\AddUser.razor"
       
    private User userNew = new User();
    private List<User> users;

    private void addNew()
    {
        userService.AddUser(userNew.username, userNew.password, userNew.Role);
        NavigationManager.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        users = userService.getUsers();
    }

    private void RemoveAdult(string username)
    {
        User toRemove = users.First(a => a.username == username);
        userService.RemoveUser(toRemove);
        users.Remove(toRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser userService { get; set; }
    }
}
#pragma warning restore 1591

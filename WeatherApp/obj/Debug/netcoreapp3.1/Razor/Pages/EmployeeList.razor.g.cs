#pragma checksum "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "691ea8a40b1abfcb8c1fcbc6f8f8644140ac1d3c"
// <auto-generated/>
#pragma warning disable 1591
namespace WeatherApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using WeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\_Imports.razor"
using WeatherApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : BaseEmployeeList
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeeList</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<thead>
        <tr>
            <th>Id</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Date Of Birth</th>
            <th>Gender</th>
            <th>Departament</th>
            <th></th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 21 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
         foreach (var Employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 24 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 28 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.DateOfBirth.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 29 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 30 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
                 Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 32 "C:\Users\Azama\Desktop\code\dotnet\WeatherApp3\WeatherApp\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

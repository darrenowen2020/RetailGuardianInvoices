#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "226cf875db79b1b1ff0f625530ca8a9cefa14965"
// <auto-generated/>
#pragma warning disable 1591
namespace RetailGInvoices.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using RetailGInvoices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using RetailGInvoices.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using RetailGInvoices.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
 if (companies == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t");
            __builder.AddMarkupContent(1, "<p>Loadng Companies...</p>\r\n");
#nullable restore
#line 11 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\t");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn-group-sm");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                                           c => companyPage()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Maint");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 16 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
     if (companies.Length == 0)
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "\t\t");
            __builder.AddMarkupContent(9, "<p>No Companies Have Been Comfigured</p>\r\n");
#nullable restore
#line 19 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
	}
	else
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\t");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table-bordered");
            __builder.AddAttribute(13, "style", "width:600px");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 23 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
         foreach (var company in companies)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "\t\t\t");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n\t\t\t\t");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 26 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                     company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\t\t\t\t");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\r\n\t\t\t\t\t");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn-info");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                                                       c => invoicePage(company)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "disabled", 
#nullable restore
#line 28 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                                                                                              companyPeriodCount(company) == 0

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, "Invoice");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\t\t\t\t");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n\t\t\t\t\t");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn-info");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                                                       c => expensePage(company)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "disabled", 
#nullable restore
#line 31 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                                                                                              companyPeriodCount(company) == 0

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, "Expense");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 33 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
                 if (companyPeriodCount(company) == 0)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\t\t\t\t\t");
            __builder.AddMarkupContent(40, "<td>\r\n\t\t\t\t\t\t<p class=\"alert-danger\">No Periods Configured</p>\r\n\t\t\t\t\t</td>\r\n");
#nullable restore
#line 38 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 40 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"

		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 44 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
         
	}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor"
 
	Company[] companies;
	Company companyObj;
	bool showInvoices = false;
	private PeriodCount[] periodCounts;

	protected override async Task OnInitializedAsync()
	{
		companies = await Http.GetJsonAsync<Company[]>("api/Companies");
		periodCounts = await Http.GetJsonAsync<PeriodCount[]>("api/PeriodCounts");
	}

	private void invoicePage(Company company)
	{
		AppData.CompanyId = company.Id;
		AppData.ComanyName = company.Name;
		NavManager.NavigateTo("/Invoices");

	}
	private void expensePage(Company company)
	{
		AppData.CompanyId = company.Id;
		AppData.ComanyName = company.Name;
		NavManager.NavigateTo("/Invoices");

	}

	private void companyPage()
	{
		NavManager.NavigateTo("/Companies");
	}

	private async Task companyHasPeriods(Company company)
	{
		Period[] periods = await Http.GetJsonAsync<Period[]>("api/Periods/Company/" + company.Id);
		if (periods == null)
		{

		}
	}

	private int companyPeriodCount(Company company)
	{
		int result = 0;

		PeriodCount periodCount = Array.Find(periodCounts, f => f.CompanyId == company.Id);
		if (periodCount != null)
		{
			result = periodCount.Count;
		}

		return result;
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

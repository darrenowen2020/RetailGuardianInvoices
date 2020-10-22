#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff7af17862ba4d0cba42ce47d6b32e2bcb40380"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 15 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Newtonsoft.Json;

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
		//periodCounts = await Http.GetJsonAsync<PeriodCount[]>("api/PeriodCounts");
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
		NavManager.NavigateTo("/Expenses");

	}

	private void companyPage()
	{
		NavManager.NavigateTo("/Companies");
	}

	private async Task<bool> companyPeriodCount(Company company)
	{
		bool result = false;

		PeriodCount periodCount = Array.Find(periodCounts, f => f.CompanyId == company.Id);
		if (periodCount != null)
		{
			result = true;
		}

		return result;
	}

	private bool PeriodMissing(int companyId)
	{
		bool missingPeriod = Task.Run(() => CompanyDoesntHavePeriodForToday(companyId)).Result;

		return missingPeriod;
	}

	private async Task<bool> CompanyDoesntHavePeriodForToday(int companyId)
	{
		bool periodExists = false;

		string todayYear = DateTime.Today.Year.ToString().Substring(2, 2);
		DateTime today = DateTime.Today;

		try
		{
			Period[] periods = await Http.GetJsonAsync<Period[]>($"api/Periods/Company/{companyId}/Year/{todayYear}");

			Period period = Array.Find<Period>(periods, f => DateTime.Compare(today, f.StartDate) >= 0 && DateTime.Compare(today, f.EndDate) <= 0);
			if (period != null)
			{
				periodExists = true;
			}
		}
		catch (Exception ex)
		{
			periodExists = false;
		}

		return !periodExists;
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

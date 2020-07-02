#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a057d47e39c014ff9d27fa53041a6678c7075e65"
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
#line 2 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Invoices")]
    public partial class Invoices : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
       
	private string siteSelected;
	private string supplierSelected;
	private DateTime invoiceDate = DateTime.Today;
	private string invoiceReference;
	private string description;
	private string category;
	private float grossAmount;
	private float vat;
	private float net;

	private Company[] companies;
	private Site[] sites;
	private Invoice[] invoices;

	Company companyObj = new Company();
	Invoice invoiceObj = new Invoice();
	Site siteObj = new Site();
	


	string ids = "0";
	bool showAddrow = false;

	bool loadFailed;

	protected override async Task OnInitializedAsync()
	{
		ids = "0";
		companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");
		sites = await Http.GetJsonAsync<Site[]>("api/Sites");
		invoiceObj.Date = DateTime.Today;
	}


	void AddNewCustomer()
	{
		ids = "0";
		showAddrow = true;
		companyObj = new Company();
	}
	// Add New Customer Details Method
	protected async Task AddCustomer()
	{
		if (ids == "0")

		{
			await Http.SendJsonAsync(HttpMethod.Post, "/api/Companies/", companyObj);
			companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");
		}
		else
		{
			await Http.SendJsonAsync(HttpMethod.Put, "/api/Companies/" + companyObj.Id, companyObj);
			companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");
		}

		showAddrow = false;
	}
	// Edit Method
	protected async Task EditCustomer(string CustomerID)
	{
		showAddrow = true;

		ids = "1";
		//try
		//{
		loadFailed = false;
		ids = CustomerID.ToString();
		companyObj = await Http.GetJsonAsync<Company>("/api/Companies/" + CustomerID);

		string s = companyObj.Id.ToString();

		showAddrow = true;

		//    }
		//catch (Exception ex)
		//{
		//    loadFailed = true;
		//    Logger.LogWarning(ex, "Failed to load product {ProductId}", CustomerID);
		//}
	}
	// Delte Method
	protected async Task DeleteCustomer(string CustomerID)
	{
		showAddrow = false;

		ids = CustomerID.ToString();
		await Http.DeleteAsync("/api/Companies/" + CustomerID);

		companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

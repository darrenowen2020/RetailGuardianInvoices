#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff85cb2ab8dd1ff11322ee092d8567e0afb2b2f"
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
            __builder.AddMarkupContent(0, "<h3>Invoices</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "\r\n\t\t");
            __builder.AddMarkupContent(6, @"<tr>
			<td>
				<label for=""Invoice Date"" class=""control-label"">Invoice Date</label>
			</td>
			<td>
				<label for=""Site"" class=""control-label"">Site</label>
			</td>
			<td>
				<label for=""Supplier"" class=""control-label"">Supplier</label>
			</td>
			<td>
				<label for=""Reference"" class=""control-label"">Reference</label>
			</td>
			<td>
				<label for=""Description"" class=""control-label"">Description</label>
			</td>
		</tr>
		");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n\t\t\t");
            __builder.OpenElement(9, "td");
            __builder.AddMarkupContent(10, "\r\n\t\t\t\t");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "date");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
                                                               invoiceDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoiceDate = __value, invoiceDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t\t");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
                                                               siteSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => siteSelected = __value, siteSelected));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n\t\t\t");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
                                                               supplierSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => supplierSelected = __value, supplierSelected));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\t\t\t");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n\t\t\t\t");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "text");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
                                                               invoiceReference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoiceReference = __value, invoiceReference));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\t\t\t");
            __builder.OpenElement(45, "td");
            __builder.AddMarkupContent(46, "\r\n\t\t\t\t");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
                                                               description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
       
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

	Company companyObj = new Company();

	string ids = "0";
	bool showAddrow = false;

	bool loadFailed;

	protected override async Task OnInitializedAsync()
	{
		ids = "0";
		companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");
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

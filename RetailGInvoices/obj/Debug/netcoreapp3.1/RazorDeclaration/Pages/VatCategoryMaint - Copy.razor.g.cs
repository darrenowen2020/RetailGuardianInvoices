#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\VatCategoryMaint - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbced7420bd420769230a7fbed70382bdee787c"
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
#line 1 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\VatCategoryMaint - Copy.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\VatCategoryMaint - Copy.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CompLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/VatcatMaint")]
    public partial class VatCategoryMaint___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\VatCategoryMaint - Copy.razor"
       
	private ITable<VatCategory> TableVatCategory;

	private VatCategory[] vatCategories;
	private VatRate[] vatRates;
	private VatCategory newVatCategory;

	private string editButtonText = "Edit";

	private bool hideAddFields = true;
	private bool disableAddButton = true;

	private List<VatCategory> categoryChangeQueue;

	private bool _disableEditButton;
	private bool disableEditButton
	{
		get
		{
			bool returnValue = true;
			if (vatCategories != null)
			{
				if (vatCategories.Length != 0)
				{
					returnValue = _disableEditButton;
				}
			}
			return returnValue;
		}

		set
		{
			_disableEditButton = value;
		}

	}

	protected override async Task OnInitializedAsync()
	{
		newVatCategory = new VatCategory();
		categoryChangeQueue = new List<VatCategory>();

		await GetVatRates();
		await GetVatCategories();
		disableAddButton = false;
	}

	public async Task Focus(string elementId)
	{
		await JSRuntime.InvokeVoidAsync("functionLibrary.focusElement", elementId);
	}

	public void addKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("vatcategory");
		}
	}

	public void categoryKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("vatrate");
		}
	}

	public void vatrateKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("submit");
		}
	}

	private async Task AddNewCategory(VatCategory vatCategory)
	{
		await PostNewCategory(vatCategory);
		await GetVatCategories();
	}

	private async Task PostNewCategory(VatCategory vatCategory)
	{
		try
		{
			await Http.PostJsonAsync($"api/VatCategories", vatCategory);
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine(ex.Message);
		}
	}

	private async Task ToggleAddFields()
	{
		hideAddFields = !hideAddFields;

		if (!hideAddFields)
		{
			newVatCategory = new VatCategory();
			await Focus("vatcategory");
		}
	}

	private async Task ToggleEdit()
	{
		TableVatCategory.ToggleEditMode();

		if (TableVatCategory.IsEditMode == true)
		{
			categoryChangeQueue = new List<VatCategory>();
			disableAddButton = true;
			editButtonText = "Save Changes";
		}
		else
		{
			disableAddButton = false;
			editButtonText = "Edit";
			await SaveChanges();
		}
	}

	private void AddChangeToQueue(VatCategory vatCategory)
	{
		categoryChangeQueue.Add(vatCategory);
	}

	private async Task SaveChanges()
	{
		try
		{
			foreach (VatCategory vatCategory in categoryChangeQueue)
			{
				string payload = JsonConvert.SerializeObject(vatCategory);

				StringContent content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");
				await Http.PutAsync($"api/VatCategories/{vatCategory.Id}", content);
			}
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine(ex.Message);
		}
	}

	private async Task DeleteCategory(VatCategory vatCategory)
	{
		try
		{
			HttpResponseMessage response = await Http.DeleteAsync($"api/VatCategories/{vatCategory.Id}");
			if (response.IsSuccessStatusCode)
			{
				await GetVatCategories();
				StateHasChanged();
			}
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine(ex.Message);
		}
	}
	private async Task GetVatCategories()
	{
		try
		{
			vatCategories = await Http.GetJsonAsync<VatCategory[]>("api/VatCategories");
		}
		catch (Exception ex)
		{
			DebugReport.ReportError(ex.Message);
		}

	}

	private async Task GetVatRates()
	{
		try
		{
			vatRates = await Http.GetJsonAsync<VatRate[]>("/api/VatRates");
		}
		catch (Exception ex)
		{
			DebugReport.ReportError(ex.Message);

		}
	}

	private VatRate GetVatRate(int vatRateId)
	{
		VatRate vatRate = new VatRate();
		if (vatRates != null)
		{
			vatRate = vatRates.Where(f => f.Id == vatRateId).FirstOrDefault();
		}

		return vatRate;
	}

	private string GetVatRateDesc(int vatRateId)
	{
		return vatRates.Where(f => f.Id == vatRateId).FirstOrDefault().Description;
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
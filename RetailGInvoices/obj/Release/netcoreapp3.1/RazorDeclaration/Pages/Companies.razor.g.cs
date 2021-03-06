#pragma checksum "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Companies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8c434813c2841a60f0ffc92f31b29a1bb10ed3"
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
#line 2 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using RetailGInvoices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using RetailGInvoices.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using RetailGInvoices.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Companies.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Companies.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CompMaintLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Companies")]
    public partial class Companies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Companies.razor"
       
	private ITable<Company> Table;
	private Company[] companies;
	private bool changedFlag = false;
	private bool showModal = false;
	private PeriodCount[] periodCounts;

	private int newcompanyNo;

	private Company companyObj = new Company();
	private bool hideButtons = true;
	private bool addTableActive = true;

	private int rowID;
	private Company activecompany;
	private string modalDeleteBody = "Are You Sure You Want To Delete company ";
	private string _areYouSure = "";
	public string areYouSure
	{
		get
		{
			return _areYouSure;
		}
		set
		{
			_areYouSure = value;
			if (value != "")
			{
				if (value == "YES")
				{
					Task tmp = DeleteRow();
				}
				showModal = false;
			}
		}
	}
	protected override async Task OnInitializedAsync()
	{
		companies = await Http.GetJsonAsync<Company[]>("/api/Companies");
		periodCounts = await Http.GetJsonAsync<PeriodCount[]>("api/PeriodCounts");
	}

	private void ToggleEdit()
	{
		Table.ToggleEditMode();
		if (Table.IsEditMode == false)
		{
			hideButtons = true;
			activecompany = null;
			addTableActive = true;
		}
		else
		{
			addTableActive = false;
			hideButtons = false;
		}
	}

	private void setChangedFlag()
	{
		changedFlag = true;
	}

	private void Addcompany()
	{
		Task tmp = Postcompany();
	}

	private async Task Postcompany()
	{
		await Http.PostJsonAsync<Company>("/api/Companies", companyObj);
		await refreshTable();

	}

	private async Task UpdateCompany(Company updateCompany)
	{
		await Http.SendJsonAsync(HttpMethod.Put, "/api/companies/" + updateCompany.Id, updateCompany);
	}

	private void submitChanges()
	{
		foreach (var company in companies)
		{
			Task tmpTask = UpdateCompany(company);

		}
		StateHasChanged();
		ToggleEdit();
	}

	private async Task refreshTable()
	{
		companies = await Http.GetJsonAsync<Company[]>("/api/Companies");
		this.StateHasChanged();
	}

	private void RowClick(Company companySelected)
	{
		rowID = companySelected.Id;
		activecompany = companySelected;

		if (Table.IsEditMode)
		{
			hideButtons = false;
			this.StateHasChanged();
		}
	}

	private void showDeleteModal()
	{
		modalDeleteBody = modalDeleteBody + activecompany.Name + "?";
		showModal = true;
		StateHasChanged();
	}

	private async Task DeleteRow()
	{
		await Http.DeleteAsync("/api/companies/" + activecompany.Id);
		companies = await Http.GetJsonAsync<Company[]>("/api/Companies");
		hideButtons = true;
		this.StateHasChanged();
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

	private void openPeriod(Company company)
	{
		AppData.CompanyId = company.Id;
		AppData.ComanyName = company.Name;

		NavManager.NavigateTo("/PeriodsMaint");
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RetailGInvoices.Services.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8c434813c2841a60f0ffc92f31b29a1bb10ed3"
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
#line 2 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
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
#nullable restore
#line 9 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
 if (showModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t");
            __builder.OpenComponent<RetailGInvoices.Components.AreYouSureGeneric>(1);
            __builder.AddAttribute(2, "showModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                   showModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "modalTextBody", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                        modalDeleteBody

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "modalTextHeader", "Delete");
            __builder.AddAttribute(5, "reply", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                            areYouSure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "replyChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => areYouSure = __value, areYouSure))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 12 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 14 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
 if (companies == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\t");
            __builder.AddMarkupContent(10, "<p>Loading the company data..</p>\r\n");
#nullable restore
#line 17 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "\t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                      companyObj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n\t\t");
                __builder2.OpenElement(16, "table");
                __builder2.AddAttribute(17, "class", "table-borderless");
                __builder2.AddAttribute(18, "style", "width: 400px;");
                __builder2.AddMarkupContent(19, "\r\n\t\t\t");
                __builder2.AddMarkupContent(20, "<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th style=\"width:300px\">Company Name</th>\r\n\t\t\t\t\t<th></th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\r\n\t\t\t");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "\r\n\t\t\t\t");
                __builder2.OpenElement(23, "td");
                __builder2.AddAttribute(24, "style", "width:60%");
                __builder2.AddMarkupContent(25, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                  companyObj.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyObj.Name = __value, companyObj.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\t\t\t\t");
                __builder2.OpenElement(31, "td");
                __builder2.AddAttribute(32, "style", "width:10%");
                __builder2.AddMarkupContent(33, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn btn-info");
                __builder2.AddAttribute(36, "title", "Add");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                         (x) => Addcompany()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "disabled", 
#nullable restore
#line 34 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                                           !addTableActive

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\t");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n\t");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(47, "title", "Toggle Edit Mode");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                               (x) => ToggleEdit()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Toggle Edit Mode");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.AddMarkupContent(51, "\t");
            __builder.OpenComponent<BlazorTable.Table<Company>>(52);
            __builder.AddAttribute(53, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Company>>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                      companies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                        20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "ColumnReorder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "SelectionType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.SelectionType>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                                                SelectionType.Single

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "RowClickAction", new System.Action<Company>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                                                                                      RowClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Column<Company>>(60);
                __builder2.AddAttribute(61, "Title", "Company Name");
                __builder2.AddAttribute(62, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Company, System.Object>>>(
#nullable restore
#line 43 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                  x => x.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "Width", "10%");
                __builder2.AddAttribute(65, "DefaultSortColumn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 43 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Company>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n\t\t\t\t");
                    __builder3.OpenElement(68, "input");
                    __builder3.AddAttribute(69, "class", "form-control form-control-sm");
                    __builder3.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                     context.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => context.Name = __value, context.Name));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Column<Company>>(74);
                __builder2.AddAttribute(75, "Title", "");
                __builder2.AddAttribute(76, "Width", "10%");
                __builder2.AddAttribute(77, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Company>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(78, "\r\n\t\t\t\t");
                    __builder3.OpenElement(79, "button");
                    __builder3.AddAttribute(80, "class", "btn-group-sm");
                    __builder3.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                       c => openPeriod(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(82, "Period");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.EmptyDataTemplate>(85);
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(87, "\r\n\t\t\t");
                    __builder3.AddMarkupContent(88, "<div class=\"text-center\">\r\n\t\t\t\tNo rows found!\r\n\t\t\t</div>\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Pager>(90);
                __builder2.AddAttribute(91, "ShowPageNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ShowTotalCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n\t");
            }
            ));
            __builder.AddComponentReferenceCapture(94, (__value) => {
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                       Table = (BlazorTable.Table<Company>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n\t");
            __builder.OpenElement(96, "table");
            __builder.AddAttribute(97, "hidden", 
#nullable restore
#line 60 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                    hideButtons

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "class", "table-borderless");
            __builder.AddMarkupContent(99, "\r\n\t\t");
            __builder.OpenElement(100, "tr");
            __builder.AddMarkupContent(101, "\r\n\t\t\t");
            __builder.OpenElement(102, "td");
            __builder.AddMarkupContent(103, "\r\n\t\t\t\t");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "class", "btn btn-info");
            __builder.AddAttribute(106, "title", "Submit Changes");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                (x) => submitChanges()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(108, "Submit Changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\t\t\t");
            __builder.OpenElement(111, "td");
            __builder.AddMarkupContent(112, "\r\n\t\t\t\t");
            __builder.OpenElement(113, "button");
            __builder.AddAttribute(114, "class", "btn btn-danger");
            __builder.AddAttribute(115, "title", "Delete");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                          (x) => showDeleteModal()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(117, "Delete company ");
            __builder.AddContent(118, 
#nullable restore
#line 66 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
                                                                                                                     rowID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 70 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Companies.razor"
       
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

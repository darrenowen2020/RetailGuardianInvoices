#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f06a61c70517abcfca37f96560d2aaf550ed13be"
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
#line 256 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Invoices.razor"
       
	private bool showNotes = false;
	//private InvoiceNotes InvoiceNotesModal { get; set; }
	private ITable<InvoiceView> Table;
	private void ToggleEdit()
	{
		Table.ToggleEditMode();
	}
	private bool updateFlag = false;
	private int currentPeriod = 1;
	private string currentPeriodYear = DateTime.Today.ToString("yy");
	private string today = DateTime.Today.ToString("dd/MM/yyyy");

	private string _invoiceNotes;
	public string invoiceNotes {
		get
		{
			return _invoiceNotes;
				}
		set
		{
			_invoiceNotes = value;
			showNotes = false;
		}
	}

	private int defaultSiteId;
	private string defaultSiteName;
	private int defaultSupplierId;
	private string defaultSupplierName;
	private int defaultPaymentTypeId;
	private string defaultPaymentTypeName;

	private Company[] companies;
	private Site[] sites;
	private Supplier[] suppliers;
	private PaymentType[] paymentTypes;
	private InvoiceView[] invoiceViews;
	private InvoiceHeading[] invoiceHeadings;
	private ViewInvoiceGroup[] viewInvoiceGroups;
	private Period[] periods;
	private ViewPeriodYears[] viewPeriodYears;


	Company companyObj = new Company();
	Invoice invoiceObj = new Invoice();
	Site siteObj = new Site();
	Supplier supplierObj = new Supplier();
	PaymentType paymentTypeObj = new PaymentType();
	InvoiceView invoiceViewObj = new InvoiceView();
	InvoiceHeading invoiceHeadingObj = new InvoiceHeading();
	ViewPeriodYears viewPeriodYearsObj = new ViewPeriodYears();

	private int viewPeriodYearsSelected;
	private InvoiceView[] getHeading(int headingId, int paymentType)
	{
		InvoiceView[] groupInvoices;
		groupInvoices = Array.FindAll(invoiceViews, f => (f.InvoiceHeadingId == headingId) && (f.InvoicePaymentId == paymentType));

		return groupInvoices;

	}
	private string _invoiceHeadingSelected;
	private string invoiceHeadingSelected
	{
		get
		{
			return _invoiceHeadingSelected;
		}

		set
		{
			int intInvoiceHeadingSelected;
			try
			{
				intInvoiceHeadingSelected = int.Parse(value);
				InvoiceHeading tmpInvoiceHeading = Array.Find<InvoiceHeading>(invoiceHeadings, f => f.Id == intInvoiceHeadingSelected);
				invoiceHeadingSelectedName = tmpInvoiceHeading.Description;
				_invoiceHeadingSelected = value;
			}
			catch (Exception ex)
			{
				intInvoiceHeadingSelected = 0;
			}
		}
	}

	private string _invoiceHeadingSelectedName;
	private string invoiceHeadingSelectedName
	{
		get
		{
			return _invoiceHeadingSelectedName;
		}

		set
		{
			InvoiceHeading tempInvoiceHeading = Array.Find<InvoiceHeading>(invoiceHeadings, f => f.Description == value);
			if (tempInvoiceHeading == null)
			{
				InvoiceHeading invoiceHeading = new InvoiceHeading();
				invoiceHeading.Description = value;

				Task temp = addNewInvoiceHeading(invoiceHeading);
			}

			_invoiceHeadingSelectedName = value;
		}
	}

	private async Task addNewInvoiceHeading(InvoiceHeading newInvoiceHeading)
	{
		await Http.PostJsonAsync<InvoiceHeading>("/api/InvoiceHeadings", newInvoiceHeading);
		invoiceHeadings = await Http.GetJsonAsync<InvoiceHeading[]>("/api/InvoiceHeadings");
		this.StateHasChanged();
	}

	private string siteSelectedName;
	private string paymentTypeSelected;

	private string _reconPaymentTypeSelected;
	private string reconPaymentTypeSelected
	{
		get
		{
			return _reconPaymentTypeSelected;
		}

		set
		{
			_reconPaymentTypeSelected = value;
			if (value == "ALL")
			{
				Task tmp = GetAllViewGroups();
			}
			else
			{
				Task tmp = GetViewGroup(int.Parse(value));
			}
		}
	}

	private string paymentTypeSelectedName;

	private string _supplierSelectedName;
	private string supplierSelectedName
	{
		get
		{
			return _supplierSelectedName;
		}

		set
		{
			Supplier tempSupplier = Array.Find<Supplier>(suppliers, f => f.Name == value);
			if (tempSupplier == null)
			{
				Task tmp = addNewSupplier(value);
			}
			_supplierSelectedName = value;
		}
	}
	private async Task addNewSupplier(String newSupplierName)
	{
		Supplier newSupplier = new Supplier();
		newSupplier.Name = newSupplierName;

		await Http.SendJsonAsync(HttpMethod.Post, "/api/Suppliers/", newSupplier);
		suppliers = await Http.GetJsonAsync<Supplier[]>("/api/Suppliers/");

		// Get the new suppliers ID to store locally
		newSupplier = Array.Find<Supplier>(suppliers, f => f.Name == newSupplierName);
		_supplierSelected = newSupplier.Id.ToString();

		this.StateHasChanged();
	}

	public string _siteSelected;

	public string siteSelected
	{
		get
		{
			return _siteSelected;
		}

		set
		{
			int intSiteId;
			_siteSelected = value;
			try
			{
				intSiteId = int.Parse(_siteSelected);
			}
			catch (Exception ex)
			{
				intSiteId = 0;
			}
			Site site = Array.Find<Site>(sites, p => p.Id == intSiteId);
			siteSelectedName = site.SiteName;
		}
	}
	public string _supplierSelected;

	public string supplierSelected
	{
		get
		{
			return _supplierSelected;
		}

		set
		{
			int intSupplierId;

			try
			{
				if (value != null)
				{
					_supplierSelected = value;
					intSupplierId = int.Parse(_supplierSelected);
					Supplier supplier = Array.Find<Supplier>(suppliers, p => p.Id == intSupplierId);
					supplierSelectedName = supplier.Name;
				}
			}
			catch (Exception ex)
			{
				intSupplierId = 0;
			}

		}
	}
	public decimal _VatAmount = 0;
	public decimal VatAmount
	{
		get
		{
			return _VatAmount;
		}

		set
		{
			_VatAmount = value;
		}
	}

	public decimal _GrossAmount = 0;
	public decimal GrossAmount
	{
		get
		{
			return _GrossAmount;
		}

		set
		{
			_GrossAmount = value;
		}
	}

	public decimal _NetAmount;
	public decimal NetAmount
	{
		get
		{
			return _NetAmount;
		}
		set
		{
			if (_VatAmount == 0)
			{
				if (_GrossAmount != value)
				{
					VatAmount = value - _GrossAmount;
				}
			}
			else
			{
				if (_GrossAmount == 0)
				{
					GrossAmount = value - _VatAmount;
				}
			}
			_NetAmount = value;
		}

	}


	private void NetAmountKeyPress()
	{
		if (GrossAmount == 0)
		{
			if (VatAmount != 0 && NetAmount != 0)
			{
				GrossAmount = NetAmount - VatAmount;
			}
		}
		else
		{
			NetAmount = GrossAmount + VatAmount;
		}
	}

	private void clearInputValues()
	{
		supplierSelectedName = suppliers[0].Name;
		siteSelectedName = sites[0].SiteName;
		paymentTypeSelected = paymentTypes[0].Description;
		invoiceHeadingSelectedName = invoiceHeadings[0].Description;
		GrossAmount = 0;
		VatAmount = 0;
		NetAmount = 0;
		invoiceObj.InvoiceReference = "";
		invoiceObj.Description = "";
	}

	protected override async Task OnInitializedAsync()
	{
		viewPeriodYears = await Http.GetJsonAsync<ViewPeriodYears[]>("api/ViewPeriodYears");
		viewPeriodYearsSelected = int.Parse(currentPeriodYear);

		invoiceViews = await Http.GetJsonAsync<InvoiceView[]>("/api/InvoiceViews/Year/" + viewPeriodYearsSelected);

		companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");
		sites = await Http.GetJsonAsync<Site[]>("api/Sites");
		suppliers = await Http.GetJsonAsync<Supplier[]>("api/Suppliers");
		invoiceHeadings = await Http.GetJsonAsync<InvoiceHeading[]>("api/InvoiceHeadings");
		periods = await Http.GetJsonAsync<Period[]>("api/Periods/Year/" + currentPeriodYear);

		paymentTypes = await Http.GetJsonAsync<PaymentType[]>("api/PaymentTypes");
		defaultPaymentTypeId = Array.Find(paymentTypes, f => f.Type == "DD").Id;
		await GetViewGroup(defaultPaymentTypeId);

		defaultSiteId = sites[0].Id;
		defaultSiteName = sites[0].SiteName;
		defaultSupplierId = suppliers[0].Id;
		defaultSupplierName = suppliers[0].Name;

		defaultPaymentTypeName = paymentTypes[0].Description;


		invoiceObj.Date = DateTime.Today;

		siteSelected = defaultSiteId.ToString();
		siteSelectedName = defaultSiteName;
		supplierSelected = defaultSupplierId.ToString();
		supplierSelectedName = defaultSupplierName;
		paymentTypeSelected = defaultPaymentTypeId.ToString();
		invoiceHeadingSelected = invoiceHeadings[0].Id.ToString();
		invoiceHeadingSelectedName = invoiceHeadings[0].Description;
		Period tmp = getCurrentPeriod();
	}

	void AddNewInvoice()
	{
		try
		{
			invoiceObj.SiteID = int.Parse(siteSelected);
		}
		catch (Exception ex)
		{
			invoiceObj.SiteID = defaultSiteId;
		}

		try
		{
			invoiceObj.SupplierID = int.Parse(supplierSelected);
		}
		catch (Exception ex)
		{
			invoiceObj.SupplierID = defaultSupplierId;
		}

		try
		{
			invoiceObj.PaymentTypeID = int.Parse(paymentTypeSelected);
		}
		catch (Exception ex)
		{
			invoiceObj.PaymentTypeID = defaultPaymentTypeId;
		}

		invoiceObj.GrossAmount = GrossAmount;
		invoiceObj.VATAmount = VatAmount;
		invoiceObj.NetAmount = NetAmount;
		invoiceObj.EditDate = DateTime.Now;
		invoiceObj.Paid = true; // defaulting this to true#
		invoiceObj.Heading = int.Parse(invoiceHeadingSelected);
		invoiceObj.PeriodNo = getPeriod(invoiceObj.Date).PeriodKey;
		invoiceObj.Notes = invoiceNotes;

		Task d = PostInvoice();

	}

	private Period getCurrentPeriod()
	{
		return getPeriod(DateTime.Now);
	}

	private Period getPeriod(DateTime inDateTime)
	{
		Period period = Array.Find<Period>(periods, f => DateTime.Compare(inDateTime, f.StartDate) >= 0 && DateTime.Compare(inDateTime, f.EndDate) <= 0);
		return period;
	}

	protected async Task PostInvoice()
	{
		if (updateFlag)
		{
			await Http.SendJsonAsync(HttpMethod.Put, "/api/Invoices/" + invoiceObj.ID, invoiceObj);
		}
		else
		{
			invoiceObj.CreatedDate = DateTime.Now;
			await Http.SendJsonAsync(HttpMethod.Post, "/api/Invoices/", invoiceObj);
		}
		invoiceViews = await Http.GetJsonAsync<InvoiceView[]>("/api/InvoiceViews");
		clearInputValues();
		this.StateHasChanged();

	}

	private async Task GetViewGroup(int paymentType)
	{
		viewInvoiceGroups = await Http.GetJsonAsync<ViewInvoiceGroup[]>("/api/ViewInvoiceGroups/PayType/" + paymentType);
		this.StateHasChanged();
	}

	private async Task GetAllViewGroups()
	{
		viewInvoiceGroups = await Http.GetJsonAsync<ViewInvoiceGroup[]>("/api/ViewInvoiceGroups");
		this.StateHasChanged();
	}

	private void AddInvoiceNotes()
	{
		invoiceNotes = invoiceObj.Notes;
		showNotes = true;
		StateHasChanged();
	}
	public void updateInvoiceNotes(string newNotes)
	{
		invoiceNotes = newNotes;
	}

	// Edit Method
	private void EditInvoice(InvoiceView invoiceView)
	{
		invoiceObj = new Invoice();

		invoiceObj.ID = invoiceView.InvoiceId;
		invoiceObj.InvoiceReference = invoiceView.InvoiceReference;
		invoiceObj.Description = invoiceView.InvoiceDescription;
		invoiceObj.GrossAmount = Math.Round(invoiceView.InvoiceGross, 2);
		invoiceObj.VATAmount = Math.Round(invoiceView.InvoiceVAT, 2);
		invoiceObj.NetAmount = Math.Round(invoiceView.InvoiceNet, 2);
		invoiceObj.PaymentTypeID = invoiceView.InvoicePaymentId;
		invoiceObj.SupplierID = invoiceView.InvoiceSupplierId;
		invoiceObj.SiteID = invoiceView.InvoiceSiteId;
		invoiceObj.Notes = invoiceView.InvoiceNotes;
		invoiceObj.Date = invoiceView.InvoiceDate;
		invoiceObj.CreatedDate = invoiceView.InvoiceCreatedDate;

		updateFlag = true;
		Supplier supplier = Array.Find<Supplier>(suppliers, p => p.Id == invoiceObj.SupplierID);
		Site site = Array.Find<Site>(sites, p => p.Id == invoiceObj.SiteID);

		siteSelectedName = site.SiteName;
		supplierSelectedName = supplier.Name;
		GrossAmount = invoiceObj.GrossAmount;
		VatAmount = invoiceObj.VATAmount;
		NetAmount = invoiceObj.NetAmount;

		invoiceNotes = "init";
		this.StateHasChanged();
	}

	// Delete Method
	protected async Task DeleteInvoice(int InvoiceID)
	{

		await Http.DeleteAsync("/api/Invoices/" + InvoiceID);

		invoiceViews = await Http.GetJsonAsync<InvoiceView[]>("/api/InvoiceViews");
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

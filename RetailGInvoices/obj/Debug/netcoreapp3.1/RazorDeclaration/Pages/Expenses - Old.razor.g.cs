#pragma checksum "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Expenses - Old.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752492aa41f45559ad3053cd006d166204bd6205"
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
#line 3 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Expenses - Old.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Expenses - Old.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CompLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Expensesold")]
    public partial class Expenses___Old : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 284 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\Expenses - Old.razor"
       
	[Parameter]
	public int companyId { get; set; }

	private bool showNotes = false;
	private ITable<ExpenseView> Table;
	private void ToggleEdit()
	{
		Table.ToggleEditMode();
	}
	private bool updateFlag = false;
	private int currentPeriod = 1;
	private string currentPeriodYear = DateTime.Today.ToString("yy");
	private string today = DateTime.Today.ToString("dd/MM/yyyy");

	private bool showInformationModal = false;
	private string _expenseNotes;
	public string expenseNotes
	{
		get
		{
			return _expenseNotes;
		}
		set
		{
			_expenseNotes = value;
			showNotes = false;
			Task tmp = Focus("btnAddExpense");
		}
	}

	private int defaultSiteId;
	private string defaultSiteName;
	private string defaultSupplierName;
	private int defaultPaymentTypeId;
	private string defaultPaymentTypeName;

	private Company[] companies;
	private Site[] sites;
	private ExpenseSupplier[] suppliers;
	private PaymentType[] paymentTypes;
	private ExpenseView[] expenseViews;
	private InvoiceHeading[] expenseHeadings;
	private ViewExpenseGroup[] viewExpenseGroups;
	private Period[] periods;
	private ViewPeriodYears[] viewPeriodYears;
	private VatCategory[] vatCategories;
	private VatRate[] vatRates;


	Company companyObj = new Company();
	Expense expenseObj = new Expense();
	Site siteObj = new Site();
	ExpenseSupplier supplierObj = new ExpenseSupplier();
	PaymentType paymentTypeObj = new PaymentType();
	ExpenseView expenseViewObj = new ExpenseView();
	InvoiceHeading expenseHeadingObj = new InvoiceHeading();
	ViewPeriodYears viewPeriodYearsObj = new ViewPeriodYears();

	private int GetCatVatRate(int vatCategoryId)
	{
		try
		{
			if (vatCategories == null)
			{
				return 0;
			}
			else
			{
				return vatCategories.Where(f => f.Id == vatCategoryId).FirstOrDefault().VatRate;
			}
		}
		catch (Exception ex)
		{
			return 0;
		}
	}

	private Decimal CalcVat(Decimal grossAmount, int catId)
	{
		Decimal vatAmount = 0;
		Decimal vatRate = GetVatRate(GetCatVatRate(catId));

		if (vatRate == 0)
		{
			vatAmount = 0;
		}
		else
		{
			vatAmount = Math.Round(grossAmount * vatRate,2);

		}

		return vatAmount;
	}

	private Decimal CalcNet(Decimal grossAmount, int catId)
	{
		Decimal netAmount = 0;
		Decimal vatRate = GetVatRate(GetCatVatRate(catId));

		if (vatRate == 0)
		{
			netAmount = grossAmount;
		}
		else
		{
			netAmount = Math.Round(grossAmount - (grossAmount * vatRate), 2);

		}

		return netAmount;
	}


	public void refKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("description");
		}
	}

	public void vatCatKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("grossAmount");
		}
	}
	public void descKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("heading");
		}
	}
	public void grossKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("btnAddExpense");
		}
	}
	public void vatKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("netAmount");
		}
	}

	public void netKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("btnAddExpense");
		}
	}

	public void suppKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("reference");
		}
	}
	public void dateKeyHandler(string keyPressed)
	{
		string nextField = "site";

		if (keyPressed == "Enter")
		{
			if (sites.Length == 1)
			{
				nextField = "supplier";
			}
			Task tmp = Focus(nextField);
		}
	}
	public void siteKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("supplier");
		}
	}
	public void headingKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("paymentType");
		}
	}
	public void payKeyHandler(string keyPressed)
	{
		if (keyPressed == "Enter")
		{
			Task tmp = Focus("vatcat");
		}
	}
	public async Task Focus(string elementId)
	{
		await JSRuntime.InvokeVoidAsync("functionLibrary.focusElement", elementId);
	}


	public string informationModalReply
	{
		get
		{
			return null;
		}

		set
		{
			showInformationModal = false;
		}

	}

	private int viewPeriodYearsSelected;
	private ExpenseView[] getHeading(int headingId, int paymentType)
	{
		ExpenseView[] groupExpenses;
		groupExpenses = Array.FindAll(expenseViews, f => (f.HeadingId == headingId) && (f.ExpensePaymentId == paymentType));

		return groupExpenses;

	}
	private int expenseHeadingSelected;

	private string _expenseHeadingSelectedName;
	private string expenseHeadingSelectedName
	{
		get
		{
			return _expenseHeadingSelectedName;
		}

		set
		{
			InvoiceHeading tempHeading = Array.Find<InvoiceHeading>(expenseHeadings, f => f.Description == value);
			if (tempHeading != null)
			{
				expenseHeadingSelected = tempHeading.Id;
			}
			else
			{
				InvoiceHeading expenseHeading = new InvoiceHeading();
				expenseHeading.Description = value;

				Task temp = addNewHeading(expenseHeading);
			}

			_expenseHeadingSelectedName = value;
		}
	}

	private string GetVatCatDesc(int VatCatId)
	{
		return vatCategories.Where(f => f.Id == VatCatId).FirstOrDefault().Category;
	}

	private async Task addNewHeading(InvoiceHeading newHeading)
	{
		await Http.PostJsonAsync<InvoiceHeading>("/api/InvoiceHeadings", newHeading);
		expenseHeadings = await Http.GetJsonAsync<InvoiceHeading[]>("/api/InvoiceHeadings");
		this.StateHasChanged();
	}

	private int siteSelected;
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

	private int supplierSelected;

	private string _supplierSelectedName;
	private string supplierSelectedName
	{
		get
		{
			return _supplierSelectedName;
		}

		set
		{
			ExpenseSupplier tempSupplier = Array.Find<ExpenseSupplier>(suppliers, f => f.Name == value);
			if (tempSupplier != null)
			{
				supplierSelected = tempSupplier.Id;
			}
			else
			{
				Task tmp = addNewSupplier(value);
			}
			_supplierSelectedName = value;
		}
	}

	private async Task addNewSupplier(String newSupplierName)
	{
		ExpenseSupplier newSupplier = new ExpenseSupplier();
		newSupplier.Name = newSupplierName;
		newSupplier.Deleted = false;

		await Http.SendJsonAsync(HttpMethod.Post, "/api/ExpenseSuppliers/", newSupplier);
		suppliers = await Http.GetJsonAsync<ExpenseSupplier[]>("/api/ExpenseSuppliers/");

		// Get the new suppliers ID to store locally
		newSupplier = Array.Find<ExpenseSupplier>(suppliers, f => f.Name == newSupplierName);
		supplierSelected = newSupplier.Id;

		this.StateHasChanged();
	}

	public string _siteSelectedName;

	public string siteSelectedName
	{
		get
		{
			return _siteSelectedName;
		}

		set
		{
			_siteSelectedName = value;

			Site site = Array.Find<Site>(sites, p => p.SiteName == value);
			siteSelected = site.Id;
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

	public decimal _NetAmount = 0;
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
		expenseObj = new Expense(companyId);
		expenseObj.Date = DateTime.Today;
		supplierSelectedName = suppliers[0].Name;
		siteSelectedName = sites[0].SiteName;
		paymentTypeSelected = paymentTypes[0].Description;
		expenseHeadingSelectedName = expenseHeadings[0].Description;
		GrossAmount = 0;
		VatAmount = 0;
		NetAmount = 0;
		expenseObj.ExpenseReference = "";
		expenseObj.Description = "";
	}

	protected override async Task OnInitializedAsync()
	{
		companyId = AppData.CompanyId;

		viewPeriodYears = await Http.GetJsonAsync<ViewPeriodYears[]>("api/ViewPeriodYears");
		viewPeriodYearsSelected = int.Parse(currentPeriodYear);

		expenseViews = await Http.GetJsonAsync<ExpenseView[]>("/api/ExpenseViews/Year/" + viewPeriodYearsSelected + "/" + companyId);

		companies = await Http.GetJsonAsync<Company[]>("/api/Companies/");

		sites = await Http.GetJsonAsync<Site[]>("api/Sites/Company/" + companyId);
		if (sites.Length == 1)
		{
			siteSelected = 0;
			siteSelectedName = sites[0].SiteName;
		}

		suppliers = await Http.GetJsonAsync<ExpenseSupplier[]>("api/ExpenseSuppliers");
		expenseHeadings = await Http.GetJsonAsync<InvoiceHeading[]>("api/InvoiceHeadings");
		periods = await Http.GetJsonAsync<Period[]>("api/Periods/Company/" + companyId + "/Year/" + currentPeriodYear);
		vatCategories = await GetVatCategories();
		vatRates = await GetVatRates();

		paymentTypes = await Http.GetJsonAsync<PaymentType[]>("api/PaymentTypes");
		if (paymentTypes.Length == 0)
		{
			PaymentType paymentType = new PaymentType();
			paymentType.Id = 0;
			paymentType.Description = "No Payment Types";
			paymentType.Type = "";

			paymentTypes = new PaymentType[1];
			paymentTypes[0] = paymentType;
		}

		try
		{
			defaultPaymentTypeId = Array.Find(paymentTypes, f => f.Type == "DD").Id;
		}
		catch (NullReferenceException ex)
		{
			defaultPaymentTypeId = 0;
		}
		catch (Exception ex)
		{
			defaultPaymentTypeId = 0;
		}
		await GetViewGroup(defaultPaymentTypeId);

		if (sites.Length == 0)
		{
			Site site = new Site();
			site.Id = 0;
			site.SiteName = "No Sites";
			sites = new Site[1];
			sites[0] = site;
		}
		defaultSiteId = sites[0].Id;
		defaultSiteName = sites[0].SiteName;


		defaultPaymentTypeName = paymentTypes[0].Description;

		expenseObj.Date = DateTime.Today;

		siteSelected = defaultSiteId;
		siteSelectedName = defaultSiteName;
		paymentTypeSelected = defaultPaymentTypeId.ToString();

		if (expenseHeadings.Length == 0)
		{
			InvoiceHeading expenseHeading = new InvoiceHeading();
			expenseHeading.Id = 0;
			expenseHeading.Description = "No Headings";
			expenseHeadings = new InvoiceHeading[1];
			expenseHeadings[0] = expenseHeading;
		}
		expenseHeadingSelected = expenseHeadings[0].Id;
		expenseHeadingSelectedName = expenseHeadings[0].Description;

		Period tmp = getCurrentPeriod();
		await Focus("date");
	}

	private async Task<VatCategory[]> GetVatCategories()
	{
		VatCategory[] vatCategories;
		try
		{
			vatCategories = await Http.GetJsonAsync<VatCategory[]>("api/VatCategories");

			return vatCategories;
		}
		catch (Exception ex)
		{
			return new VatCategory[0];
		}
	}

	private async Task<VatRate[]> GetVatRates()
	{
		VatRate[] vatRates;

		try
		{
			vatRates = await Http.GetJsonAsync<VatRate[]>("api/VatRates");
			return vatRates;
		}
		catch (Exception ex)
		{
			return new VatRate[0];
		}
	}

	private Decimal GetVatRate(int vatRateId)
	{
		Decimal vatRate = 0;
		try
		{
			vatRate = vatRates.Where(f => f.Id == vatRateId).FirstOrDefault().Rate;
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine(ex.Message);
		}

		return vatRate;
	}

	void AddNewExpense()
	{
		if (!validateNewExpense())
		{
			showInformationModal = true;
		}
		else
		{

			try
			{
				expenseObj.SiteID = siteSelected;
			}
			catch (Exception ex)
			{
				expenseObj.SiteID = defaultSiteId;
			}

			try
			{
				expenseObj.PaymentTypeID = int.Parse(paymentTypeSelected);
			}
			catch (Exception ex)
			{
				expenseObj.PaymentTypeID = defaultPaymentTypeId;
			}

			expenseObj.Paid = !GetPaymentType(expenseObj.PaymentTypeID).ReconcileFlag;

			expenseObj.SupplierID = supplierSelected;
			expenseObj.GrossAmount = GrossAmount;
			expenseObj.VATAmount = CalcVat(GrossAmount,expenseObj.CategoryID);
			expenseObj.NetAmount = CalcNet(GrossAmount, expenseObj.CategoryID);
			expenseObj.EditDate = DateTime.Now;

			expenseObj.Heading = expenseHeadingSelected;

			Period expensePeriod = getPeriod(expenseObj.Date);
			expenseObj.PeriodNo = expensePeriod.PeriodKey;
			expenseObj.PeriodId = expensePeriod.PeriodId;
			expenseObj.Notes = expenseNotes;
			expenseObj.CompanyID = companyId;

			Task d = PostExpense();
			StateHasChanged();
		}

	}

	private PaymentType GetPaymentType(int paymentType)
	{
		return Array.Find(paymentTypes, f => f.Id == paymentType);
	}

	private bool validateNewExpense()
	{
		bool isValid = true;

		if (supplierSelectedName == null)
		{
			isValid = false;
		}

		if (GrossAmount == 0)
		{
			isValid = false;
		}

		if (expenseObj.Description == null)
		{
			isValid = false;
		}
		return isValid;
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

	protected async Task PostExpense()
	{
		if (updateFlag)
		{
			await Http.SendJsonAsync(HttpMethod.Put, "/api/Expenses/" + expenseObj.ID, expenseObj);
		}
		else
		{
			expenseObj.CreatedDate = DateTime.Now;
			try
			{
				await Http.SendJsonAsync(HttpMethod.Post, "/api/Expenses/", expenseObj);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);

			}
		}
		expenseViews = await Http.GetJsonAsync<ExpenseView[]>("/api/ExpenseViews/Year/" + viewPeriodYearsSelected + "/" + companyId);
		clearInputValues();
		this.StateHasChanged();

	}

	private async Task GetViewGroup(int paymentType)
	{
		viewExpenseGroups = await Http.GetJsonAsync<ViewExpenseGroup[]>("/api/ViewExpenseGroups/PayType/" + paymentType + "/" + companyId);
		this.StateHasChanged();
	}

	private async Task GetAllViewGroups()
	{
		viewExpenseGroups = await Http.GetJsonAsync<ViewExpenseGroup[]>("/api/ViewExpenseGroups/Company/" + companyId);
		this.StateHasChanged();
	}

	private void AddExpenseNotes()
	{
		expenseNotes = expenseObj.Notes;
		showNotes = true;
		StateHasChanged();
	}
	public void updateExpenseNotes(string newNotes)
	{
		expenseNotes = newNotes;
	}

	// Edit Method
	private void EditExpense(ExpenseView expenseView)
	{
		expenseObj = new Expense(companyId);

		expenseObj.ID = expenseView.ExpenseId;
		expenseObj.ExpenseReference = expenseView.ExpenseReference;
		expenseObj.Description = expenseView.ExpenseDescription;
		expenseObj.GrossAmount = Math.Round(expenseView.ExpenseGross, 2);
		expenseObj.VATAmount = Math.Round(expenseView.ExpenseVAT, 2);
		expenseObj.NetAmount = Math.Round(expenseView.ExpenseNet, 2);
		expenseObj.PaymentTypeID = expenseView.ExpensePaymentId;
		expenseObj.SupplierID = expenseView.ExpenseSupplierId;
		expenseObj.SiteID = expenseView.ExpenseSiteId;
		expenseObj.Notes = expenseView.ExpenseNotes;
		expenseObj.Date = expenseView.ExpenseDate;
		expenseObj.CreatedDate = expenseView.ExpenseCreatedDate;

		updateFlag = true;
		ExpenseSupplier supplier = Array.Find<ExpenseSupplier>(suppliers, p => p.Id == expenseObj.SupplierID);
		Site site = Array.Find<Site>(sites, p => p.Id == expenseObj.SiteID);

		siteSelectedName = site.SiteName;
		supplierSelectedName = supplier.Name;
		GrossAmount = expenseObj.GrossAmount;
		VatAmount = expenseObj.VATAmount;
		NetAmount = expenseObj.NetAmount;

		expenseNotes = "init";
		this.StateHasChanged();
	}

	// Delete Method
	protected async Task DeleteExpense(ExpenseView expenseView)
	{

		await Http.DeleteAsync("/api/Expenses/" + expenseView.ExpenseId);

		expenseViews = await Http.GetJsonAsync<ExpenseView[]>("/api/ExpenseViews/Year/" + viewPeriodYearsSelected + "/" + companyId);
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

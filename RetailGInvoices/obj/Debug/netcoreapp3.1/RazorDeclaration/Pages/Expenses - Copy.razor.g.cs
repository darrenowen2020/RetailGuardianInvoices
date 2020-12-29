#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Expenses - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "badb375ef2277ff7bab9e5e4c3941ceefe59ead2"
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
#line 12 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Expenses - Copy.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Expenses - Copy.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CompLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Expenses")]
    public partial class Expenses___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 314 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Expenses - Copy.razor"
           
		[Parameter]
		public int companyId { get; set; }

		private bool showNotes = false;
		private ITable<ExpenseModel> Table;
		private void ToggleEdit()
		{
			Table.ToggleEditMode();
		}
		private bool updateFlag = false;
		private int currentPeriod = 1;
		private string currentPeriodYear = DateTime.Today.ToString("yy");
		private string today = DateTime.Today.ToString("dd/MM/yyyy");

		private bool showInformationModal = false;
		private bool hideNewExpenseTable = true;
		private bool disableCreateButton = true;

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

		private int newLineAdded = 0;

		private int defaultSiteId;
		private int defaultSupplierId;
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
		private List<ExpenseModel> expenseModels;

		Company companyObj = new Company();
		ExpenseModel newExpenseModel;
		ExpenseModel tmpExpenseModel;

		Site siteObj = new Site();
		ExpenseSupplier supplierObj = new ExpenseSupplier();
		PaymentType paymentTypeObj = new PaymentType();
		ExpenseView expenseViewObj = new ExpenseView();
		InvoiceHeading expenseHeadingObj = new InvoiceHeading();
		ViewPeriodYears viewPeriodYearsObj = new ViewPeriodYears();

		protected override async Task OnInitializedAsync()
		{
			companyId = AppData.CompanyId;
			tmpExpenseModel = new ExpenseModel();

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

			if (suppliers.Length == 0)
			{
				ExpenseSupplier supplier = new ExpenseSupplier();
				supplier.Id = 0;
				supplier.Name = "No Suppliers";
				suppliers = new ExpenseSupplier[1];
				suppliers[0] = supplier;
			}
			defaultSupplierId = suppliers[0].Id;

			defaultPaymentTypeName = paymentTypes[0].Description;

			ResetNewExpenseModel();

			expenseModels = await GetExpenseModels();

			siteSelected = defaultSiteId;
			paymentTypeSelected = defaultPaymentTypeId.ToString();

			Period tmp = getCurrentPeriod();
			disableCreateButton = false;
		}

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if (!firstRender)
			{
				if (newLineAdded != 0)
				{
					Task tmp = Focus($"desc{newLineAdded}");
					newLineAdded = 0;
				}
			}

			return base.OnAfterRenderAsync(firstRender);
		}

		private Site GetSite(int siteId)
		{
			Site site = sites.Where(f => f.Id == siteId).FirstOrDefault();
			if (site == null)
			{
				site = new Site();
			}

			return site;
		}

		private ExpenseSupplier GetSupplier(int supplierId)
		{
			ExpenseSupplier supplier = suppliers.Where(f => f.Id == supplierId).FirstOrDefault();
			if (supplier == null)
			{
				supplier = new ExpenseSupplier();
			}

			return supplier;
		}

		private PaymentType GetPaymentType(int paymentTypeId)
		{
			PaymentType paymentType = paymentTypes.Where(f => f.Id == paymentTypeId).FirstOrDefault();

			if (paymentType == null)
			{
				paymentType = new PaymentType();
			}

			return paymentType;
		}

		private async Task<List<ExpenseModel>> GetExpenseModels()
		{
			List<ExpenseModel> expenseModels = new List<ExpenseModel>();

			try
			{
				List<ExpenseHead> expenseHeads = await Http.GetJsonAsync<List<ExpenseHead>>("api/ExpenseHeads");
				foreach (ExpenseHead expenseHead in expenseHeads)
				{
					ExpenseModel expenseModel = new ExpenseModel(expenseHead);
					expenseModel.ExpenseLines = await GetExpenseLines(expenseHead);

					expenseModels.Add(expenseModel);
					expenseModel.TotalExpense = GetExpenseTotal(expenseModel.ExpenseLines);
				}
				return expenseModels;
			}
			catch (Exception ex)
			{
				return new List<ExpenseModel>();
			}
		}

		private async Task<List<ExpenseLine>> GetExpenseLines(ExpenseHead expenseHead)
		{
			try
			{
				return await Http.GetJsonAsync<List<ExpenseLine>>($"api/ExpenseLines/ExpenseHead/{expenseHead.Id}");
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return new List<ExpenseLine>();
			}
		}

		private decimal GetExpenseTotal(List<ExpenseLine> expenseLines )
		{
			decimal total = 0;

			foreach (ExpenseLine expenseLine in expenseLines)
			{
				total += expenseLine.NetAmount;
			}

			return total;
		}

		private int GetLastLineNo(ExpenseModel expenseModel)
		{
			int reply = 0;
			foreach (ExpenseLine expenseLine in expenseModel.ExpenseLines)
			{
				if (expenseLine.Line > reply)
				{
					reply = expenseLine.Line;
				}
			}

			return reply;
		}

		private void AddNewLine(ExpenseModel expenseModel)
		{
			tmpExpenseModel = expenseModel.Clone();


			int newLineNo = GetLastLineNo(expenseModel) + 1;
			ExpenseLine expenseLine = new ExpenseLine(expenseModel.expenseHead.Id, newLineNo);

			expenseModel.ExpenseLines.Add(expenseLine);
			StateHasChanged();
			newLineAdded = newLineNo;
		}

		private void DeleteLine(ExpenseModel expenseModel, ExpenseLine expenseLine)
		{
			if (expenseLine != null)
			{
				expenseModel.ExpenseLines.Remove(expenseLine);
			}
		}

		private void ToggleNewExpenseTable()
		{
			hideNewExpenseTable = !hideNewExpenseTable;
			Task tmp = Focus("expensedate");
			disableCreateButton = true;
		}

		private void ExitExpenseModel(ExpenseModel expenseModel)
		{
			expenseModel = tmpExpenseModel.Clone();
			disableCreateButton = false;
			ResetNewExpenseModel();
			ToggleNewExpenseTable();
		}

		private async Task SubmitExpenseModel(ExpenseModel expenseModel)
		{
			ExpenseHead expenseHead;
			bool isEdit = false;

			Period expensePeriod = GetPeriod(expenseModel.expenseHead.ExpenseDate);
			expenseModel.expenseHead.PeriodId = expensePeriod.PeriodId;
			expenseModel.expenseHead.PeriodNo = expensePeriod.PeriodKey;
			expenseModel.expenseHead.SiteID = siteSelected;
			expenseModel.expenseHead.SupplierID = supplierSelected;

			if (expenseModel.expenseHead.Id == 0)
			{
				expenseHead = await PostExpenseHead(expenseModel.expenseHead);
			}
			else
			{
				isEdit = true;
				UpdateExpenseHead(expenseModel.expenseHead);
				expenseModel.TotalExpense = GetExpenseTotal(expenseModel.ExpenseLines);
			}

			foreach (ExpenseLine expenseLine in expenseModel.ExpenseLines)
			{
				if (expenseLine.Id == 0)
				{
					expenseLine.ExpenseId = expenseModel.expenseHead.Id;
					await PostExpenseLine(expenseLine);
				}
				else
				{
					UpdateExpenseLine(expenseLine);
				}
			}

			ResetNewExpenseModel();
			ToggleNewExpenseTable();
			disableCreateButton = false;

			if (isEdit)
			{
				this.StateHasChanged();
			}
			else
			{
				await GetExpenseModels();
			}
		}

		private void ResetNewExpenseModel()
		{
			newExpenseModel = new ExpenseModel(companyId);
			newExpenseModel.expenseHead.SiteID = defaultSiteId;
			siteSelected = 0;
			supplierSelected = 0;
		}

		private async Task<ExpenseHead> PostExpenseHead(ExpenseHead expenseHead)
		{
			try
			{
				return await Http.PostJsonAsync<ExpenseHead>("api/ExpenseHeads", expenseHead);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return new ExpenseHead();
			}
		}
		private void UpdateExpenseHead(ExpenseHead expenseHead)
		{
			try
			{
				string payload = JsonConvert.SerializeObject(expenseHead);

				StringContent content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");
				HttpResponseMessage response =  Http.PutAsync($"api/ExpenseHeads/{expenseHead.Id}", content).Result;

				if (!response.IsSuccessStatusCode)
				{
					throw new Exception($"{response.StatusCode} Error updating expense Head: id: {expenseHead.Id}");
				}
			}
			catch (Exception ex)
			{
				throw new System.Exception(ex.Message);
			}
		}

		private async Task<ExpenseLine> PostExpenseLine(ExpenseLine expenseLine)
		{
			try
			{
				return await Http.PostJsonAsync<ExpenseLine>($"api/ExpenseLines", expenseLine);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void UpdateExpenseLine(ExpenseLine expenseLine)
		{
			try
			{
				string payload = JsonConvert.SerializeObject(expenseLine);

				StringContent content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");
				HttpResponseMessage response = Http.PutAsync($"api/ExpenseLines/{expenseLine.Id}", content).Result;

				if (!response.IsSuccessStatusCode)
				{
					throw new Exception($"{response.StatusCode} Error updating expense Line: id: {expenseLine.Id}");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private string GetSiteName(int siteId)
		{
			string reply;

			if (sites == null)
			{
				reply = string.Empty;
			}
			else
			{
				string siteName = sites.Where(f => f.Id == siteId).Select(g => g.SiteName).FirstOrDefault();
				if (siteName == null)
				{
					reply = string.Empty;
				}
				else
				{
					reply = siteName;
				}
			}

			return reply;
		}

		private string GetSupplierName(int supplierId)
		{
			string reply;

			if (suppliers == null)
			{
				reply = string.Empty;
			}
			else
			{
				reply = suppliers.Where(f => f.Id == supplierId).Select(g => g.Name).FirstOrDefault();
			}

			return reply;
		}

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
					return vatCategories.Where(f => f.Id == vatCategoryId).Select(g => g.VatRate).FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
				return 0;
			}
		}

		private Decimal CalcGross(Decimal netAmount, int catId)
		{
			Decimal grossAmount = 0;
			Decimal vatRate = GetVatRate(GetCatVatRate(catId));

			if (vatRate == 0)
			{
				grossAmount = 0;
			}
			else
			{
				grossAmount = Math.Round(netAmount / (1 + vatRate), 2);

			}

			return grossAmount;
		}

		private Decimal GetNetValue(Decimal netAmount)
		{
			return Math.Round(NetAmount, 2);
		}

		private Decimal CalcVat(Decimal netAmount, int catId)
		{
			Decimal vatAmount = 0;
			Decimal vatRate = GetVatRate(GetCatVatRate(catId));

			if (vatRate == 0)
			{
				vatAmount = 0;
			}
			else
			{
				vatAmount = netAmount - Math.Round(CalcGross(netAmount,catId),2);

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
				Task tmp = Focus("paymenttype");
			}
		}

		public void vatCatKeyHandler(string keyPressed, int lineNo)
		{
			if (keyPressed == "Enter")
			{
				Task tmp = Focus($"totalamount{lineNo}");
			}
		}
		public void descKeyHandler(string keyPressed, int lineNo)
		{
			if (keyPressed == "Enter")
			{
				Task tmp = Focus($"vatcat{lineNo}");
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

		public void netKeyHandler(string keyPressed, int lineNo)
		{
			if (keyPressed == "Enter")
			{
				Task tmp = Focus($"addbutton");
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
				Task tmp = Focus("addbutton");
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
			return vatCategories.Where(f => f.Id == VatCatId).Select(g => g.Category).FirstOrDefault();
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
			newExpenseModel = new ExpenseModel();
			newExpenseModel.expenseHead.CompanyID = companyId;
			newExpenseModel.expenseHead.ExpenseReference = string.Empty;

			supplierSelectedName = suppliers[0].Name;
			siteSelectedName = sites[0].SiteName;
			paymentTypeSelected = paymentTypes[0].Description;
			expenseHeadingSelectedName = expenseHeadings[0].Description;
			GrossAmount = 0;
			VatAmount = 0;
			NetAmount = 0;
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

			//if (expenseObj.Description == null)
			//{
			//	isValid = false;
			//}
			return isValid;
		}

		private Period getCurrentPeriod()
		{
			return GetPeriod(DateTime.Now);
		}

		private Period GetPeriod(DateTime? inDateTime)
		{
			Period period = Array.Find<Period>(periods, f => inDateTime >= f.StartDate && inDateTime <= f.EndDate);
			return period;
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
			//expenseNotes = expenseObj.Notes;
			showNotes = true;
			StateHasChanged();
		}
		public void updateExpenseNotes(string newNotes)
		{
			expenseNotes = newNotes;
		}

		// Edit Method
		private void EditExpense(ExpenseModel expenseModel)
		{
			ToggleNewExpenseTable();
			newExpenseModel = expenseModel;
			siteSelected = expenseModel.expenseHead.SiteID;
			supplierSelected = expenseModel.expenseHead.SupplierID;
			supplierSelectedName = GetSupplierName(supplierSelected);
			hideNewExpenseTable = false;
		}

		// Delete Method
		protected async Task DeleteExpense(ExpenseModel expenseModel)
		{
			try
			{
				await Http.DeleteAsync($"api/ExpenseHeads/{expenseModel.expenseHead.Id}");
				await Http.DeleteAsync($"api/ExpenseLines/ExpenseHead/{expenseModel.expenseHead.Id}");

				expenseModels.Remove(expenseModel);

				StateHasChanged();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
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

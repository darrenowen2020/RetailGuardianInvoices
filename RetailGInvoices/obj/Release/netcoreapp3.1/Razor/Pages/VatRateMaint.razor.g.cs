#pragma checksum "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea86fa449ccc60eb8327f87f6150631c6bc432dd"
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
#line 1 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 3 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CompLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/VatRateMaint")]
    public partial class VatRateMaint : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-info");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                         x => ToggleEdit()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 8 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                        disableEditButton

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, 
#nullable restore
#line 8 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                                            editButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<BlazorTable.Table<VatRate>>(6);
            __builder.AddAttribute(7, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<VatRate>>(
#nullable restore
#line 9 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                      vatRates

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n\t");
                __builder2.OpenComponent<BlazorTable.Column<VatRate>>(10);
                __builder2.AddAttribute(11, "Title", "Description");
                __builder2.AddAttribute(12, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<VatRate, System.Object>>>(
#nullable restore
#line 10 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                             x => x.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<VatRate>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n\t\t\t");
                    __builder3.OpenElement(15, "input");
                    __builder3.AddAttribute(16, "type", "text");
                    __builder3.AddAttribute(17, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                      x => AddChangeToQueue(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                      context.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => context.Description = __value, context.Description));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\t");
                __builder2.OpenComponent<BlazorTable.Column<VatRate>>(22);
                __builder2.AddAttribute(23, "Title", "VAT Rate");
                __builder2.AddAttribute(24, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<VatRate, System.Object>>>(
#nullable restore
#line 15 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                          x => x.Rate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Format", "£###.00");
                __builder2.AddAttribute(26, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<VatRate>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(27, "\r\n\t\t\t");
                    __builder3.OpenElement(28, "input");
                    __builder3.AddAttribute(29, "type", "number");
                    __builder3.AddAttribute(30, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                 x => AddChangeToQueue(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Format", "£###.00");
                    __builder3.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                        context.Rate

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => context.Rate = __value, context.Rate, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n\t");
                __builder2.OpenComponent<BlazorTable.Column<VatRate>>(36);
                __builder2.AddAttribute(37, "Title", "");
                __builder2.AddAttribute(38, "Template", (Microsoft.AspNetCore.Components.RenderFragment<VatRate>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n\t\t\t");
                    __builder3.AddMarkupContent(40, "<button class=\"btn btn-danger\" disabled=\"disabled\">-</button>\r\n\t\t");
                }
                ));
                __builder2.AddAttribute(41, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<VatRate>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n\t\t\t");
                    __builder3.OpenElement(43, "button");
                    __builder3.AddAttribute(44, "class", "btn btn-danger");
                    __builder3.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                       x => DeleteVatRate(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(46, "-");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n\t");
                __builder2.OpenComponent<BlazorTable.EmptyDataTemplate>(49);
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\r\n\t\t");
                    __builder3.AddMarkupContent(52, "<p>No VAT Rates</p>\r\n\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n\t");
                __builder2.OpenComponent<BlazorTable.LoadingDataTemplate>(54);
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(56, "\r\n\t\t");
                    __builder3.AddMarkupContent(57, "<p>Loading VAT Rates</p>\r\n\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(59, (__value) => {
#nullable restore
#line 9 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
             TableVatRate = (BlazorTable.Table<VatRate>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-info");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                         x => ToggleAddFields()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "disabled", 
#nullable restore
#line 35 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                             disableAddButton

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "hidden", 
#nullable restore
#line 36 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
              hideAddFields

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, "\r\n\t");
            __builder.OpenElement(70, "table");
            __builder.AddAttribute(71, "class", "table-borderless");
            __builder.AddMarkupContent(72, "\r\n\t\t");
            __builder.AddMarkupContent(73, "<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<td width=\"50%\">Description</td>\r\n\t\t\t\t<td width=\"20%\">Vat Rate</td>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t");
            __builder.OpenElement(74, "tbody");
            __builder.AddMarkupContent(75, "\r\n\t\t\t");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "\r\n\t\t\t\t");
            __builder.OpenElement(78, "td");
            __builder.AddMarkupContent(79, "\r\n\t\t\t\t\t");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "id", "vatdescription");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "style", "width:100%");
            __builder.AddAttribute(84, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                                                                             x => descriptionKeyHandler(x.Key)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "required", true);
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                   newVatRate.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newVatRate.Description = __value, newVatRate.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\t\t\t\t");
            __builder.OpenElement(90, "td");
            __builder.AddMarkupContent(91, "\r\n\t\t\t\t\t");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "id", "vatrate");
            __builder.AddAttribute(94, "type", "number");
            __builder.AddAttribute(95, "style", "width:100%");
            __builder.AddAttribute(96, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                                                                 x => vatrateKeyHandler(x.Key)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onfocus", "this.select()");
            __builder.AddAttribute(98, "step", "0.01");
            __builder.AddAttribute(99, "required", true);
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                              newVatRate.Rate

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newVatRate.Rate = __value, newVatRate.Rate, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\t\t\t\t");
            __builder.OpenElement(104, "td");
            __builder.AddMarkupContent(105, "\r\n\t\t\t\t\t");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "id", "submit");
            __builder.AddAttribute(108, "class", "btn btn-info");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
                                                                         x => AddNewVatRate(newVatRate)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(110, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Darren\source\repos\RetailGuardianInvoices\RetailGInvoices\Pages\VatRateMaint.razor"
       
	private ITable<VatRate> TableVatRate;

	private VatRate[] vatRates;
	private VatRate newVatRate;

	private string editButtonText = "Edit";

	private bool hideAddFields = true;
	private bool disableAddButton = true;

	private List<VatRate> descriptionChangeQueue;

	private bool _disableEditButton;
	private bool disableEditButton
	{
		get
		{
			bool returnValue = true;
			if (vatRates != null)
			{
				if (vatRates.Length != 0)
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
		newVatRate = new VatRate();
		descriptionChangeQueue = new List<VatRate>();

		await GetVatRates();
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
			Task tmp = Focus("vatdescription");
		}
	}

	public void descriptionKeyHandler(string keyPressed)
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

	private async Task AddNewVatRate(VatRate vatRate)
	{
		await PostNewVatRate(vatRate);
		await GetVatRates();
		hideAddFields = true;
	}

	private async Task PostNewVatRate(VatRate vatRate)
	{
		try
		{
			await Http.PostJsonAsync($"api/VatRates", vatRate);
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
			newVatRate = new VatRate();
			await Focus("vatdescription");
		}
	}

	private async Task ToggleEdit()
	{
		TableVatRate.ToggleEditMode();

		if (TableVatRate.IsEditMode == true)
		{
			descriptionChangeQueue = new List<VatRate>();
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

	private void AddChangeToQueue(VatRate vatRate)
	{
		descriptionChangeQueue.Add(vatRate);
	}

	private async Task SaveChanges()
	{
		try
		{
			foreach (VatRate vatRate in descriptionChangeQueue)
			{
				string payload = JsonConvert.SerializeObject(vatRate);

				StringContent content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");
				await Http.PutAsync($"api/VatRates/{vatRate.Id}", content);
			}
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine(ex.Message);
		}
	}

	private async Task DeleteVatRate(VatRate vatRate)
	{
		try
		{
			HttpResponseMessage response = await Http.DeleteAsync($"api/VatRates/{vatRate.Id}");
			if (response.IsSuccessStatusCode)
			{
				await GetVatRates();
				StateHasChanged();
			}
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine(ex.Message);
		}
	}
	private async Task GetVatRates()
	{
		try
		{
			vatRates = await Http.GetJsonAsync<VatRate[]>("api/VatRates");
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

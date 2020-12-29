#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\SupplierMaint.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ed99b04e50f8a8ba41042a333d99bb284bba1a"
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
using RetailGInvoices.Data;

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
#line 2 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\SupplierMaint.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SupplierMaint")]
    public partial class SupplierMaint : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\SupplierMaint.razor"
           
		private ITable<Supplier> TableSupplier;

		private List<Supplier> filteredSuppliers;
		private List<Supplier> allSuppliers;

		private string editText = "Edit";

		private bool disableEditButton = false;

		private bool _showDeleted;
		private bool showDeleted
		{
			get
			{
				return _showDeleted;
			}

			set
			{
				_showDeleted = value;
				filteredSuppliers = GetSuppliers(value);
			}
		}

		protected override async Task OnInitializedAsync()
		{
			allSuppliers = await GetSuppliers();
			filteredSuppliers = GetSuppliers(false);
		}

		private async Task<List<Supplier>> GetSuppliers()
		{
			try
			{
				return await Http.GetJsonAsync<List<Supplier>>("api/Suppliers");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private List<Supplier> GetSuppliers(bool showDeletedSuppliers)
		{
			if (allSuppliers == null)
			{
				return new List<Supplier>();
			}
			else
			{
				if (showDeletedSuppliers)
				{
					return allSuppliers;
				}
				else
				{
					return allSuppliers.Where(f => f.Deleted == false).ToList();
				}
				
			}
		}

		private async Task<bool> DeleteSupplier(Supplier supplier)
		{
			bool reply = false;

			try
			{


			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}

			return reply;
		}

		private void ToggleEdit()
		{
			TableSupplier.ToggleEditMode();

			if (TableSupplier.IsEditMode)
			{
				editText = "Save Changes";
			}
			else
			{
				editText = "Edit";
			}
		}
	

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

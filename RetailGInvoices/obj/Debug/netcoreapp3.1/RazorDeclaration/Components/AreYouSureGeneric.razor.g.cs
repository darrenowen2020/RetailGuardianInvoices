#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\AreYouSureGeneric.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0e1be4fdbd366ee469180d7a6ed3ad4e566e5e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RetailGInvoices.Components
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
#line 15 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class AreYouSureGeneric : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\AreYouSureGeneric.razor"
       
	private bool finished = false;
	private string _reply;

	[Parameter]
	public string reply
	{
		get => _reply;

		set
		{
			_reply = value;
			if (finished)
			{
				showModal = false;
				replyChanged.InvokeAsync(value);
			}
		}
	}

	[Parameter]
	public EventCallback<string> replyChanged { get; set; }

	private bool _showModal;
	[Parameter]
	public bool showModal
	{
		get
		{
			return _showModal;
		}
		set
		{
			_showModal = value;
			if (value)
			{
				ModalDisplay = "block;";
				ModalClass = "Show";
				ShowBackdrop = true;
			}
			else
			{
				ModalDisplay = "none";
				ModalClass = "";
				ShowBackdrop = false;
			}
		}
	}

	[Parameter]
	public string modalTextBody { get; set; }

	[Parameter]
	public string modalTextHeader { get; set; }

	public Guid Guid = Guid.NewGuid();
	public string ModalDisplay = "none;";
	public string ModalClass = "";
	public bool ShowBackdrop = false;

	public void Close()
	{
		finished = true;
		reply = "NO";
	}

	public void Yes()
	{
		finished = true;
		reply = "YES";
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

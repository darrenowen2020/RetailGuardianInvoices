#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03666f2f5cc1fde8ff020af790ce7db814b42418"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class InformationModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 4 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 4 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
                                                                           ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n\t");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n\t\t");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n\t\t\t");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "\r\n\t\t\t\t");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddContent(18, 
#nullable restore
#line 8 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
                                         modalTextHeader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "close");
            __builder.AddAttribute(23, "data-dismiss", "modal");
            __builder.AddAttribute(24, "aria-label", "Close");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
                                                                                                      () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(27, "<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\t\t\t");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal-body");
            __builder.AddMarkupContent(32, "\r\n\t\t\t\t");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, 
#nullable restore
#line 14 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
                    modalTextBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t\t");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-footer");
            __builder.AddMarkupContent(39, "\r\n\t\t\t\t");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn btn-secondary");
            __builder.AddAttribute(43, "data-dismiss", "modal");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
                                                                                               () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "OK");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 25 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\t<div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 28 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InformationModal.razor"
       
	private bool finished = false;
	private string _reply;
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

	public Guid Guid = Guid.NewGuid();
	public string ModalDisplay = "none;";
	public string ModalClass = "";
	public bool ShowBackdrop = false;

	public void Close()
	{
		finished = true;
		reply = "OK";
	}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

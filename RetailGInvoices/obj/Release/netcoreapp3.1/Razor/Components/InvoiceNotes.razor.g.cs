#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e6bcce520a2c73154670d6e1bccbdd92e5efd4"
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
    public partial class InvoiceNotes : RetailGInvoices.Pages.Invoices
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
 if (showModal)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 5 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 5 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
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
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Invoice Notes</h5>\r\n\t\t\t\t");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
                                                                                                      () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\t\t\t");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body");
            __builder.AddMarkupContent(29, "\r\n\t\t\t\t");
            __builder.OpenElement(30, "textarea");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
                                                      notes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notes = __value, notes));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\t\t\t");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-footer");
            __builder.AddMarkupContent(38, "\r\n\t\t\t\t");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
                                                                        () => SaveChanges()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Save changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\t\t\t\t");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-secondary");
            __builder.AddAttribute(48, "data-dismiss", "modal");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
                                                                                               () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 24 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "\r\n\r\n");
#nullable restore
#line 27 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "\t<div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 30 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Components\InvoiceNotes.razor"
       
	private string _notes;

	[Parameter]
	public string notes
	{
		get => _notes;

		set
		{
			if (_notes == value) return;
			_notes = value;
			NotesChanged.InvokeAsync(value);
		}
	}

	[Parameter]
	public EventCallback<string> NotesChanged { get; set; }

	private bool _showModal;
	[Parameter]
	public bool showModal {
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

	public Guid Guid = Guid.NewGuid();
	public string ModalDisplay = "none;";
	public string ModalClass = "";
	public bool ShowBackdrop = false;

	public void Close()
	{
		showModal = false;
	}

	public void SaveChanges()
	{
		showModal = false;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb38c711c9c7655d98fdc08f55fd6eb674e865fe"
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
#line 2 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
using RetailGInvoices.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Periods")]
    public partial class Periods : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
 if (periods == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t");
            __builder.AddMarkupContent(1, "<p>Loading the period data..</p>\r\n");
#nullable restore
#line 9 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                  periodObj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\t");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table-borderless");
                __builder2.AddMarkupContent(8, "\r\n\t\t");
                __builder2.AddMarkupContent(9, "<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Period No</th>\r\n\t\t\t\t<th>Start Date</th>\r\n\t\t\t\t<th>End Date</th>\r\n\t\t\t\t<th></th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\r\n\t\t");
                __builder2.OpenElement(10, "tr");
                __builder2.AddMarkupContent(11, "\r\n\t\t\t");
                __builder2.OpenElement(12, "td");
                __builder2.AddMarkupContent(13, "\r\n\t\t\t\t");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "number");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                            periodObj.PeriodNo

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => periodObj.PeriodNo = __value, periodObj.PeriodNo, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\t\t\t");
                __builder2.OpenElement(20, "td");
                __builder2.AddMarkupContent(21, "\r\n\t\t\t\t");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "date");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                          periodObj.StartDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => periodObj.StartDate = __value, periodObj.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\t\t\t");
                __builder2.OpenElement(28, "td");
                __builder2.AddMarkupContent(29, "\r\n\t\t\t\t");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "date");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                          periodObj.EndDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => periodObj.EndDate = __value, periodObj.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\t\t\t");
                __builder2.OpenElement(36, "td");
                __builder2.AddMarkupContent(37, "\r\n\t\t\t\t");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "class", "btn btn-info");
                __builder2.AddAttribute(40, "title", "Add");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                     (x) => AddPeriod()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(42, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n\t");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(50, "title", "Toggle Edit Mode");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                               (x) => ToggleEdit()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Toggle Edit Mode");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.AddMarkupContent(54, "\t");
            __builder.OpenComponent<BlazorTable.Table<Period>>(55);
            __builder.AddAttribute(56, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Period>>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                     periods

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                     20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ColumnReorder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "SelectionType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.SelectionType>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                                             SelectionType.Single

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "RowClickAction", new System.Action<Period>(
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                                                                                   RowClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Column<Period>>(63);
                __builder2.AddAttribute(64, "Title", "Period No");
                __builder2.AddAttribute(65, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Period, System.Object>>>(
#nullable restore
#line 43 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                              x => x.PeriodNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "Width", "10%");
                __builder2.AddAttribute(68, "DefaultSortColumn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 43 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Period>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n\t\t\t\t");
                    __builder3.OpenElement(71, "input");
                    __builder3.AddAttribute(72, "type", "number");
                    __builder3.AddAttribute(73, "class", "form-control form-control-sm");
                    __builder3.AddAttribute(74, "oninput", "");
                    __builder3.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                   context.PeriodNo

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => context.PeriodNo = __value, context.PeriodNo, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Column<Period>>(79);
                __builder2.AddAttribute(80, "Title", "Start Date");
                __builder2.AddAttribute(81, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Period, System.Object>>>(
#nullable restore
#line 48 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                               x => x.StartDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "Width", "10%");
                __builder2.AddAttribute(84, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Period>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(85, "\r\n\t\t\t\t");
                    __builder3.AddContent(86, 
#nullable restore
#line 50 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                  context.StartDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(87, "\r\n\t\t\t");
                }
                ));
                __builder2.AddAttribute(88, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Period>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(89, "\r\n\t\t\t\t");
                    __builder3.OpenElement(90, "input");
                    __builder3.AddAttribute(91, "type", "date");
                    __builder3.AddAttribute(92, "class", "form-control form-control-sm");
                    __builder3.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                 context.StartDate

#line default
#line hidden
#nullable disable
                    , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => context.StartDate = __value, context.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\r\n\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Column<Period>>(97);
                __builder2.AddAttribute(98, "Title", "End Date");
                __builder2.AddAttribute(99, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Period, System.Object>>>(
#nullable restore
#line 56 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                             x => x.EndDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "Width", "10%");
                __builder2.AddAttribute(102, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Period>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(103, "\r\n\t\t\t\t");
                    __builder3.AddContent(104, 
#nullable restore
#line 58 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                  context.EndDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(105, "\r\n\t\t\t");
                }
                ));
                __builder2.AddAttribute(106, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Period>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(107, "\r\n\t\t\t\t");
                    __builder3.OpenElement(108, "input");
                    __builder3.AddAttribute(109, "type", "date");
                    __builder3.AddAttribute(110, "class", "form-control form-control-sm");
                    __builder3.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                 context.EndDate

#line default
#line hidden
#nullable disable
                    , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => context.EndDate = __value, context.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n\t\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.EmptyDataTemplate>(115);
                __builder2.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(117, "\r\n\t\t\t");
                    __builder3.AddMarkupContent(118, "<div class=\"text-center\">\r\n\t\t\t\tNo rows found!\r\n\t\t\t</div>\r\n\t\t");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n\t\t");
                __builder2.OpenComponent<BlazorTable.Pager>(120);
                __builder2.AddAttribute(121, "ShowPageNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 69 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ShowTotalCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 69 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n\t");
            }
            ));
            __builder.AddComponentReferenceCapture(124, (__value) => {
#nullable restore
#line 42 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                    Table = (BlazorTable.Table<Period>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n\t");
            __builder.OpenElement(126, "table");
            __builder.AddAttribute(127, "hidden", 
#nullable restore
#line 71 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                    hideButtons

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(128, "class", "table-borderless");
            __builder.AddMarkupContent(129, "\r\n\t\t");
            __builder.OpenElement(130, "tr");
            __builder.AddMarkupContent(131, "\r\n\t\t\t");
            __builder.OpenElement(132, "td");
            __builder.AddMarkupContent(133, "\r\n\t\t\t\t");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "class", "btn btn-info");
            __builder.AddAttribute(136, "title", "Submit Changes");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                (x) => submitChanges()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(138, "Submit Changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\t\t\t");
            __builder.OpenElement(141, "td");
            __builder.AddMarkupContent(142, "\r\n\t\t\t\t");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "class", "btn btn-danger");
            __builder.AddAttribute(145, "title", "Delete");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                          (x) => DeleteRow()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(147, "Delete Period ");
            __builder.AddContent(148, 
#nullable restore
#line 77 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
                                                                                                              rowID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 81 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
	
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\darre\source\repos\RetailGInvoices\RetailGInvoices\Pages\Periods.razor"
       
	private ITable<Period> Table;
	private Period[] periods;
	private bool changedFlag = false;

	private int newPeriodNo;
	private DateTime newStartDate;
	private DateTime newEndDate;

	private Period periodObj = new Period();
	private bool hideButtons = true;
	private string rowID;
	private Period activePeriod;

	protected override async Task OnInitializedAsync()
	{
		periods = await Http.GetJsonAsync<Period[]>("/api/Periods");
	}
	private void ToggleEdit()
	{
		Table.ToggleEditMode();
		if (Table.IsEditMode == false)
		{
			hideButtons = true;
			activePeriod = null;
		}

	}

	private void setChangedFlag()
	{
		changedFlag = true;
	}

	private void AddPeriod()
	{
		Task tmp = PostPeriod();
	}

	private async Task PostPeriod()
	{
		await Http.PostJsonAsync<Period>("/api/Periods", periodObj);
		await refreshTable();

	}

	private async Task UpdatePeriod(Period updatePeriod)
	{
		await Http.SendJsonAsync(HttpMethod.Put, "/api/Periods/" + updatePeriod.Id, updatePeriod);
	}

	private void submitChanges()
	{
		foreach (var period in periods)
		{
			Task tmpTask = UpdatePeriod(period);

		}
	}

	private async Task refreshTable()
	{
		periods = await Http.GetJsonAsync<Period[]>("/api/Periods");
		this.StateHasChanged();
	}

	private void RowClick(Period periodSelected)
	{
		rowID = periodSelected.PeriodNo.ToString();
		activePeriod = periodSelected;

		if (Table.IsEditMode)
		{
			hideButtons = false;
			this.StateHasChanged();
		}
	}

	private async Task DeleteRow()
	{
		await Http.DeleteAsync("/api/Periods/" + activePeriod.Id);
		periods = await Http.GetJsonAsync<Period[]>("/api/Periods");
		this.StateHasChanged();
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Anno.Models.Sample;

namespace Anno.Pages
{
    public partial class AddOrderDetailComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SampleService Sample { get; set; }

        IEnumerable<Anno.Models.Sample.Order> _getOrdersResult;
        protected IEnumerable<Anno.Models.Sample.Order> getOrdersResult
        {
            get
            {
                return _getOrdersResult;
            }
            set
            {
                if(!object.Equals(_getOrdersResult, value))
                {
                    _getOrdersResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<Anno.Models.Sample.Product> _getProductsResult;
        protected IEnumerable<Anno.Models.Sample.Product> getProductsResult
        {
            get
            {
                return _getProductsResult;
            }
            set
            {
                if(!object.Equals(_getProductsResult, value))
                {
                    _getProductsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        Anno.Models.Sample.OrderDetail _orderdetail;
        protected Anno.Models.Sample.OrderDetail orderdetail
        {
            get
            {
                return _orderdetail;
            }
            set
            {
                if(!object.Equals(_orderdetail, value))
                {
                    _orderdetail = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var sampleGetOrdersResult = await Sample.GetOrders();
            getOrdersResult = sampleGetOrdersResult.Value.AsODataEnumerable();

            var sampleGetProductsResult = await Sample.GetProducts();
            getProductsResult = sampleGetProductsResult.Value.AsODataEnumerable();

            orderdetail = new Anno.Models.Sample.OrderDetail();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Anno.Models.Sample.OrderDetail args)
        {
            try
            {
                var sampleCreateOrderDetailResult = await Sample.CreateOrderDetail(orderDetail:orderdetail);
                DialogService.Close(orderdetail);
            }
            catch (Exception sampleCreateOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new OrderDetail!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

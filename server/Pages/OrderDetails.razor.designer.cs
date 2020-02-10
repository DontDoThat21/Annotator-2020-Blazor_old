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
    public partial class OrderDetailsComponent : ComponentBase
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

        protected RadzenGrid<Anno.Models.Sample.OrderDetail> grid0;

        IEnumerable<Anno.Models.Sample.OrderDetail> _getOrderDetailsResult;
        protected IEnumerable<Anno.Models.Sample.OrderDetail> getOrderDetailsResult
        {
            get
            {
                return _getOrderDetailsResult;
            }
            set
            {
                if(!object.Equals(_getOrderDetailsResult, value))
                {
                    _getOrderDetailsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        int _getOrderDetailsCount;
        protected int getOrderDetailsCount
        {
            get
            {
                return _getOrderDetailsCount;
            }
            set
            {
                if(!object.Equals(_getOrderDetailsCount, value))
                {
                    _getOrderDetailsCount = value;
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

        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddOrderDetail>("Add Order Detail", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var sampleGetOrderDetailsResult = await Sample.GetOrderDetails(filter:$"{args.Filter}", top:args.Top, skip:args.Skip, orderby:$"{args.OrderBy}", expand:$"Order,Product", count:args.Top != null && args.Skip != null);
                getOrderDetailsResult = sampleGetOrderDetailsResult.Value.AsODataEnumerable();

                getOrderDetailsCount = sampleGetOrderDetailsResult.Count;
            }
            catch (Exception sampleGetOrderDetailsException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load OrderDetails");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Anno.Models.Sample.OrderDetail args)
        {
            var result = await DialogService.OpenAsync<EditOrderDetail>("Edit Order Detail", new Dictionary<string, object>() { {"Id", args.Id} });
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var sampleDeleteOrderDetailResult = await Sample.DeleteOrderDetail(id:data.Id);
                if (sampleDeleteOrderDetailResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception sampleDeleteOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete OrderDetail");
            }
        }
    }
}

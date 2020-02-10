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
    public partial class OrdersComponent : ComponentBase
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

        protected RadzenGrid<Anno.Models.Sample.Order> grid0;

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

        int _getOrdersCount;
        protected int getOrdersCount
        {
            get
            {
                return _getOrdersCount;
            }
            set
            {
                if(!object.Equals(_getOrdersCount, value))
                {
                    _getOrdersCount = value;
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
            var result = await DialogService.OpenAsync<AddOrder>("Add Order", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var sampleGetOrdersResult = await Sample.GetOrders(filter:$"{args.Filter}", top:args.Top, skip:args.Skip, orderby:$"{args.OrderBy}", count:args.Top != null && args.Skip != null);
                getOrdersResult = sampleGetOrdersResult.Value.AsODataEnumerable();

                getOrdersCount = sampleGetOrdersResult.Count;
            }
            catch (Exception sampleGetOrdersException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load Orders");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Anno.Models.Sample.Order args)
        {
            var result = await DialogService.OpenAsync<EditOrder>("Edit Order", new Dictionary<string, object>() { {"Id", args.Id} });
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var sampleDeleteOrderResult = await Sample.DeleteOrder(id:data.Id);
                if (sampleDeleteOrderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception sampleDeleteOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Order");
            }
        }
    }
}

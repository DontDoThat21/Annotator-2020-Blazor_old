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
    public partial class ProductsComponent : ComponentBase
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

        protected RadzenGrid<Anno.Models.Sample.Product> grid0;

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

        int _getProductsCount;
        protected int getProductsCount
        {
            get
            {
                return _getProductsCount;
            }
            set
            {
                if(!object.Equals(_getProductsCount, value))
                {
                    _getProductsCount = value;
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
            var result = await DialogService.OpenAsync<AddProduct>("Add Product", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var sampleGetProductsResult = await Sample.GetProducts(filter:$"{args.Filter}", top:args.Top, skip:args.Skip, orderby:$"{args.OrderBy}", count:args.Top != null && args.Skip != null);
                getProductsResult = sampleGetProductsResult.Value.AsODataEnumerable();

                getProductsCount = sampleGetProductsResult.Count;
            }
            catch (Exception sampleGetProductsException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load Products");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Anno.Models.Sample.Product args)
        {
            var result = await DialogService.OpenAsync<EditProduct>("Edit Product", new Dictionary<string, object>() { {"Id", args.Id} });
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var sampleDeleteProductResult = await Sample.DeleteProduct(id:data.Id);
                if (sampleDeleteProductResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception sampleDeleteProductException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Product");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Radzen;
using Anno.Models.Sample;

namespace Anno
{
    public partial class SampleService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;

        public SampleService()
        {
            this.httpClient = new HttpClient();
            this.baseUri = new Uri("https://services.radzen.com/odata/");
        }
        partial void OnGetOrders(HttpRequestMessage requestMessage);
        public async Task<ODataServiceResult<Order>> GetOrders(string filter = default(string), int? top = default(int?), int? skip = default(int?), string orderby = default(string), string expand = default(string), string select = default(string), bool? count = default(bool?))
        {
            var uri = new Uri(baseUri, $"Orders");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetOrders(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Order>>();
        }
        partial void OnCreateOrder(HttpRequestMessage requestMessage);
        public async Task<Order> CreateOrder(Order order)
        {
            var uri = new Uri(baseUri, $"Orders");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(order), Encoding.UTF8, "application/json");

            OnCreateOrder(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Order>();
        }
        partial void OnGetOrderById(HttpRequestMessage requestMessage);
        public async Task<Order> GetOrderById(int id)
        {
            var uri = new Uri(baseUri, $"Orders({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetOrderById(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Order>();
        }
        partial void OnDeleteOrder(HttpRequestMessage requestMessage);
        public async Task<HttpResponseMessage> DeleteOrder(int id)
        {
            var uri = new Uri(baseUri, $"Orders({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteOrder(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnUpdateOrder(HttpRequestMessage requestMessage);
        public async Task<Order> UpdateOrder(int id, Order order)
        {
            var uri = new Uri(baseUri, $"Orders({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(order), Encoding.UTF8, "application/json");

            OnUpdateOrder(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Order>();
        }
        partial void OnGetOrderDetails(HttpRequestMessage requestMessage);
        public async Task<ODataServiceResult<OrderDetail>> GetOrderDetails(string filter = default(string), int? top = default(int?), int? skip = default(int?), string orderby = default(string), string expand = default(string), string select = default(string), bool? count = default(bool?))
        {
            var uri = new Uri(baseUri, $"OrderDetails");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetOrderDetails(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<OrderDetail>>();
        }
        partial void OnCreateOrderDetail(HttpRequestMessage requestMessage);
        public async Task<OrderDetail> CreateOrderDetail(OrderDetail orderDetail)
        {
            var uri = new Uri(baseUri, $"OrderDetails");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(orderDetail), Encoding.UTF8, "application/json");

            OnCreateOrderDetail(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<OrderDetail>();
        }
        partial void OnGetOrderDetailById(HttpRequestMessage requestMessage);
        public async Task<OrderDetail> GetOrderDetailById(int id)
        {
            var uri = new Uri(baseUri, $"OrderDetails({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetOrderDetailById(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<OrderDetail>();
        }
        partial void OnDeleteOrderDetail(HttpRequestMessage requestMessage);
        public async Task<HttpResponseMessage> DeleteOrderDetail(int id)
        {
            var uri = new Uri(baseUri, $"OrderDetails({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteOrderDetail(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnUpdateOrderDetail(HttpRequestMessage requestMessage);
        public async Task<OrderDetail> UpdateOrderDetail(int id, OrderDetail orderDetail)
        {
            var uri = new Uri(baseUri, $"OrderDetails({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(orderDetail), Encoding.UTF8, "application/json");

            OnUpdateOrderDetail(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<OrderDetail>();
        }
        partial void OnGetProducts(HttpRequestMessage requestMessage);
        public async Task<ODataServiceResult<Product>> GetProducts(string filter = default(string), int? top = default(int?), int? skip = default(int?), string orderby = default(string), string expand = default(string), string select = default(string), bool? count = default(bool?))
        {
            var uri = new Uri(baseUri, $"Products");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProducts(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Product>>();
        }
        partial void OnCreateProduct(HttpRequestMessage requestMessage);
        public async Task<Product> CreateProduct(Product product)
        {
            var uri = new Uri(baseUri, $"Products");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            OnCreateProduct(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }
        partial void OnGetProductById(HttpRequestMessage requestMessage);
        public async Task<Product> GetProductById(int id)
        {
            var uri = new Uri(baseUri, $"Products({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProductById(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }
        partial void OnDeleteProduct(HttpRequestMessage requestMessage);
        public async Task<HttpResponseMessage> DeleteProduct(int id)
        {
            var uri = new Uri(baseUri, $"Products({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteProduct(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnUpdateProduct(HttpRequestMessage requestMessage);
        public async Task<Product> UpdateProduct(int id, Product product)
        {
            var uri = new Uri(baseUri, $"Products({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            OnUpdateProduct(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }
    }
}

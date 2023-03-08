using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task PlaceOrder();
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailResponse> GetOrderDetails(int orderId);
    }
}

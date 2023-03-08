namespace BlazorEcommerce.Server.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> PlaceOrder();
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();

        Task<ServiceResponse<OrderDetailResponse>> GetOrderDetails(int orderId);
    }
}

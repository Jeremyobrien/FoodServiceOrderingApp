namespace FoodServiceOrderingApp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}

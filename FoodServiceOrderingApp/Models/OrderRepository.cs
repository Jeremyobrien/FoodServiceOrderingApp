namespace FoodServiceOrderingApp.Models
{
    public class OrderRepository : IOrderRepository
        {
            private readonly FoodServiceOrderingAppDbContext _foodServiceOrderingAppDbContext;
            private readonly IShoppingCart _shoppingCart;

            public OrderRepository(FoodServiceOrderingAppDbContext foodServiceOrderingAppDbContext, IShoppingCart shoppingCart)
            {
                _foodServiceOrderingAppDbContext = foodServiceOrderingAppDbContext;
                _shoppingCart = shoppingCart;
            }

            public void CreateOrder(Order order)
            {
                order.OrderPlaced = DateTime.Now;

                List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
                order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

                order.OrderDetails = new List<OrderDetail>();

                foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
                {
                    var orderDetail = new OrderDetail
                    {
                        Amount = shoppingCartItem.Amount,
                        PieId = shoppingCartItem.Pie.PieId,
                        Price = shoppingCartItem.Pie.Price
                    };

                    order.OrderDetails.Add(orderDetail);
                }

                _foodServiceOrderingAppDbContext.Orders.Add(order);

                _foodServiceOrderingAppDbContext.SaveChanges();
            }
        }
}

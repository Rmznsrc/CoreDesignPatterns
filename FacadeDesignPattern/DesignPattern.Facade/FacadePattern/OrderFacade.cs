using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrder(int customerID, int productID, int orderID, int productCount, decimal productPrice, decimal totalProductPrice)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);

            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productID;
            orderDetail.ProductPrice = productPrice;
            orderDetail.ProductCount = productCount;
            totalProductPrice = productCount * productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);
        }

    }
}

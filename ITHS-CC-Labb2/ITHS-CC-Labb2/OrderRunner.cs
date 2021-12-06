using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public static class OrderRunner
    {
        public static void RunOrder()
        {
            var orderToHandle = OrderFactory.CreateOrder();

            OrderService orderService = new OrderService(
                new OrderProviderRepository(orderToHandle,
                new EmailHandlerOrderRepository(orderToHandle),
                new OrderLogMessagesRepository(orderToHandle.Id)));

            orderService.ProcessOrder();
        }
    }
}

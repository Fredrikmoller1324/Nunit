using ITHS_CC_Labb2.Data.Repositories;
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
            var random = new Random();
            List<IOrderModel> orders = new List<IOrderModel>()
            {
                OrderFactory.CreateLowPriorityOrder(),
                OrderFactory.CreateHighPriorityOrder(),
                OrderFactory.CreateUrgentPriorityOrder()
            };

            int index = random.Next(orders.Count);

            var orderToHandle = orders[index];

            OrderService orderService = new OrderService(
                orderToHandle,
                new OrderLogMessagesRepository(orderToHandle),
                new EmailHandlerOrderRepository(orderToHandle)
                );

            orderService.Process();
        }
    }
}

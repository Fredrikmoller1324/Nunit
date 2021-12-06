using ITHS_CC_Labb2.Data.Entities;
using ITHS_CC_Labb2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class EmailHandlerOrderRepository : IEmailHandlerRepository
    {
        private readonly IOrderModel _order;

        public EmailHandlerOrderRepository(IOrderModel order)
        {
            _order = order;
        }
        public void SendNotifictionEmail()
        {
            // Some email sending logic we don't care about
            Console.WriteLine($"{DateTime.Now}: Notification sent to email {_order.Email} for order {_order.Id}");
        }
    }
}

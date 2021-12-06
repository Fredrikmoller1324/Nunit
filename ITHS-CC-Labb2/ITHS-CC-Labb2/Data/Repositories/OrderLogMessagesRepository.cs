using ITHS_CC_Labb2.Data.Entities;
using ITHS_CC_Labb2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderLogMessagesRepository : ILogMessagesRepository
    {
        private readonly IOrderModel _order;

        public OrderLogMessagesRepository(IOrderModel order)
        {
            _order = order;
        }
        public void UnsuccessfullLogMessage()
        {
            Console.WriteLine($"{DateTime.Now}: FAILED ORDER: Could not ship order with ID {_order.Id}");
        }

        public void SuccessLogMessage()
        {
            Console.WriteLine($"{DateTime.Now}: Succesfully processed order with ID {_order.Id}");
        }

        public void AttemptToProcess()
        {
            Console.WriteLine($"Attempting to process order with ID {_order.Id}");
        }
    }
}

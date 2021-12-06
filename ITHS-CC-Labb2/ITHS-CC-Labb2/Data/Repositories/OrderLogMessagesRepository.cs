using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderLogMessagesRepository : ILogMessagesRepository
    {
        private readonly Guid _orderId;

        public OrderLogMessagesRepository(Guid orderId)
        {
            _orderId = orderId;
        }
        public void UnsuccessfullLogMessage()
        {
            Console.WriteLine($"{DateTime.Now}: FAILED ORDER: Could not ship order with ID {_orderId}");
        }

        public void SuccessLogMessage()
        {
            Console.WriteLine($"{DateTime.Now}: Succesfully processed order with ID {_orderId}");
        }

        public void AttemptToProcess()
        {
            Console.WriteLine($"Attempting to process order with ID {_orderId}");
        }
    }
}

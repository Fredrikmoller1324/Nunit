using ITHS_CC_Labb2.Data.Entities;
using ITHS_CC_Labb2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService
    {
        private readonly IOrderModel _order;
        private readonly ILogMessagesRepository _logMessages;
        private readonly IEmailHandlerRepository _emailHandler;

        public OrderService(

            IOrderModel order,
            ILogMessagesRepository logMessages,
            IEmailHandlerRepository emailHandler
            )
        {
            _order = order;
            _logMessages = logMessages;
            _emailHandler = emailHandler;
        }

        public void Process()
        {
            _logMessages.AttemptToProcess();

            if (!_order.OrderProcessor.ProcessOrder(_order))
            {
                _logMessages.UnsuccessfullLogMessage();
                throw new ArgumentException("Order process was Unsuccesful");
            }

            _logMessages.SuccessLogMessage();
            _emailHandler.SendNotifictionEmail();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderProviderRepository : IOrderProviderRepository
    {
        private readonly Order _order;
        private readonly IEmailHandlerRepository _emailHandler;
        private readonly ILogMessagesRepository _logMessages;

        public OrderProviderRepository(Order order,IEmailHandlerRepository emailHandler, ILogMessagesRepository logMessages)
        {
            _order = order;
            _emailHandler = emailHandler;
            _logMessages = logMessages;
        }

        public void OrderIsSuccesfulOperations()
        {
            _logMessages.SuccessLogMessage();
            _emailHandler.SendNotifictionEmail();
        }

        public void OrderIsUnSuccesfulOperations()
        {
            _logMessages.UnsuccessfullLogMessage();
            throw new ArgumentException("Order process was Unsuccesful");
        }

        /// <summary>
        ///     Evaluates if order process is successfull or not 
        /// </summary>
        /// <returns> True if order was successfully processed</returns>
        public bool IsOrderProcessSuccessfull()
        {
            _logMessages.AttemptToProcess();

            switch (_order.PriorityStatus)
            {
                case OrderPriorityStatus.Normal:
                    return ProcessOrderPriorityNormal();
                case OrderPriorityStatus.Quick:
                    return ProcessOrderPriorityQuickly();
                case OrderPriorityStatus.LightningSpeed:
                    return ProcessOrderPriorityLigtningSpeed();
                default:
                    return false;
            }
        }

        public bool ProcessOrderPriorityLigtningSpeed()
        {
            //Some logic we don't care about,
            Console.WriteLine("order with lightningSpeed priority");
            return true;
        }

        public bool ProcessOrderPriorityNormal()
        {
            //Some logic we don't care about,
            Console.WriteLine("order with NormalSpeed priority");
            return true;
        }

        public bool ProcessOrderPriorityQuickly()
        {
            //Some logic we don't care about,
            Console.WriteLine("order with QuicklySpeed priority");
            return true;
        }
    }
}

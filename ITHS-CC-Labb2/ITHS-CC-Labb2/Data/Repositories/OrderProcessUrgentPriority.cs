using ITHS_CC_Labb2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Data.Entities
{
    public class OrderProcessUrgentPriority : IOrderProcessor
    {
        public bool ProcessOrder(IOrderModel order)
        {
            // Some logic we don't care about,
            Console.WriteLine("currently processing order with Urgent priority..");

            return true;
        }
    }
}

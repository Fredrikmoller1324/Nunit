using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public static class OrderFactory
    {
        public static Order CreateOrder()
        {
            return new Order(
                Guid.NewGuid(),
                100,
                OrderPriorityStatus.Quick,
                "slowEmail@example.com"
                ); 
        }
    }
}

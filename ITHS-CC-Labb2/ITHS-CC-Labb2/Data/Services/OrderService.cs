using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService
    {
      
        private readonly IOrderProviderRepository _orderProvider;

        public OrderService(IOrderProviderRepository orderProvider)
        {
            _orderProvider = orderProvider;
        }

        public void ProcessOrder()
        {
            if (!_orderProvider.IsOrderProcessSuccessfull())
            {
                _orderProvider.OrderIsUnSuccesfulOperations();
            }
           
            _orderProvider.OrderIsSuccesfulOperations();
        }
    }
}

using ITHS_CC_Labb2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Data.Entities
{
    public class HighPriorityOrder : IOrderModel
    {
        public Guid Id { get; set; }
        public int TotalPrice { get; set; }
        public IOrderProcessor OrderProcessor { get; set; } = new OrderProcessHighPriority();
        public string Email { get; set; }
    }
}

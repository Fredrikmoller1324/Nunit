using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class Order
    {
        public Guid Id { get; set; }
        public int TotalPrice { get; set; }
        public OrderPriorityStatus PriorityStatus { get; set; }
        public string Email { get; set; }

        string test;

        public Order(Guid id, int totalprice, OrderPriorityStatus priorityStatus, string email)
        {
            Id = id;
            TotalPrice = totalprice;
            PriorityStatus = priorityStatus;
            Email = email;
        }
    }

    public enum OrderPriorityStatus
    {
        Normal,
        Quick,
        LightningSpeed
    }
}

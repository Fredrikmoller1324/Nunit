using ITHS_CC_Labb2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public static class OrderFactory
    {
        public static LowPriorityOrder CreateLowPriorityOrder()
        {
            return new LowPriorityOrder()
            {
                Id = Guid.NewGuid(),
                TotalPrice = 100,
                Email = "normalEmail@example.com"
            };            
        }

        public static HighPriorityOrder CreateHighPriorityOrder()
        {

            return new HighPriorityOrder()
            {
                Id = Guid.NewGuid(),
                TotalPrice = 1000,
                Email = "QuickEmail@example.com"
            };
        }

        public static UrgentPriorityOrder CreateUrgentPriorityOrder()
        {
            return new UrgentPriorityOrder()
            {
                Id = Guid.NewGuid(),
                TotalPrice = 10000,
                Email = "LightningEmail@example.com"
            };
        }
    }
}

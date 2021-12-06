using ITHS_CC_Labb2.Data.Entities;
using ITHS_CC_Labb2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public interface IOrderProcessor
    {
        bool ProcessOrder(IOrderModel order);
    }
}

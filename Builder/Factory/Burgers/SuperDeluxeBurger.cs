using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Burgers
{
    public class SuperDeluxeBurger : Burger
    {
        public SuperDeluxeBurger(): base(2,true,true,true,true,true)
        {

        }
    }
}

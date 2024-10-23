using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturang_beställning
{
    public abstract class Order
    {

        public string OrderName { get; set; }
        public string DishName { get; set; }
        public int CookingTime { get; set; }
        public bool Delivery { get; set; }


        public Order(string orderName, string dishName, int cookingTime, bool delivery)
            
        {
            OrderName = orderName;
            DishName = dishName;
            CookingTime = cookingTime;
            Delivery = delivery;
            
        }

        

    }
}

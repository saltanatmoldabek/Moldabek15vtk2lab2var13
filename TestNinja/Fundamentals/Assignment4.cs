using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment4
    {
        public bool PricePrivilege { get; set; }
        /// <summary>
        /// Покупка билета.Если покупка оформленна на крупную сумму,
        /// заказ под большим приоритетом.
        /// </summary>
        /// <param name="sum">Сумма заказа</param>
        public void BuyBilet(int sum)
        {
            if (sum > 1500)
            {
                PricePrivilege = true;
            }
            else{ PricePrivilege = false; }
        }

    }
}

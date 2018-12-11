using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    {
        /// <summary>
        /// Получает дату рождение.
        /// И конвертирует месяц в прописные
        /// </summary>
        /// <param name="day">день</param>
        /// <param name="mounth">месяц</param>
        /// <param name="year">год</param>
        /// <returns></returns>
        public string MyBirthday(int day, int mounth,int year)
        {
            if (day<32 && day>0  && mounth<13 && mounth>0 && year>1900 && year < 2018)
            {
                if(mounth==1)
                return day + " January. " + year;
            }
            return "";
        }
       
    }
}

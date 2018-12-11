using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        /// <summary>
        /// Запуск ракеты. Если топливо не достаточно , ошибка малого топлива.
        /// Если двигатель не готов, ошибка готовности двигателя.
        /// Иначе запуск ракеты в космос.
        /// </summary>
        /// <param name="energy">Заряд топливо в процентах</param>
        /// <param name="isEngine">Состояние готовности двигателя</param>
        /// <returns></returns>
        public Raket StartRaket(double energy, bool isEngine)
        {
            if( energy < 0.8)
            {
                return new SmallEnergyError();
            }
            else if (isEngine==false)
            {
                return new EngineNotReadyError();
            }
            return new StartToSpace();
        }
        public class SmallEnergyError: Raket
        {
        }
        public class EngineNotReadyError : Raket
        {
        }

        public class StartToSpace : Raket
        {
        }
        public class Raket
        {
        }
    }
}

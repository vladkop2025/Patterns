using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

//Создадим конкретную реализацию фабрики - фабрика по производству орков : 

namespace AbstractFactoryRealExample.Factories
{
    /// <summary>
    /// У нас есть фабрика по производству орков!
    /// Саурон нервно курит в сторонке.
    /// </summary>
    class OrcFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }
        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}

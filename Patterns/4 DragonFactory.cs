using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

//Создадим конкретную реализацию фабрики - фабрика по производству драконов: 
namespace AbstractFactoryRealExample.Factories
{
    /// <summary>
    /// У нас есть фабрика по производству драконов!
    /// Дейенерис нервно курит в сторонке
    /// </summary>
    class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }
        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }
}

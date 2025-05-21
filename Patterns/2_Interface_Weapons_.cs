using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создадим модели оружия: 

namespace AbstractFactoryRealExample.Weapons
{
    /// <summary>
    ///  Базовый интерфейс для оружия
    /// </summary>
    interface IWeapon
    {
        void Attack();
    }
}

namespace AbstractFactoryRealExample.Weapons
{
    /// <summary>
    /// Топор - оружие орков
    /// </summary>
    class Axe : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Бьем топором");
        }
    }
}

namespace AbstractFactoryRealExample.Weapons
{
    /// <summary>
    /// Оружие драконов - огненное дыхание
    /// </summary>
    class FireBreath : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Дышим огнем");
        }
    }
}
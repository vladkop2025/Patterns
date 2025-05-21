using AbstractFactoryRealExample.Movements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample.Movements
{
    //модели для движений

    /// <summary>
    ///  Базовый интерфейс для движения
    /// </summary>
    interface IMovement
    {
        void Start();
    }

/// <summary>
/// Большинству наземных монстров доступен бег
/// </summary>
class RunMovement : IMovement
{
    public void Start()
    {
        Console.WriteLine("Бежим");
    }
}

/// <summary>
/// Летающим монстрам доступно движение полета
/// </summary>
class FlyMovement : IMovement
{
    public void Start()
    {
        Console.WriteLine("Летим");
    }
}
}



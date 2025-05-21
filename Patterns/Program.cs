using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;
using AbstractFactoryRealExample.Factories;

//Абстрактная фабрика (Abstract Factory) - позволяет нам создавать группы связанных объектов без привязки к конкретным классам
//Ваша система не должна зависеть от способа компоновки объектов.
//Объекты в вашей системе должны использоваться вместе и быть взаимосвязанными.

//Среди преимуществ здесь можно отметить то, что создание монстра абстрагировано от самого класса монстра.

//Но шаблон также имеет и свои недостатки. К примеру, если мы решим добавить монстрам новый объект конфигурации (например, тип брони), то придётся
//переделывать и классы фабрик, и класс монстра. То есть данный паттерн, как и все, имеет свои ограничения.

namespace AbstractFactoryRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание дракона через фабрику
            var dragon = new Monster(new DragonFactory());
            dragon.Move();
            dragon.Hit();

            Console.WriteLine();
            // Создание орка через фабрику
            var orc = new Monster(new OrcFactory());
            orc.Move();
            orc.Hit();

            Console.WriteLine();
            Console.WriteLine("Всем конец...");
        }
    }
}

/*
Начнём с общей реализации. Для этого сначала определим модели объектов, которые будет создавать наша фабрика:

abstract class AbstractProductA
{}
          
abstract class AbstractProductB    
{}
              
class ProductA1: AbstractProductA  
{}
  
class ProductB1: AbstractProductB  
{}
 
class ProductA2: AbstractProductA  
{}
              
class ProductB2: AbstractProductB      
{}   

Теперь создадим общий базовый интерфейс фабрики и две его реализации:

/// <summary>
/// Базовый интерфейс абстрактной фабрики
/// </summary>
interface IAbstractFactory
{
   // Абстрактный метод для создания продукта  A
       AbstractProductA CreateProductA();
  
   // Абстрактный метод для создания продукта  B
   AbstractProductB CreateProductB();
}
 
/// <summary>
///  Первая конкретная реализация фабрики
/// </summary>
class ConcreteFactory1: IAbstractFactory
{
   // Конкретная реализация метода для создания продукта  A
   public  AbstractProductA CreateProductA()
   {
       return new ProductA1();
   }
  
   // Конкретная реализация метода для создания продукта  B
   public AbstractProductB CreateProductB()  
   {
       return new ProductB1();
   }
}
 
/// <summary>
///  Вторая конкретная реализация фабрики
/// </summary>
class ConcreteFactory2: IAbstractFactory
{
   // Конкретная реализация метода для создания продукта  A
   public  AbstractProductA CreateProductA()
   {
       return new ProductA2();
   }
      
   // Конкретная реализация метода для создания продукта  B
   public  AbstractProductB CreateProductB()
   {
       return new ProductB2();
   }
}

И, наконец, используем это в той части приложения, где есть необходимость создания таких объектов:

/// <summary>
/// Класс, в котором нам нужно предусмотреть создание объектов фабрикой
/// </summary>
class Client
{
   private AbstractProductA _abstractProductA;
   private AbstractProductB _abstractProductB;
 
   /// <summary>
   ///  Конструктор класса, в котором происходит создание объектов фабрики
   /// </summary>
   public Client(IAbstractFactory factory)
   {
       _abstractProductB = factory.CreateProductB();
       _abstractProductA = factory.CreateProductA();
   }
 
   /// <summary>
   ///  Метод с нашей бизнес-логикой, где будут использоваться создаваемые фабрикой объекты
   /// </summary>
   public void Run()
   {}
}
Смысл здесь как раз в задании общего интерфейса для создания всех доступных типов продуктов. Каждая конкретная реализация потом используется 
для создания продуктов нужного типа.

Непосредственно код нашего приложения (там, где всё это будет использоваться) при этом будет вызывать методы фабрики для получения продуктов 
вместо того, чтобы каждый раз вызывать оператор new. При этом фабрика сама следит за тем, чтобы создать продукт нужной вариации.

Задание 17.2.2

В чём плюсы абстрактной фабрики?
1. Изолирует конкретные классы
2. Реализует принцип открытости-закрытости
3. Упрощает код программы, сокращая количество используемых классов

Верно:
1. Верно,фабрика позволяет создавать семейства связанных объектов без привязки к конкретным классам.
2. Верно, вы легко сможете добавить новые семейства продуктов.

*/ 
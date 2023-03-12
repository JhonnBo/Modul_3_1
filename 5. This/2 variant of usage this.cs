using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Рубенс Барикелло");
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.WriteLine("-------------------------------");
            Car myCar1 = new Car("Ральф Шумахер", 15);
            for (int i = 0; i <= 10; i++)
            {
                myCar1.SpeedUp(5);
                myCar1.PrintState();
            }
            Console.WriteLine("-------------------------------");
            Car myCar2 = new Car();
            for (int i = 0; i <= 10; i++)
            {
                myCar2.SpeedUp(5);
                myCar2.PrintState();
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Количество созданных машин: " + Car.Count);
        }
    }


//Другое применение this — попытка избежать избыточности при
//инициализации членов класса.Как правило,
//в классе определяется главный конструктор (главным
//выбирают конструктор с максимальным количеством
//параметров), который содержит код инициализации, 
//а все остальные конструкторы вызывают его, используя 
//this с необходимыми параметрами, чтобы избежать  дублирования кода
    class Car
    {
        private string _driverName; //Имя водителя
        private int _currSpeed;//Текущая скорость

        public static int Count;
        static Car()  // статический конструктор 
        {
            Console.WriteLine("Запуск статического конструктора\n");
            Count = 0;
        }
        public Car(string name): this(name, 10) //Конструктор c параметром 1
        {
            Console.WriteLine("Constructor with 1 string param");
            //_driverName = name;
            //_currSpeed = 10;
            //Count++;
        }

        public Car(string name, int speed) //Основной конструктор
        {
            Console.WriteLine("Main constructor");
            _driverName = name;
            _currSpeed = speed;
            Count++;
        }

        public Car():this("Неизвестный гонщик", 10) //Конструктор по умолчанию
        {
            Console.WriteLine("Default Constructor");
            //_driverName = "Михаель Шумахер";
            //Count++;
        }

        public void PrintState() //Распечатка текущих данных
        {
            Console.WriteLine($"{_driverName} " +
                $"едет со скоростью {_currSpeed} км / ч.");
        }
        public void SpeedUp(int delta) //Увеличение скорости
        {
            _currSpeed += delta;
        }
    }
}

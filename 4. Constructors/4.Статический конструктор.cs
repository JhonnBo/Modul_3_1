namespace _4._Constructors
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
            Console.WriteLine("Количество созданных машин: " + Car.Count);
        }
    }


    //Kонструктор с параметрами отличается от конструктора
    //по умолчанию собственно наличием параметров
    class Car
    {
        private string _driverName; //Имя водителя
        private int _currSpeed = 10;//Текущая скорость

        public static int Count;
        static Car()  // статический конструктор 
        {
            Console.WriteLine("Запуск статического конструктора\n");
            Count = 0;
        }
        public Car(string name) //Конструктор c параметром 1
        {
            _driverName = name;
            _currSpeed = 10;
            Count++;
        }

        public Car(string name, int speed) //Конструктор c параметром 2
        {
            _driverName = name;
            _currSpeed = speed;
            Count++;
        }

        public Car() //Конструктор по умолчанию
        {
            _driverName = "Михаель Шумахер";
            Count++;
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

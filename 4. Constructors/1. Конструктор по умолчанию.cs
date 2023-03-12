namespace _4._Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
        }
    }
}

//Конструктор по умолчанию — не принимает никаких
//параметров и предоставляется компилятором при создании
//класса.Этот конструктор полезен тем, что он обнуляет
//все числовые типы, устанавливает в false логический,
//и в null — ссылочный, следовательно, все поля объекта
//будут проинициализированы значениями по умолчанию.
//
class Car
{
    private string _driverName; //Имя водителя
    private int _currSpeed = 10;//Текущая скорость
    public Car() //Конструктор по умолчанию
    {
        _driverName = "Михаель Шумахер";
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

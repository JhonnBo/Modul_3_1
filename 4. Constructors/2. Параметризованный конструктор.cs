using System.Xml.Linq;

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
        }
    }
}

//Kонструктор с параметрами отличается от конструктора
//по умолчанию собственно наличием параметров
class Car
{
    private string _driverName; //Имя водителя
    private int _currSpeed = 10;//Текущая скорость
    public Car(string name) //Конструктор c параметром
    {
        _driverName = name;
        _currSpeed = 10;
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

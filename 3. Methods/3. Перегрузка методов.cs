namespace _3._Methods
{
    //Перегрузка методов — определение нескольких методов
    //с одинаковым именем и разной сигнатурой.
    //Еще раз уточним, что методы должны отличаться
    //только сигнатурой(количеством, типами или порядком
    //следования параметров). Тип значения, возвращаемого
    //методом, так же как и модификаторы на перегрузку не влияют!!!
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 30;
            double da = 2.5, db = 4.8;

            Console.WriteLine($"{a} + {b} = {Mathematic.Sum(a, b)}");
            Console.WriteLine($"{a} + {b} + {c} = {Mathematic.Sum(a, b, c)}");
            Console.WriteLine($"{da} + {db} = {Mathematic.Sum(da, db)}");
        }
    }

    class Mathematic
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }


}
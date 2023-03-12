namespace _6._Ref_Otu_Tuples
{
    //Кортежи предоставляют удобный способ для работы с набором
    //значений, который был добавлен в версии C# 7.0.
    //Кортеж представляет набор значений, заключенных в круглые скобки

    internal class Program
    {
        static void Main(string[] args)
        {
            var tuple = (7, 10); //тип объявляется неявно
            //В дальнейшем мы можем обращаться к каждому из этих значений
            //через поля с названиями Item[номер]:
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            tuple.Item1 += 15;
            Console.WriteLine(tuple.Item1);

            Console.WriteLine("----------------------------------------------------------");

            //тип объявляется явно:
            (string, string, int) person = ("Petr", "Petrov", 20);
            Console.WriteLine("Person: " + person);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

            Console.WriteLine("----------------------------------------------------------");

            //Мы также можем дать названия полям кортежа:
            var student = (Name: "Ivan", Surname: "Ivanov", Age: 25, Rating: 11.5);
            Console.WriteLine("student: " + student);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Rating);

            Console.WriteLine("----------------------------------------------------------");

            //Объявление неявно типизированных переменных, что
            //позволит компилятору вывести их типы
            var (Name, Age) = ("Vasya", 18);
            Console.WriteLine(Name);
            Console.WriteLine(Age);

            Console.WriteLine("----------------------------------------------------------");

            var range = (min: 0, max: 20);
            int[] ar = new int[10];
            var result = GetValues(ar, range);
            Console.WriteLine("Сумма элементов массива: " + result.sum);
            Console.WriteLine("Среднее арифметическое элементов массива: " + result.average);
        }

        private static (int sum, double average) GetValues(int[] ar, (int Min, int Max) range)
        {
            var rand = new Random();

            for (int i = 0; i < ar.Length; i++)
                ar[i] = rand.Next(range.Min, range.Max);

            var result = (sum: 0, average: 0.0);

            foreach (var item in ar)
            {
                result.sum += item;
            }
            result.average = result.sum / (double)ar.Length;

            //Кортежи могут выступать в качестве результата функции
            return result;
        }

    }
    //Одной из задач, которую позволяет элегантно решить кортеж
    //- это обмен значениями:
    //string main = "Java";
    //string second = "C#";
    //(main, second) = (second, main);
    //Console.WriteLine(main);    // C#
    //Console.WriteLine(second);  // Java
}

//деконструкция кортежа
//var t = ("post office", 3.6);
//(string destination, double distance) = t;
//Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
// Output:
// Distance to post office is 3.6 kilometers.
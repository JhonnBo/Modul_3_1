namespace _7._Params
{
//Для создания метода с переменным количеством аргументов
//можно было бы в качестве параметра передать массив значений.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма = " + Sum(new int[] { 1, 2, 3, 4, 5 }));
        }
        private static int Sum(int[] arr)
        {
            int res = 0;
            foreach (int i in arr)
                res += i;
            return res;
        }
    }
}
//Можем увидеть, что хотя результат правильный, но 
//подход явно некрасивый.
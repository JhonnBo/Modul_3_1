namespace _6._Ref_Otu_Tuples
{
    //Для того чтобы добиться передачи
    //параметров через ссылку существуют ключевые слова ref и out.
    internal class Program
    {
        private static void MyFunction(ref int i, ref int[] myArr)
        {
            Console.WriteLine("Внутри функции MyFunction до изменения i = " + i);

            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");
            i = 100;
            myArr = new int[] { 3, 2, 1 };
            Console.WriteLine("Внутри функции MyFunction после изменения i = " + i);

            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");
        }

        static void Main(string[] args)
        {
            //Аргументы, которые передаются в метод с ключевым словом ref,
            //обязательно должны быть проинициализированы, иначе
            //компилятор выдаст сообщение об ошибке.

            int i = 10;
            int[] myArr = { 1, 2, 3 };

            Console.WriteLine("Внутри метода Main до передачи в метод " +
                              "MyFunction i = " + i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");

            //Обратите внимание, что даже при вызове метода необходимо
            //указывать ключевое слово ref, информирую о том, что
            //аргументы передаются по ссылке.

            MyFunction(ref i, ref myArr);

            Console.WriteLine("Внутри метода Main после передачи в метод " +
                              "MyFunction i = " + i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");
        }
    }
}
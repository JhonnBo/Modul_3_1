namespace _6._Ref_Otu_Tuples
{
    //Параметры, обозначенные ключевым словом out, 
    //также используются для передачи по ссылке.Отличие
    //от ref состоит в том, что параметры считаются выходными
    //и соответственно компилятор разрешает не
    //инициализировать их до передачи в метод, но проследит,
    //чтобы в методе этот параметр был обязательно
    //проинициализирован (иначе будет выдано сообщение об ошибке)
    internal class Program
    {
        static void Main(string[] args)
        {
            // int i;
            GetDigit( out int i); //можно объявить переменную и здесь
            Console.WriteLine("i = " + i);
        }

        private static void GetDigit(out int digit)
        {
            //return; // Error
            digit = new Random().Next(10);
        }
    }
}
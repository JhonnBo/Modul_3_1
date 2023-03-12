namespace _9._Partial_types
{
    //А в другом файле определим следующий класс:
    internal partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        //Второй класс уже непосредственно определяет тело метода Read().
        partial void Read()
        {
            Console.WriteLine("I am reading a book");
        }
    }
}

//Стоит отметить, что по умолчанию к частичным методам применяется ряд ограничений:
// - Они не могут иметь модификаторы доступа
// - Они имеют тип void
// - Они не могут иметь out-параметры
// - Они не могут иметь модификаторы virtual, override, sealed, new или extern

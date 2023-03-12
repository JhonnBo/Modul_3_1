namespace _8._Deconstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom", 33);
            //Значения переменным из деконструктора передаюся по позиции.
            //То есть первое возвращаемое значение в виде 
            //параметра personName передается первой переменной -name, 
            //второе возващаемое значение - переменной age.
            (string name, int age) = person;

            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 33

            //При получении значений из декоnструктора нам необходимо
            //предоставить столько переменных, сколько деконструктор
            //возвращает значений.Однако бывает, что не все эти значения
            //нужны.И вместо возвращаемых значений мы можм использовать
            //прочерк _.Например, нам надо получить только возраст
            //пользователя:

            Person person1 = new Person("Jack", 25);

            (_, age) = person1;

            Console.WriteLine("Only age = " + age);    // 25
        }
    }
}

//Деконструкторы(не путать с деструкторами) позволяют 
//выполнить декомпозицию объекта на отдельные части.

class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}

//По сути деконструкторы это не более, чем синтаксический сахар. 
//Это все равно, что если бы мы написали:
//Person person = new Person("Tom", 33);
//string name; int age;
//person.Deconstruct(out name, out age);
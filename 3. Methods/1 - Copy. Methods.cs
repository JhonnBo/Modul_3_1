﻿namespace _3._Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.ShowName();
            //Вызов статического метода
            Student.ShowAcademy();
            //Получение данных от метода экземпляра
            Console.WriteLine("Оценка: " + st.GetMark());
        }
    }
    //Метод — это блок кода, содержащий ряд инструкций
    //и расположенный в классе либо структуре.Методов вне
    //определения классов — функций — в C# не существует.

    class Student
    {
        private string _firstName = "Петя";
        public void ShowName()
        {
            Console.WriteLine(_firstName);
        }
        //Специально для работы со статическими полями —
        //были введены статические методы.Эти методы, как и
        //статические поля, принадлежат классу, а не объекту. Они
        //исключают возможность вызова через объект класса
        //и соответственно не работают с нестатическими полями.

        private static string _academyName = "Компьютерная " +
                                             "академия \"ШАГ\"";
        public static void ShowAcademy()
        {
            Console.WriteLine(_academyName);
        }

        //Метод может завершить свое выполнение тремя способами:
        //1. Когда управление дойдет до завершающей фигурной
        //скобки(при этом метод ничего не возвращает).
        //2. Когда управление дойдет до ключевого слова return
        //(без возвращаемого значения и тип возвращаемого
        //значения метода — void).
        //3. Когда управление дойдет до ключевого слова return
        //(после которого стоит возвращаемое значение, метод
        //что-либо возвращает).
        public int GetMark()
        {
            //Ключево слово return
            return new Random().Next(1, 12);
        }

    }

}
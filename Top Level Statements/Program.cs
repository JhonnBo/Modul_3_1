// See https://aka.ms/new-console-template for more information
// https://learn.microsoft.com/ru-ru/dotnet/csharp/whats-new/tutorials/top-level-statements
// https://metanit.com/sharp/tutorial/1.4.php
using static System.Console;
//================================================================================
//Пользователь вводит предложение с клавиатуры.Вам
//необходимо перевернуть каждое слово предложения и
//отобразить результат на экран.
//Например:
//пользователь ввёл: sun cat dogs cup tea;
//после переворота:  nus tac sgod puc aet.

//string s333 = "sun cat dogs cup tea";

string[] sM333;// = s333.Split(" ");

sM333 = args;
char[][] sCh333 = new char[sM333.Length][];
int i = 0;
foreach (var item in sM333)
{
    sCh333[i] = item.ToCharArray();
    Array.Reverse(sCh333[i]);
    i++;
}
string rez = "";

for (int j = 0; j < sCh333.Length; j++)
{
    rez += new string(sCh333[j]) + " ";
}
//return;
PrintArgs();
WriteLine();
Console.WriteLine(rez.Trim());

// Использование своего метода
void PrintArgs()
{
    foreach (var item in args)
    {
        Console.Write(item + " ");
    }
}

//Файл с операторами верхнего уровня может также содержать пространства
//имен и определения типов, но они должны следовать за
//операторами верхнего уровня.

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }
}

//Операторы верхнего уровня упрощают создание простых программ для
//изучения новых алгоритмов. Вы можете экспериментировать с алгоритмами,
//используя разные фрагменты кода.
//Определив наиболее эффективный подход, можно выполнить рефакторинг кода,
//чтобы его было удобнее обслуживать.

//Операторы верхнего уровня упрощают программы, основанные на консоли.
//Операторы верхнего уровня выполняются в том порядке,
//в котором они следуют в файле. Их можно использовать только в одном
//исходном файле приложения.
//Если они используются более чем в одном файле, компилятор выдает ошибку.
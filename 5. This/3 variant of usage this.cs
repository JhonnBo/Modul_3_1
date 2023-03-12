using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//случай применения ключевого слова this — 
//передача методу в качестве параметра ссылки на текущий объект:

namespace Classes
{
    internal class ClassA
    {
        public void MethodA(ClassB objB)
        {
            objB.MethodB(this);
        }

    }
    internal class ClassB
    {
        public void MethodB(ClassA objA) { 
            Console.WriteLine("Working with class: {0}",objA.GetType().Name);
        }

    }
}

public class Program
{
    public static void Main()
    {
        ClassA a = new ClassA();
        ClassB b = new ClassB();
        a.MethodA(b);
    }
}

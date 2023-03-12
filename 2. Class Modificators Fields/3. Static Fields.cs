namespace _2._Class_Modificators_Fields
{

    internal class Classes
    {
        static void Main(string[] args)
        {

            Bank filial1 = new Bank();
            Bank filial2 = new Bank();
            Console.WriteLine("Первому филиалу доступно {0:C}", Bank.balance);
            Console.WriteLine("Второму филиалу доступно {0:C}", Bank.balance);
            Console.WriteLine("В первом филиале взяли кредит на 100000" + ", осталось {0:C}", Bank.balance -= 100000);
            Console.WriteLine("Второму филиалу доступно {0:C}", Bank.balance);
            Console.WriteLine("В втором филиале взяли кредит на 200000" + ", осталось {0:C}", Bank.balance -= 200000);
            Console.WriteLine("Первому филиалу доступно {0:C} ", Bank.balance);
            Console.WriteLine("В первом филиале открыли депозит на " + "200000, осталось {0:C}", Bank.balance += 200000);
            Console.WriteLine("Второму филиалу доступно {0:C} ", Bank.balance);
        }
    }
    class Bank
    {
        public static float balance = 1000000;
    }
}
//Статическое поле класса является общим для всех 
//экземпляров этого класса. Например, пускай у нас есть 
//класс Bank. В этом классе будет статическое поле balance.
//Сымитируем ситуацию, когда в любом филиале 
//банка можно будет положить деньги на депозит или взять 
//кредит. Пусть все филиалы работают с общим счетом

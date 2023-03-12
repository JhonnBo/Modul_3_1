namespace _5._This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Bill");
            Console.WriteLine(student.firstName);
        }
    }

    //Одним из возможных вариантов применения this
    //является необходимость устранения конфликта между
    //именами параметров метода и именами полей класса:
    class Student
    {
        public string firstName;
        public Student(string firstName)
        {
            this.firstName = firstName;
        }
    }
}
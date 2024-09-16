namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person();
            person.Birthday = new DateTime(1994, 12, 12);
            int age = person.CalculateCurrentAge();
            Console.WriteLine(age);
        }
    }
}

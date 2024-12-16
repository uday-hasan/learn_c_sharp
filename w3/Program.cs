using System;
namespace HelloWorld
{
    class Program
{
    static void Main(string[] args)
    {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

            
    }
}
}
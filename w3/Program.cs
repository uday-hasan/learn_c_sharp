using System;
namespace HelloWorld
{
    class Program
{
        string color = "Blue";
        static void Main(string[] args)
        {
            External newObj = new External();
            Console.WriteLine(newObj.color);

            //To define methods as a field of a class must start with public access modifier
            newObj.ExploreMethod("Program.cs file");

            
    }
}
}
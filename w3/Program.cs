using System;
namespace HelloWorld
{
    class Program
{
    static void Main(string[] args)
    {
            //String Interpolation is like JS `` feature
            string text1 = "Hello";
            string text2 = "World";

            string finalText = $"Full text is = {text1} {text2}";

            Console.WriteLine(finalText);

            
    }
}
}
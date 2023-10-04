// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("I just added this in visual studio");
Console.WriteLine("I just added this in the cmd line repo");
Console.WriteLine("This line added to show the staging area");

namespace ConsoleApp1
{
    public class Calculator
    {
        public int Add (int left, int right)
        {
            return left + right;    
        }
        public int Subtract (int left, int right)
        {
            return left - right;
        }
        public int Multiply(int left, int right)
        {
            return left * right;
        }
        public int Divide (int left, int right)
        {
            return left / right;
        }
    }
}
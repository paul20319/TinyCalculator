namespace _20260306_TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiny calculator");

            Console.Write("Summand 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Summand 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a+b}");

        }
    }
}

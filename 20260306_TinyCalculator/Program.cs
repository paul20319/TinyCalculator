namespace _20260306_TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiny calculator");

            Console.Write("Summand 1: ");
            int a = 0;
            bool ok = false;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out a);
            } while (!ok);

            Console.Write("Summand 2: ");
            int b = 0;
            ok = false;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out b);
            } while (!ok);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{a} - {b} = {a-b}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{a} * {b} = {a*b}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (b == 0)
            {
                Console.WriteLine($"{a} / {b} = undefiniert/unendlich");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            Console.ResetColor();

        }
    }
}

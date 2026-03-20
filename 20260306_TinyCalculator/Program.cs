namespace _20260306_TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiny calculator");

            int a = ReadAndCheckOperator(1);

            int b = ReadAndCheckOperator(2);

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
                Console.WriteLine($"{a} / {b} = {(double)a / b}");
            }
            Console.ResetColor();

        }
        static int ReadAndCheckOperator(int countOperator)
        {
            int operand = 0;
            bool ok = false;
            do
            {
                Console.Write($"Operand {countOperator}: ");
                ok = int.TryParse(Console.ReadLine(), out operand);
            } while (!ok);

            return operand;
        }
    }
}

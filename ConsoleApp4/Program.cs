namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            int n = 150; 
            double a1 = -200;
            double d = 0.2; 
                        
            double sum = (n / 2.0) * (2 * a1 + (n - 1) * d);

            Console.WriteLine("Сумма " + n + " первых членов арифметической прогрессии: " + sum);
        }
    }
}

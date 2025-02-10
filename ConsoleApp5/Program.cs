namespace ConsoleApp5
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
            int day = 1;
            double S = 10;
            double Roznica = 0.1;
            double sumS = 10;
            while (sumS <= 20)
            {
                day++;
                sumS += sumS * Roznica;
            }
            Console.Write($"на {day}-й день лыжник пробежит больше 20км");
        }
    }
}

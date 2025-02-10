namespace ConsoleApp2
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


            int a1 = 1;
            int d = 4;
            int n = 5;
            long sum = 0;

            Console.Write("Первые пять членов арифметической прогрессии: ");

            for (int i = 1; i <= n; i++)
            {
                int currentTerm = a1 + (i - 1) * d;
                Console.Write(currentTerm);
                if (i < n)
                {
                    Console.Write(", ");
                }
                sum += currentTerm;
            }

            Console.WriteLine("\nОбщая сумма: " + sum);
            Console.ReadKey();
        }
        
        
    }
}

namespace ConsoleApp3
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
            int vklad1 = 100;
            int roznica = 50;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int vklad2 = vklad1 + roznica * i;

                sum += vklad2;

            }
            Console.WriteLine($"Через 10 месяцев {sum} руб.");
        }
    }
}

namespace ConsoleApp1
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

            Console.WriteLine("Первые пять членов арифметической прогрессии:");

            for (int i = 0; i < 5; i++)
            {
                int Term = a1 + i * d; 
                Console.Write(Term + " "); 
            }

            Console.WriteLine(); 
        }

    }
}

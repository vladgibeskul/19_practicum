namespace ConsoleApp6
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
             double currentDistance = 10; 
        double totalDistance = 10; 
        int day = 1; 

        while (totalDistance <= 100)
        {
            day++;
            currentDistance *= 1.1; 
            totalDistance += currentDistance; 
        }

        Console.WriteLine($"Суммарный пробег превысит 100 км на {day}-й день.");
           
        }
       
        
    }
}

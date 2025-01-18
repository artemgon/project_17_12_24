using project_17_12_24.Classes;

namespace project_17_12_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                List<string> content = [];
                Rucksack rucksack = new("Black", "Nike", "Cotton", 0.5f, 10, content);
                rucksack.AddContent("T-shirt", 2); 
                Console.WriteLine();
                rucksack.AddContent("Jeans", 3);   
                Console.WriteLine();
                rucksack.AddContent("Socks", 1);  
                Console.WriteLine();
                rucksack.AddContent("Jacket", 4);
                Console.WriteLine();
                rucksack.RemoveContent("Socks", 1);
                Console.WriteLine();
                rucksack.AddContent("Shoes", 4);
                Console.WriteLine();
                rucksack.Display(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

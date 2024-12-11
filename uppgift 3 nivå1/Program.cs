using System;
namespace uppgift3
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Skriv fem heltal per rad");
            int tal = int .Parse(Console.ReadLine());
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());
            int tal4 = int.Parse(Console.ReadLine());
            Console.WriteLine(tal + tal1 + tal2 + tal3 + tal4);

        }
    }
}
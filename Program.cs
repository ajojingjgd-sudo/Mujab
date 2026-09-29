using System;

namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(String[] agrs)
        {
            Console.WriteLine("--- DEMO INHERITANCE ---\n");

            Console.WriteLine("1. Membuat objek Dwarf (dengan konstruktor berparameter)");
            Dwarf dwarf = new Dwarf(50, "timpa-001", "domoro", 100, "smigeng");
            dwarf.DisplayData();

            Console.WriteLine("\n2. Membuat objek Scarletwitch (dengan konstruktor berparameter)");
            Scarletwitch scarletwitch = new Scarletwitch(80, "HM-001", "Wanda", 90, "gondang");
            scarletwitch.DisplayData();

            Console.WriteLine("\n3. Membuat objek Monde (dengan konstruktor berparameter)");
            Monde monde = new Monde(120, 80, "MD-001", "siab", 110, "solomerto");
            monde.DisplayData1();
            


            Console.ReadKey();
        }
    }
}

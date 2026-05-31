using System;

namespace KPZ_Lab2.Builder
{
    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public string Inventory { get; set; }
        public string Alignment { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Hair: {HairColor}");
            Console.WriteLine($"Eyes: {EyeColor}");
            Console.WriteLine($"Clothes: {Clothes}");
            Console.WriteLine($"Inventory: {Inventory}");
            Console.WriteLine($"Alignment: {Alignment}");
            Console.WriteLine();
        }
    }
}

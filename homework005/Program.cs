using System;

namespace homework005
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int gems;
            int goldEqual = 5;
            Console.Write("Введите количество золото: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write(goldEqual + " золото равна 1 криссталу, сколько криссталов хотите купить?");
            gems = Convert.ToInt32 (Console.ReadLine());
            gold = gold - gems * goldEqual;
            Console.WriteLine("У вас  " + gems + " криссталов " + gold + " золото");
        }
    }
}

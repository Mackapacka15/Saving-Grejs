using System;

namespace Saving_Grejs
{
    public class Hero
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int dmg { get; set; }

        public Hero()
        {
            string svar;
            Console.WriteLine("Whats Your heros Name?");
            name = Console.ReadLine();
            Console.WriteLine("DMG?");
            svar = Console.ReadLine();
            dmg = int.Parse(svar);
            Console.WriteLine("HP?");
            svar = Console.ReadLine();
            hp = int.Parse(svar);

        }

    }
}
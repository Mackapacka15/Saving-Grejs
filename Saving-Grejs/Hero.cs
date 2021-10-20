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
            dmg = IntMaker(svar);
            Console.WriteLine("HP?");
            svar = Console.ReadLine();
            hp = IntMaker(svar);

        }
        private int IntMaker(string svar)
        {
            int temp;
            bool correct = int.TryParse(svar, out temp);
            if (!correct)
            {
                Console.WriteLine("That was not a number");
                return 10;
            }

            return temp;

        }

    }
}
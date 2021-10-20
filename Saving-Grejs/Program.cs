using System.Collections.Generic;
using System;
using System.IO;
using System.Text.Json;

namespace Saving_Grejs
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Hero> heroes = Load();
            Hero h = new Hero();
            heroes.Add(h);



            Save(heroes);
            Console.ReadLine();
        }
        static void Save(List<Hero> h)
        {
            string json = JsonSerializer.Serialize<List<Hero>>(h);
            File.WriteAllText(@"Save.json", json);
        }
        static List<Hero> Load()
        {
            List<Hero> heroes = new List<Hero>();
            string heroString = File.ReadAllText("Save.json");
            Console.WriteLine("Do you want to load progress?");
            string svar = Console.ReadLine();
            svar = svar.ToLower();
            if (svar == "yes")
            {
                heroes = JsonSerializer.Deserialize<List<Hero>>(heroString);
                return heroes;
            }
            return null;
        }

    }
}

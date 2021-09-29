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
            string heroString = File.ReadAllText("Save.json");
            List<Hero> heroes = new List<Hero>();
            Console.WriteLine("Do you want to load progress?");
            string svar = Console.ReadLine();
            svar = svar.ToLower();
            if (svar == "yes")
            {
                heroes = JsonSerializer.Deserialize<List<Hero>>(heroString);
            }
            Save(heroes);



            Console.ReadLine();
        }
        static void Save(List<Hero> h)
        {
            string json = JsonSerializer.Serialize<List<Hero>>(h);
            File.WriteAllText(@"Save.json", json);
        }

    }
}

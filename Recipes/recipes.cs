using ff14bot.Helpers;
using System.IO;

namespace crafty.Recipes
{
    public static class recipes
    {
        public static Jobs[] jobs;
        private static string 
            alchemist = "alchemist.txt",
            armorer = "armorer.txt",
            blacksmith = "blacksmith.txt",
            carpenter = "carpenter.txt",
            cullinarian = "culinarian.txt",
            goldsmith = "goldsmith.txt",
            leatherworker = "leatherworker.txt",
            weaver = "weaver.txt";

        public struct Recipe
        {
            public uint Id;
            public string Name;

            Recipe(uint id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
        }

        public struct Jobs
        {
            public ff14bot.Enums.ClassJobType job;
            public Recipe[] recipes;
        }

        public static uint buildarray()
        {
            string s;
            try {
                StreamReader alc = new StreamReader(File.Open("alchemist.txt", FileMode.Open));
                while((s = alc.ReadLine()) != null)
                {
                   
                }
            } catch (IOException e)
            {
                Logging.Write("Error reading one of the recipe ID files.");
                Logging.Write("Please check that the files exist and havent been renamed");
                Logging.Write("Stopping bot! :(");
                ff14bot.TreeRoot.Stop();
            }
            return 1;
        }
    }
}
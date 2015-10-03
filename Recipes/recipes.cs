using System.IO;

namespace crafty.Recipes
{
    public static class recipes
    {
        public static Jobs[] jobs;

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
            StreamReader alc = new StreamReader(File.Open("alchemist.txt", FileMode.Open));
            alc.ReadLine();
            return 1;
        }
    }
}
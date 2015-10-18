using ff14bot.Helpers;
using System.Collections.Generic;
using System.IO;
using ff14bot.Enums;

namespace crafty.Recipes
{
    public static class Recipes
    {
        //File information here. Including what's delimiting the IDs and the names on each line.
        private static string 
            alchemist = "alchemist.txt",
            armorer = "armorer.txt",
            blacksmith = "blacksmith.txt",
            carpenter = "carpenter.txt",
            cullinarian = "culinarian.txt",
            goldsmith = "goldsmith.txt",
            leatherworker = "leatherworker.txt",
            weaver = "weaver.txt";

        private static string workingdir = Directory.GetCurrentDirectory();
        private static string path = "\\BotBases\\Crafty\\Recipes\\";
        private static char[] delimiter = { ':' };

        //Array of our class/recipe structs
        public static Job[] jobs = {
            new Job(ClassJobType.Alchemist, ReadFile(alchemist)),
            new Job(ClassJobType.Armorer, ReadFile(armorer)),
            new Job(ClassJobType.Blacksmith, ReadFile(blacksmith)),
            new Job(ClassJobType.Carpenter, ReadFile(carpenter)),
            new Job(ClassJobType.Culinarian, ReadFile(cullinarian)),
            new Job(ClassJobType.Goldsmith, ReadFile(goldsmith)),
            new Job(ClassJobType.Leatherworker, ReadFile(leatherworker)),
            new Job(ClassJobType.Weaver, ReadFile(weaver))
        };

        public struct Recipe
        {
            public uint Id;
            public string Name;

            public Recipe(uint id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
        }

        public struct Job
        {
            public ClassJobType ClassJob;
            public List<Recipe> Recipes;

            public Job(ClassJobType job, List<Recipe> recipelist)
            {
                this.ClassJob = job;
                this.Recipes = recipelist;
            }
        }
        


        private static List<Recipe> ReadFile(string file)
        {
            List<Recipe> filecontents = new List<Recipe>();
            string line;
            try
            {
                StreamReader sr = new StreamReader(File.Open(workingdir + path + file, FileMode.Open));
                while((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(delimiter, 2);
                    uint id = uint.Parse(s[0]);
                    filecontents.Add(new Recipe(id, s[1]));
                }
            } catch (IOException e)
            {
                Logging.Write("Error reading file " + workingdir + path + file + ".");
                Logging.Write("Please check that the file exists and hasn't been renamed");
                CraftyComposite.StopBot("Error loading recipes");
            }
            return filecontents;
        }

        //Search for a recipe by name. Return empty recipe if not found.
        public static Recipe getRecipe(string name, ClassJobType job)
        {
            foreach(Job j in jobs)
            {
                if(job == j.ClassJob)
                {
                    foreach(Recipe r in j.Recipes)
                    {
                        if (r.Name.ToLower().Equals(name.ToLower()))
                        {
                            return r;
                        }
                    }
                }
            }
            return new Recipe();
        }

        //Search by id!
        public static Recipe getRecipe(uint id, ClassJobType job)
        {
            foreach (Job j in jobs)
            {
                if (job == j.ClassJob)
                {
                    foreach (Recipe r in j.Recipes)
                    {
                        if (r.Id == id)
                        {
                            return r;
                        }
                    }
                }
            }
            return new Recipe();
        }

        public static List<Recipe> getRecipe(string name)
        {
            List<Recipe> result = new List<Recipe>();
            foreach(Job j in jobs)
            {
                foreach(Recipe r in j.Recipes)
                {
                    if (r.Name.ToLower().Equals(name.ToLower()))
                    {
                        result.Add(r);
                    }
                }
            }
            return result;
        }

        public static Recipe getRecipe(uint id)
        {
            Recipe result = new Recipe();
            foreach (Job j in jobs)
            {
                foreach (Recipe r in j.Recipes)
                {
                    if (r.Id == id)
                    {
                        result = r;
                    }
                }
            }
            return result;
        }

        public static string GetJob(uint id)
        {
            foreach (var job in jobs)
            {
                foreach (var r in job.Recipes)
                {
                    if (r.Id == id)
                    {
                        if (job.ClassJob == ClassJobType.Alchemist) return "Alchemist";
                        if (job.ClassJob == ClassJobType.Armorer) return "Armorer";
                        if (job.ClassJob == ClassJobType.Blacksmith) return "Blacksmith";
                        if (job.ClassJob == ClassJobType.Carpenter) return "Carpenter";
                        if (job.ClassJob == ClassJobType.Culinarian) return "Culinarian";
                        if (job.ClassJob == ClassJobType.Goldsmith) return "Goldsmith";
                        if (job.ClassJob == ClassJobType.Leatherworker) return "Leatherworker";
                        if (job.ClassJob == ClassJobType.Weaver) return "Weaver";
                    }
                }
                
            }
            return null;
        }
    }
}
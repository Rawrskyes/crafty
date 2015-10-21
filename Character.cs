using System.Linq;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using TreeSharp;

namespace crafty
{
    public static class Character
    {
        public static int CurrentRecipeLvl;

        public static int Craftsmanship
        {
            get
            {
                return InventoryManager.EquippedItems
                    .Where(s => s.IsFilled)
                    .Where(s => s.Item.Attributes.ContainsKey(ItemAttribute.Craftsmanship))
                    .Select(s => s.Item.Attributes[ItemAttribute.Craftsmanship])
                    .Sum();
            }
        }

        public static double GetExpectedProgress(int recipeLevel)
        {
            var levelDiff = Core.Me.ClassLevel - recipeLevel;
            if (levelDiff < -9)
            {
                levelDiff = -9;
            }
            double levelCorrectionFactor;

            if ((levelDiff < -5))
            {
                levelCorrectionFactor = 0.0501*levelDiff;
            }
            else if ((-5 <= levelDiff) && (levelDiff <= 0))
            {
                levelCorrectionFactor = 0.10*levelDiff;
            }
            else if ((0 < levelDiff) && (levelDiff <= 5))
            {
                levelCorrectionFactor = 0.0493*levelDiff;
            }
            else if ((5 < levelDiff) && (levelDiff <= 15))
            {
                levelCorrectionFactor = 0.022*levelDiff + 0.15;
            }
            else
            {
                levelCorrectionFactor = 0.00134*levelDiff + 0.466;
            }

            var baseProgress = 0.209*Craftsmanship + 2.51;
            var levelCorrectedProgress = baseProgress*(1 + levelCorrectionFactor);
            return levelCorrectedProgress;
        }

        public static Composite setJob(ClassJobType job)
        {
            ff14bot.CharacterManagement.AutoEquipper.Instance.PulseAutoEquip();
            return null;
        }
    }
}
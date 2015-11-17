using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using TreeSharp;
using crafty;
using ff14bot.Helpers;
using ff14bot.NeoProfiles;
using ff14bot.RemoteWindows;

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

        public static bool ChangeRequired(ClassJobType requiredJobType)
        {
            //If we're what we need to be, don't change.
            if (Core.Me.CurrentJob == requiredJobType) return false;

            //Else we need to change.
            return true;

        }

        public static Composite ChangeJob()
        {
            var closewindow = new Action(a => CraftingLog.Close());
            var wait = new Sleep(4000);
            var windowcheck = new Decorator(condition => CraftingLog.IsOpen, closewindow);
            var changegearset = new Action(a =>
            {
                Logging.Write("Changing to gearset number: " + Crafty.OrderForm.GetJobGearSet(CraftyComposite.GetJob()));
                ChatManager.SendChat("/gs change " + Crafty.OrderForm.GetJobGearSet(CraftyComposite.GetJob()));
            });
            return new Sequence(windowcheck, wait, changegearset);
            
        }

    }
}
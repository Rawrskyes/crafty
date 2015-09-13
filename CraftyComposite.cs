using TreeSharp;
using ff14bot.Managers;
using ff14bot.Helpers;

namespace crafty
{
    internal class CraftyComposite
    {
        public static Composite getBase()
        {
            var SelectRecipe = new Action(a=>CraftingManager.SetRecipe(100));
            var CanCraft = new Decorator(true, new Action(CantCraft()));
            Selector CanWeCraft = new Selector()
            Sequence root = new Sequence(SelectRecipe, SelectSynth, BeginSynth);
            return root;
        }

       static Composite CantCraft()
        {
            return new Action(a =>
            {
                Logging.Write("Can't craft the item! Stopping");
                ff14bot.TreeRoot.Stop();
                return RunStatus.Success;
            });
        }

    }
}
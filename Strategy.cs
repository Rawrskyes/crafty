using crafty.Ability;
using ff14bot.Managers;
using TreeSharp;

namespace crafty
{
    static class Strategy
    {
        public static Composite GetComposite()
        {
          var mend = new Decorator(a=> (Mend.Available && CraftingManager.Durability == 10), Mend.UseBestMend());
          var increasequal = new Decorator(a=> (Synth.ExpectFinish() & (CraftingManager.Durability > 20 || Mend.Available) & CraftingManager.HQPercent < 100), Touch.UseBestTouch());
          var progress = Synth.UseSynth();
          return new PrioritySelector(mend, increasequal, progress);
            
        }
    }


}

using crafty.Ability;
using ff14bot;
using ff14bot.Managers;
using TreeSharp;

namespace crafty
{
    internal static class Strategy
    {
        public static Composite GetComposite()
        {
            var mend = new Decorator(a => (Mend.Available && CraftingManager.Durability == 10), Mend.UseBestMend());
            var increasequal =
                new Decorator(
                    a =>
                        (Core.Me.CurrentCP > 18 &&
                         Synth.ExpectFinish() & (CraftingManager.Durability > 20 || (Mend.Available && (Core.Me.CurrentCP - Touch.GetBestTouch().Cost) > 91)) &
                         CraftingManager.HQPercent < 100), Touch.UseBestTouch());
            var progress = Synth.UseSynth();
            var steady = new Decorator(a => Buff.SteadyRequired(), Buff.GetSteadyAction());
            var inner = new Decorator(a => Buff.InnerQuietAvail(), Buff.GetInnerQuietAction());
            return new PrioritySelector(inner, mend, steady, increasequal, progress);
        }
    }
}
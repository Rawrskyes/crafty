using TreeSharp;
using ff14bot.Managers;
using ff14bot;
using ff14bot.Helpers;

namespace crafty
{
    class util
    {
        public static RunStatus Quit(string reason)
        {
            Logging.Write(reason);
            TreeRoot.Stop();
            return RunStatus.Success
        }
    }
}

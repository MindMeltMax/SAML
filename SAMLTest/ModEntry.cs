using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace SAMLTest
{
    internal class ModEntry : Mod
    {
        internal static IModHelper IHelper;
        internal static IMonitor IMonitor;

        public override void Entry(IModHelper helper)
        {
            IHelper = Helper;
            IMonitor = Monitor;

            IHelper.Events.Input.ButtonPressed += onButtonDown;
        }

        private void onButtonDown(object? sender, ButtonPressedEventArgs e)
        {
            if (!Context.CanPlayerMove)
                return;
            if (e.Button == SButton.O)
                Game1.activeClickableMenu = new TestMenu();
        }
    }
}

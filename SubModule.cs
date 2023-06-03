using TaleWorlds.MountAndBlade;


namespace tasamphitheatre
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            Console.WriteLine("Welcome to the Ape Society!");

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            if (game.GameType is Campaign)
            {
                // Code to modify campaign behavior goes here
                // For example, adding custom logic or tweaking game mechanics
            }

            if (game.GameType is Singleplayer)
            {
                // Code to modify singleplayer behavior goes here
            }

            if (game.GameType is Multiplayer)
            {
                // Code to modify multiplayer behavior goes here
            }
        }
}
namespace Schockturnier.Data
{
    public class TurnamentContext
    {
        private TurnamentContext()
        {
            CurrentGame = new Game();
        }

        private static TurnamentContext _instance;
        public static TurnamentContext Instance => _instance ?? (_instance = new TurnamentContext());

        public Game CurrentGame { get; private set; }
    }
}

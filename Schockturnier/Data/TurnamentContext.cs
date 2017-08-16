using System.IO;
using System.Xml.Serialization;

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

        public void LoadGame(string fullFileName)
        {
            var formatter = new XmlSerializer(typeof(Game));
            using (Stream stream = new FileStream(fullFileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                var game = formatter.Deserialize(stream) as Game;
                CurrentGame = game;
            }
        }
    }
}

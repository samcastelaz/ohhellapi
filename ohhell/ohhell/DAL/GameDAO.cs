using ohhell.ContainerClasses;
using System.Xml;

namespace ohhell.DAL
{
    public class GameDAO
    {
        public GameDAO()
        {
            gameId = 0;
        }

        public GameDAO(long newGameId)
        {
            gameId = newGameId;
        }
        long gameId;
        public Game generateNewGame()
        {
            gameId++;
            XmlDocument gameDoc = new XmlDocument();
            XmlElement idElement = gameDoc.CreateElement("GameID");
            idElement.InnerXml = gameId.ToString();
            gameDoc.AppendChild(idElement);
            Game game = new Game();
            game.GameId = gameId.ToString();
            gameDoc.Save("game" + gameId.ToString() + ".xml");
            return game;
        }
    }
}

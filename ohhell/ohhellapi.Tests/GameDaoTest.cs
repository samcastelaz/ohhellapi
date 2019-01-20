using NUnit.Framework;
using ohhell.ContainerClasses;
using ohhell.DAL;
using System;
using System.Xml;
using Xunit;

namespace ohhellapi.Tests
{
    public class GameDaoTest
    {
        [Fact]
        public void GenerateNewGameSavesXMLFileWithGameIDInTitle()
        {
            Random random = new Random();
            long value = (long)((random.NextDouble() * 2.0 - 0.1) * long.MaxValue);
            GameDAO dao = new GameDAO(value);
            XmlDocument doc = new XmlDocument();
            Game game = dao.generateNewGame();
            doc.Load("game" + game.GameId.ToString() + ".xml");
            Xunit.Assert.Contains("<GameID>" + game.GameId + "</GameID>", 
                doc.InnerXml.ToString());
        }
    }
}

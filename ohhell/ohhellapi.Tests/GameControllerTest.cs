using Microsoft.AspNetCore.Mvc;
using ohhell.ContainerClasses;
using ohhell.Controllers;
using ohhell.DAL;
using Rhino.Mocks;
using System;
using Xunit;

namespace ohhellapi.Tests
{
    public class GameControllerTest
    {
        GameController _controller;

        public GameControllerTest()
        {
            _controller = new GameController();
        }

        [Fact]
        public void CreateReturnsJSONStringOfGameId()
        {
            Game game = new Game();
            game.GameId = "1234";

            var gameId = _controller.Create();           
            Assert.Equal("{\"gameid\":\"1\"}", gameId.Value);
        }
    }
}

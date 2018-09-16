using Microsoft.AspNetCore.Mvc;
using ohhell.Controllers;
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
            var gameId = _controller.Create();
            Assert.Equal("{\"gameid\":\"1234\"}", gameId.Value);
        }
    }
}

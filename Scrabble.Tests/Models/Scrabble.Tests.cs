using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Scrabble.Models;
namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void Letter_Grabs_Correct_Value()
        {
            ScrabbleGame game = new ScrabbleGame();
            Assert.AreEqual(1, ScrabbleGame.Letters['A']);
        }
        [TestMethod]
        public void Word_Returns_Right_Value()
        {
            ScrabbleGame game = new ScrabbleGame();
            game.Play = "xenu";
            Assert.AreEqual(game.CountUp(), 11);
        }
    }
}
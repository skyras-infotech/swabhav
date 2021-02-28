using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTaeGameAppUsingOOAD.Model;

namespace Test_TTT
{
    [TestClass]
    public class Test_Game
    {
        [TestMethod]
        [ExpectedException(typeof(OutOfCellException))]
        public void Test_PlayForOutOfCellException()
        {
            Player player1 = new Player("SK", Mark.O);
            Player player2 = new Player("PK", Mark.X);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(new Board(3));
            Game game = new Game(resultAnalyzer,player1,player2);
            game.Play(10);

        }


        [TestMethod]
        [ExpectedException(typeof(CellAlreadyOccupiedException))]
        public void Test_PlayForCellAlreadyOccupiedException()
        {
            Player player1 = new Player("SK", Mark.O);
            Player player2 = new Player("PK", Mark.X);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(new Board(3));
            Game game = new Game(resultAnalyzer, player1, player2);
            game.Play(2);
            game.Play(2);

        }
    }
}

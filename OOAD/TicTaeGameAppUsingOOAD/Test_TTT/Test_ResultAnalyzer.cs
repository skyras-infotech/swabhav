using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTaeGameAppUsingOOAD.Model;

namespace Test_TTT
{
    [TestClass]
    public class Test_ResultAnalyzer
    {
        [TestMethod]
        public void Test_CheckRowResult()
        {
            bool expected = true;
            Player player = new Player("Sumit", Mark.O);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player, 6);
            board.SetMarkInPosition(player, 7);
            board.SetMarkInPosition(player, 8);

            bool actual = resultAnalyzer.CheckRows(Mark.O,8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckColumnResult()
        {
            bool expected = true;
            Player player = new Player("Sumit", Mark.X);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player, 1);
            board.SetMarkInPosition(player, 4);
            board.SetMarkInPosition(player, 7);

            bool actual = resultAnalyzer.CheckColumn(Mark.X, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckLeftToRightDiagonalResult()
        {
            bool expected = true;
            Player player = new Player("Sumit", Mark.X);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player, 0);
            board.SetMarkInPosition(player, 4);
            board.SetMarkInPosition(player, 8);

            bool actual = resultAnalyzer.CheckLeftToRightDiagonal(Mark.X, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckRightToLeftDiagonalResult()
        {
            bool expected = true;
            Player player = new Player("Sumit", Mark.O);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player, 2);
            board.SetMarkInPosition(player, 4);
            board.SetMarkInPosition(player, 6);

            bool actual = resultAnalyzer.CheckRightToLeftDiagonal(Mark.O, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ResultWithWin()
        {
            Result expected = Result.Win;
            Player player = new Player("Sumit", Mark.O);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player, 2);
            board.SetMarkInPosition(player, 4);
            board.SetMarkInPosition(player, 6);

            Result actual = resultAnalyzer.GameResult(Mark.O, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ResultWithDraw()
        {
            Result expected = Result.Draw;
            Player player1 = new Player("Sumit", Mark.X);
            Player player2 = new Player("Yogesh", Mark.O);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player1, 0);
            board.SetMarkInPosition(player2, 1);
            board.SetMarkInPosition(player1, 2);
            board.SetMarkInPosition(player2, 4);
            board.SetMarkInPosition(player1, 3);
            board.SetMarkInPosition(player2, 5);
            board.SetMarkInPosition(player1, 7);
            board.SetMarkInPosition(player2, 6);
            board.SetMarkInPosition(player1, 8);

            Result actual = resultAnalyzer.GameResult(Mark.O, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ResultWithInprogress()
        {
            Result expected = Result.InProgress;
            Player player1 = new Player("Sumit", Mark.X);
            Player player2 = new Player("Yogesh", Mark.O);
            Board board = new Board(3);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player1, 0);
            board.SetMarkInPosition(player2, 1);
            board.SetMarkInPosition(player1, 2);
            board.SetMarkInPosition(player2, 4);
            board.SetMarkInPosition(player1, 3);
            board.SetMarkInPosition(player2, 5);

            Result actual = resultAnalyzer.GameResult(Mark.O, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckRowResultForFourCrossFour()
        {
            bool expected = true;
            Player player = new Player("Sumit", Mark.O);
            Board board = new Board(4);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            board.SetMarkInPosition(player, 8);
            board.SetMarkInPosition(player, 10);
            board.SetMarkInPosition(player, 9);
            board.SetMarkInPosition(player, 11);


            bool actual = resultAnalyzer.CheckRows(Mark.O, 8);

            Assert.AreEqual(expected, actual);
        }
    }
}

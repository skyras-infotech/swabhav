using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTaeGameAppUsingOOAD.Model;

namespace Test_TTT
{
    [TestClass]
    public class Test_Board
    {
        [TestMethod]
        public void Test_BoardIsNotFull()
        {
            bool expected = false;

            Board board = new Board(3);

            Assert.AreEqual(expected, board.CheckIBoardIsFull());
        }

        [TestMethod]
        public void Test_BoardIsFull()
        {
            bool expected = true;

            Board board = new Board(3);
            for (int i = 0; i < board.Size*board.Size; i++)
            {
                if (i % 2 == 0)
                    board.GetCells[i].Mark = Mark.O;
                else
                    board.GetCells[i].Mark = Mark.X;
            }

            Assert.AreEqual(expected, board.CheckIBoardIsFull());
        }


        [TestMethod]
        public void Test_SetMarkInPosition()
        {
            Mark expected = Mark.O;
            Player player = new Player("Sumit", Mark.O);

            Board board = new Board(3);
            board.SetMarkInPosition(player, 4);

            Assert.AreEqual(expected, board.GetCells[4].Mark);
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfCellException))]
        public void Test_SetMarkInPositionwhichIsOutOfCellRange()
        {
            Player player = new Player("Sumit", Mark.O);

            Board board = new Board(3);
            board.SetMarkInPosition(player, 10);

        }

    }
}

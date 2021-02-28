using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTaeGameAppUsingOOAD.Model;

namespace Test_TTT
{
    [TestClass]
    public class Test_Cell
    {
        [TestMethod]
        [ExpectedException(typeof(CellAlreadyOccupiedException))]
        public void Test_SetMarkWithExceptionOccured()
        {
            Cell[] cells = new Cell[9];
            for (int i = 0; i < 9; i++)
            {
                cells[i] = new Cell();
            }   
            cells[0].Mark = Mark.X;
            cells[1].Mark = Mark.O;
            cells[0].Mark = Mark.X;
        }

        [TestMethod]
        public void Test_SetMark()
        {
            Cell[] cells = new Cell[9];
            for (int i = 0; i < 9; i++)
            {
                cells[i] = new Cell();
            }
            cells[0].Mark = Mark.X;
            cells[1].Mark = Mark.O;
        }
    }
}

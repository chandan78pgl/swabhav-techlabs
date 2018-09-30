using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;

namespace TicTaeToeUnitTest
{
    [TestClass]
    public class TestBoard
    {
        [TestMethod]
        public void TestUpdateBoardMethod()
        {
            Board board = new Board();
            board.UpdateBoard(MarkFactory.CROSS,1);
            Assert.AreEqual(MarkFactory.CROSS.Name, board.GetCell(0).Mark.Name);
        }

        [TestMethod]
        public void TestCellsProperty()
        {
            Board board = new Board();
            Assert.AreEqual(9,board.Cells.Count);
        }

        [TestMethod]
        public void TestGetCellMethod()
        {
            Board board = new Board();
            Assert.AreEqual(MarkFactory.EMPTY.Name,board.GetCell(1).Mark.Name);
        }
        [TestMethod]
        public void TestIsBoardFilledMethod()
        {
            Board board = new Board();
            MarkType cross = MarkFactory.CROSS;
            MarkType nought = MarkFactory.NOUGHT;

            board.UpdateBoard(cross,1);
            board.UpdateBoard(cross, 2);
            board.UpdateBoard(cross, 3);
            board.UpdateBoard(cross, 4);
            board.UpdateBoard(cross, 5);
            board.UpdateBoard(cross, 9);
            board.UpdateBoard(cross, 8);
            board.UpdateBoard(cross, 7);
            board.UpdateBoard(cross, 6);

            Assert.IsTrue(board.IsBoardFilled());
        }
    }
}

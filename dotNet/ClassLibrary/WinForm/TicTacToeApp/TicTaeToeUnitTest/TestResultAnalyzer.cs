using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;

namespace TicTaeToeUnitTest
{
    [TestClass]
    public class TestResultAnalyzer
    {
        [TestMethod]
        public void TestWinResult()
        {

        }

        [TestMethod]
        public void TestDrawResult()
        {

        }

        [TestMethod]
        public void TestOnGoingResult()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            MarkType cross = MarkFactory.CROSS;
            MarkType nought = MarkFactory.NOUGHT;

            board.UpdateBoard(nought, 1);
            board.UpdateBoard(cross, 8);
            board.UpdateBoard(cross, 9);

            resultAnalyzer.AnalyzeBoard();

            Assert.AreEqual(Result.ONGOING, resultAnalyzer.Result);
        }

        [TestMethod]
        public void TestVerticalCheckWinMethod()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            MarkType cross = MarkFactory.CROSS;
            MarkType nought = MarkFactory.NOUGHT;

            board.UpdateBoard(cross, 3);
            board.UpdateBoard(cross, 6);
            board.UpdateBoard(cross, 9);

            resultAnalyzer.AnalyzeBoard();

            Assert.AreEqual(Result.WIN, resultAnalyzer.Result);
        }

        [TestMethod]
        public void TestHorizontalCheckWinMethod()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            MarkType cross = MarkFactory.CROSS;
            MarkType nought = MarkFactory.NOUGHT;

            board.UpdateBoard(cross, 7);
            board.UpdateBoard(cross, 8);
            board.UpdateBoard(cross, 9);

            resultAnalyzer.AnalyzeBoard();

            Assert.AreEqual(Result.WIN, resultAnalyzer.Result);
        }

        [TestMethod]
        public void TestDiagonalCheckWinMethod()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            MarkType cross = MarkFactory.CROSS;
            MarkType nought = MarkFactory.NOUGHT;

            board.UpdateBoard(cross, 3);
            board.UpdateBoard(cross, 5);
            board.UpdateBoard(cross, 7);

            resultAnalyzer.AnalyzeBoard();

            Assert.AreEqual(Result.WIN, resultAnalyzer.Result);
        }
    }
}

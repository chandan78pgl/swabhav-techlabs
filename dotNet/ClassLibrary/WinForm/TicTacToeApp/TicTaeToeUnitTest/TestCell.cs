using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore;
namespace TicTaeToeUnitTest
{
    [TestClass]
    public class TestCell
    {
        [TestMethod]
        public void TestSetCellMethod()
        {
            Cell cell = new Cell();
            cell.Mark = MarkFactory.CROSS;
            Assert.AreEqual(MarkFactory.CROSS.Name, cell.Mark.Name);
        }
        [TestMethod]
        public void TestIsMarkedMethod()
        {
            Cell cell = new Cell();
            cell.Mark = MarkFactory.NOUGHT;
            Assert.IsTrue(cell.IsMarked());
        }
    }
}

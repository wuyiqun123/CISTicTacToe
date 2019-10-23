using Microsoft.VisualStudio.TestTools.UnitTesting;
using CISTicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISTicTacToe.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void CreateBoardTest()
        {
            Game salt = new Game();
            int count = 0;
            char[,] toTest = salt.CreateBoard();

            for (int i = 0; i < toTest.GetLength(0); i++)
            {
                for (int j = 0; j < toTest.GetLength(1); j++)
                {
                    count++;
                }
            }

            //Assert the board has 9 active fields
            Assert.AreEqual(count, 9);
        }

        [TestMethod()]
        public void CurrentPlayerTest()
        {
            Game board1 = new Game();
            board1.CreateBoard();
            char toTest = board1.CurrentPlayer();

            //Asser the current player is X
            Assert.AreEqual('X', toTest);
        }

        [TestMethod()]
        public void ChangePlayerTest()
        {
            Game board1 = new Game();
            board1.CreateBoard();
            char toTest = board1.ChangePlayer();

            //Assert the current player is O
            Assert.AreEqual('O', toTest);
        }

        [TestMethod()]
        public void MakeMoveTest()
        {
            Game board1 = new Game();
            char[,] boardToTest = board1.CreateBoard();
            board1.MakeMove(1, 1);
            char toTest = board1.board[1, 1];

            //Assert that the current player places an X in a spot on the board
            Assert.AreEqual('X', toTest);
        }






        [TestMethod()]
        public void MakeMoveTest2()
        {
            Game board1 = new Game();
            char[,] boardToTest = board1.CreateBoard();
            board1.ChangePlayer();
            board1.MakeMove(1, 1);
            char toTest = board1.board[1, 1]; 
            //Assert that the current player places an O in a spot on the board
            Assert.AreEqual(toTest, 'O');
        }


        [TestMethod()]
        public void SpaceInUseTest()
        {
            Game board1 = new Game();
            board1.CreateBoard();
            board1.MakeMove(1, 1);
            board1.MakeMove(1, 1);
            char toTest = board1.board[1, 1];

            //Assert that the placement is an unoccupied spot
            Assert.AreEqual('X', toTest);
        }
    }
}
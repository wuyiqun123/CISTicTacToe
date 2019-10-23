using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISTicTacToe
{
    public class Game
    {
        public char[,] board;
        public char player;

        public Game()
        {
            board = new char[3, 3];
            player = 'X';
        }

        public char[,] CreateBoard()
        {
            board = new char[3, 3];
            player = 'X';

            return board;
        }

        public char CurrentPlayer()
        {
            return player;
        }

        public char ChangePlayer()
        {
            if (player == 'X')
                player = 'O';
            else
                player = 'X';
            return player;
        }

        public void MakeMove(int x, int y)
        {
            if (!SpaceInUse(x, y))
            {
                board[x, y] = player;
                ChangePlayer();
            }
        }

        public bool SpaceInUse(int x, int y)
        {
            return (board[x, y] == 'X' || board[x, y] == 'O');
        }
    }
}


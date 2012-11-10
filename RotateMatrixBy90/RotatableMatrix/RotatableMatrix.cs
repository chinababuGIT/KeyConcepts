using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;


namespace RotatableMatrix
{
    public class Matrix
    {
        private readonly int[,] _chessBoard;

        public Matrix(int a,int b)
        {
            _chessBoard = new int[a,b];
            for(int i =0; i < a;i++)
            {
                for (int j = 0; j < b; j++)
                {
                    _chessBoard[i, j] = RandomGenerator(0, 10);
                }
            }
        }

        public Matrix(int a): this (a,a)
        {}

        public void Print()
        {
          Contract.Requires(_chessBoard != null);
          long a = _chessBoard.GetLongLength(0);
          long b = _chessBoard.GetLongLength(1);
          Console.WriteLine();
          for(int i =0; i < a; i++)
          {
              for(int j=0; j< b; j++)
              {
                  Console.Write("{0}", _chessBoard[i, j]);
              }
              Console.WriteLine();
          }
        }
        private int RandomGenerator(int min, int max)
        {
            var rand = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), NumberStyles.HexNumber));
            return rand.Next(min, max);
        }

    }
}

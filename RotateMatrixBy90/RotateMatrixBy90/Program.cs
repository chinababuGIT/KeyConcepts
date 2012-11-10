using System;
using System.Collections.Generic;
using System.Text;

//From Crackin the Coding Interview FourthEdition
//Rotate an N*N Matrix by 90 degrees. Can you do it in place?(relative sequence of cells are preserved)

//Analysis. 
//An N*N matrix is a square matrix. N can be even or Odd.
//Do it in place meaning there is no restriction on the values in matrix. Duplicate values allowed

//Method 1 do it by recurrsion.
//Base case when Matrix is 1x1 OR Less, no opertion required. Just return
//Hint for recursion, Matrix ix N*N, immediate recurrsion inferred is either
//breaking it into chessboard or in onion layer. Qucik check that chessboard won't get anywhere
//fall back to onion.
//Assume we are at layer K, allfours corners of matrix are:
//(1,yer,

//
using System;
using RotatableMatrix;

namespace RotateMatrixBy90
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix _matrix = new Matrix(10,10);
            _matrix.Print();
        }
    }
}

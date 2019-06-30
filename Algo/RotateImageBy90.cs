using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
    public class RotateImageBy90
    {
        //        Given input matrix = 
        //[
        //  [1,2,3],
        //  [4,5,6],
        //  [7,8,9]
        //],

        //rotate the input matrix in-place such that it becomes:
        //[
        //  [7,4,1],
        //  [8,5,2],
        //  [9,6,3]
        //]

        //Reverse matrix example: [[1,2,3],[4,5,6],[7,8,9]] ==> [[7,8,9],[4,5,6],[1,2,3]]
        public void Rotate(int[][] matrix)
        {
            Array.Reverse(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int val = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = val;
                }
            }
        }
    }
}

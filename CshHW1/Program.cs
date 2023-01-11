using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1
            Random r = new Random();
            /*
            int[] A = new int[5];
            int[][] B = new int[3][];
            

            for(int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("\n");


            for (int i = 0; i < B.Length; i++)
            {
                B[i] = new int[4];
                for(int j = 0; j < B[i].Length; j++)
                {
                    B[i][j] = r.Next(1, 20);
                    Console.Write($"{B[i][j]} ");
                }
                Console.WriteLine();
            }

            //find max and min in A
            int maxInA = A[0];
            int minInA = A[0];
            int summA = 0;
            int multA = 1;
            int summOfEven = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if(maxInA < A[i])
                    maxInA = A[i];
                if(minInA > A[i])
                    minInA = A[i];
                summA += A[i];
                multA *= A[i];
                if(A[i] % 2 == 0)
                    summOfEven += A[i];
            }

            Console.WriteLine($"\nMax in A is {maxInA}, Min in A is {minInA}, summ of array is {summA}, multiplication of elements in A is {multA}, summ of even numbers {summOfEven}");

            //find max and min in B
            int maxInB = B[0][0];
            int minInB = B[0][0];
            int summB = 0;
            long multB = 1;
            int summOfOdd = 0;

            for(int i = 0; i < B.Length; i++)
            {
                for(int j = 0; j < B[i].Length; j++)
                {
                    if(maxInB < B[i][j])
                        maxInB = B[i][j];
                    if (minInB > B[i][j])
                        minInB = B[i][j];
                    summB += B[i][j];
                    multB *= B[i][j];
                    if (B[i][j] % 2 != 0)
                        summOfOdd += B[i][j];

                }
            }

            Console.WriteLine($"Max in B is {maxInB}, Min in B is {minInB}, summ of array is {summB}, multiplication of elements in B is {multB}, summ of odd numbers {summOfOdd}");

            Console.ReadKey();
           */
            //task 2

            int minPos = 0;
            int maxPos = 0;

            int[,] matrix2 = new int[5, 5];

            for(int i =0; i < matrix2.GetLength(0); i++)
            {
                for(int j = 0; j < matrix2.GetLength(1); j ++)
                {
                    matrix2[i, j] = r.Next(-100, 100);
                    Console.Write($"{matrix2[i, j]} ");
                    if()
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

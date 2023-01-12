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
           


            //task 2


            
            int minPos = 0;
            int minEl = 0;
            int maxPos = 0;
            int maxEl = 0;
            int summEl = 0;

            int[,] matrix2 = new int[5, 5];
            int[] temp = new int[25];
            int tempi = 0;

            for(int i =0; i < matrix2.GetLength(0); i++)
            {
                for(int j = 0; j < matrix2.GetLength(1); j ++)
                {
                    matrix2[i, j] = r.Next(-100, 100);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }


            for(int i =0; i < matrix2.GetLength(0); i++)
            {
                for(int j = 0; j< matrix2.GetLength(1); j ++)
                {
                    temp[tempi] = matrix2[i, j];
                    tempi++;
                }
            }

            minEl = temp[0];
            maxEl = temp[0];
            for(int i = 0; i < temp.Length; i++)
            {
                if(minEl > temp[i])
                {
                    minEl = temp[i];
                    minPos = i;
                }
                if (maxEl < temp[i])
                {
                    maxEl = temp[i];
                    maxPos = i;
                }
            }

            Console.WriteLine($"min el {minEl}, min pos {minPos}, max el {maxEl}, max pos {maxPos}");

            if(minPos > maxPos)
            {
                for(int i = maxPos; i <= minPos; i++)
                {
                    summEl += temp[i];
                }
            }
            else
            {
                for (int i = minPos; i <= maxPos; i++)
                {
                    summEl += temp[i];
                }
            }

            Console.WriteLine($"The summ of the elements is {summEl}");

            Console.ReadKey();

            


            //task3


            
            string stringForEncode;
            string encodedString = "";
            char temp;

            Console.WriteLine("Please enter string for encode:");
            stringForEncode = Console.ReadLine();

            for(int i =0; i < stringForEncode.Length; i++)
            {
                temp = stringForEncode[i];
                temp = (char)(temp + 3);
                encodedString += temp;
            }
            Console.WriteLine();
            Console.WriteLine(encodedString);


            Console.WriteLine("Encoding:");
            for (int i = 0; i < encodedString.Length; i++)
            {
                temp = encodedString[i];
                temp = (char)(temp - 3);
                Console.Write(temp);
            }

            Console.ReadKey();
            

            //task 4

            void multMatrix(int [][] matrix, char simbol, int number, int [][] matrix2 = null)
            {
                if(simbol == '*')
                {
                    for(int i =0; i < matrix.Length; i++)
                    {
                        for(int j = 0; j < matrix[i].Length; j++)
                        {
                            matrix[i][j] = matrix[i][j] * number;
                        }
                    }
                }
                else if(simbol =='+')
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            matrix[i][j] = matrix[i][j] + matrix2[i][j];
                        }
                    }
                }
                else if(simbol == 'm')
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            matrix[i][j] = matrix[i][j] * matrix2[i][j];
                        }
                    }
                }

            }

            //making matrix1, 2

            int[][] myMatrix = new int[3][];
            for(int i = 0; i < myMatrix.Length; i++)
            {
                myMatrix[i] = new int[4];
            }

            int[][] myMatrix2 = new int[3][];
            for (int i = 0; i < myMatrix2.Length; i++)
            {
                myMatrix2[i] = new int[4];
            }

            //adding numbers to matrix1, 2
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for(int j = 0; j < myMatrix[i].Length; j++)
                {
                    myMatrix[i][j] = r.Next(1, 12);
                }
            }

            for (int i = 0; i < myMatrix2.Length; i++)
            {
                for (int j = 0; j < myMatrix2[i].Length; j++)
                {
                    myMatrix2[i][j] = r.Next(1, 12);
                }
            }

            //matrix before
            Console.WriteLine("Before: ");
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    Console.Write($"{myMatrix[i][j]} ");
                }
                Console.WriteLine();
            }

            //mult matrix to two

            multMatrix(myMatrix, '*', 2);

            //matrix after
            Console.WriteLine("After *2: ");
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    Console.Write($"{myMatrix[i][j]} ");
                }
                Console.WriteLine();
            }

            multMatrix(myMatrix, '+', 3, myMatrix2);

            Console.WriteLine("After +: ");
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    Console.Write($"{myMatrix[i][j]} ");
                }
                Console.WriteLine();
            }

            multMatrix(myMatrix, 'm', 3, myMatrix2);

            Console.WriteLine("After m: ");
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    Console.Write($"{myMatrix[i][j]} ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

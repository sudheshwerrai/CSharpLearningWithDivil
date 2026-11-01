
using System;

namespace CSharpLearning
{
    class ArrayInCSharp
    {
        static void Main()
        {

            //1,2,3
            int a = 1, b = 2, c = 3;

            //1,2,3,4,5,6,7,8,9,10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Lowest Index=0-1
            //Highest Index=lenghth-1=10-1=9-10

            //Arrays Types in C#
            //1.Single Dimensional Array
            //2.Multi Dimensional Array
            //3.Jagged Array

            //1.Single Dimensional Array
            //First way to create a single dimensional array
            int[] firstArray = new int[5];
            firstArray[0] = 11;
            firstArray[1] = 2;
            firstArray[2] = 3;
            firstArray[3] = 3;
            firstArray[4] = 5;
            //Array.Resize(ref firstArray, 1);
            //firstArray[5] = 15;

            //Second way to create a single dimensional array
            int[] secondArray = new int[] { 1, 2, 3, 4, 5 };

            //Third way to create a single dimensional array
            int[] thirdArray = { 1, 2, 3, 4, 5 };

            //Array.Sort(firstArray);
            //foreach (int item in firstArray)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Reverse(firstArray);
            //int index = Array.IndexOf(firstArray, 3);
            //int index = Array.LastIndexOf(firstArray, 3);
            //Console.WriteLine("Index of 3: " + index);

            //foreach (int item in firstArray)
            //{
            //    Console.WriteLine(item);
            //}


            //2.Multi Dimensional Array

            //First way to create a multi dimensional array
            int[,] firstMultiDimensionalArray = new int[2, 3];
            //First Row
            firstMultiDimensionalArray[0, 0] = 1;
            firstMultiDimensionalArray[0, 1] = 2;
            firstMultiDimensionalArray[0, 2] = 3;
            //Second Row
            firstMultiDimensionalArray[1, 0] = 4;
            firstMultiDimensionalArray[1, 1] = 5;
            firstMultiDimensionalArray[1, 2] = 6;
            //Third Row
            //firstMultiDimensionalArray[2, 0] = 7;
            //firstMultiDimensionalArray[2, 1] = 8;
            //firstMultiDimensionalArray[2, 2] = 9;

            //Second way to create a multi dimensional array
            int[,] secondMultiDimensionalArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //Third way to create a multi dimensional array
            int[,] thirdMultiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < firstMultiDimensionalArray.GetLength(0); i++)//Rows
            //{
            //    for (int j = 0; j < firstMultiDimensionalArray.GetLength(1); j++)//Columns
            //    {
            //        Console.Write(firstMultiDimensionalArray[i, j] + " ");
            //    }               
            //    Console.WriteLine();
            //}

            //3.Jagged Array
            //First way to create a jagged array
            int[][] firstJaggedArray = new int[3][];
            firstJaggedArray[0] = new int[2] { 1, 2 };
            firstJaggedArray[1] = new int[3] { 3, 4, 5 };
            firstJaggedArray[2] = new int[2] { 6, 7 };

            //Second way to create a jagged array
            int[][] secondJaggedArray = new int[3][]
            {
                new int[2] { 1, 2 },
                new int[3] { 3, 4, 5 },
                new int[2] { 6, 7 }
            };

            //Third way to create a jagged array
            int[][] thirdJaggedArray = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7 }
            };

            Console.WriteLine("First Jagged Array:" + firstJaggedArray.Length);
            for (int i = 0; i < firstJaggedArray.Length; i++)
            {
                for (int j = 0; j < firstJaggedArray[i].Length; j++)
                {
                    Console.Write(firstJaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            //First way to create a jagged array
            int[][,] firstMultiJaggedArray = new int[3][,];
            firstMultiJaggedArray[0] = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            firstMultiJaggedArray[1] = new int[1, 2] { { 7, 8 } };
            firstMultiJaggedArray[2] = new int[2, 3] { { 13, 14, 15 }, { 16, 17, 18 } };

        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LAB9_STT
//{
//    class Task3
//    {
//        //Bubble Sort Algorithm
//        static List<int> BubSor(List<int> a)
//        {
//            int n = a.Count;
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = 0; j < n - i - 1; j++)
//                {
//                    if (a[j] > a[j + 1])
//                    {
//                        int temp = a[j];
//                        a[j] = a[j + 1];
//                        a[j + 1] = temp;
//                    }
//                }
//            }
//            return a;
//        }
//        //Convert 2D array to 1D array in row-major order
//        static int[] ToRowMajor(int[,] matrix)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);
//            int[] result = new int[rows * cols];
//            int k = 0;
//            for (int i = 0; i < rows; i++)
//                for (int j = 0; j < cols; j++)
//                    result[k++] = matrix[i, j];
//            return result;
//        }

//        // Store 2-D array into 1-D array in column-major order
//        static int[] ToColumnMajor(int[,] matrix)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);
//            int[] result = new int[rows * cols];
//            int k = 0;
//            for (int j = 0; j < cols; j++)
//                for (int i = 0; i < rows; i++)
//                    result[k++] = matrix[i, j];
//            return result;
//        }
//        //Matrix Multiplication
//        static int[,] MultiplyMatrices(int[,] A, int[,] B)
//        {
//            int aRows = A.GetLength(0);
//            int aCols = A.GetLength(1);
//            int bRows = B.GetLength(0);
//            int bCols = B.GetLength(1);

//            if (aCols != bRows)
//                throw new ArgumentException("Number of columns in A must equal number of rows in B.");

//            int[,] C = new int[aRows, bCols];
//            for (int i = 0; i < aRows; i++)
//                for (int j = 0; j < bCols; j++)
//                    for (int k = 0; k < aCols; k++)
//                        C[i, j] += A[i, k] * B[k, j];
//            return C;
//        }

//        // Print Matrix
//        static void PrintMatrix(int[,] matrix)
//        {
//            int rows = matrix.GetLength(0);
//            int cols = matrix.GetLength(1);
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                    Console.Write(matrix[i, j] + " ");
//                Console.WriteLine();
//            }
//        }

//        static void Main(string[] args)
//        {
//            List<int> a = new List<int> { 8, 3, 7, 4, 9, 2, 6, 5, 1 };
//            Console.WriteLine("Unsorted List:");
//            Console.WriteLine(string.Join(" ", a));
//            Console.WriteLine("\n");
//            Console.WriteLine("Sorted List:");
//            List<int> sortedList = BubSor(a);
//            Console.WriteLine(string.Join(" ", sortedList));

//            // 2-D to 1-D array
//            int[,] matrix2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//            int[] rowMajor = ToRowMajor(matrix2D);
//            int[] colMajor = ToColumnMajor(matrix2D);
//            Console.WriteLine("2-D to 1-D Row Major:");
//            Console.WriteLine(string.Join(" ", rowMajor));
//            Console.WriteLine("2-D to 1-D Column Major:");
//            Console.WriteLine(string.Join(" ", colMajor));
//            Console.WriteLine();

//            // Matrix Multiplication
//            int[,] A = { { 1, 2 }, { 3, 4 } };
//            int[,] B = { { 5, 6 }, { 7, 8 } };
//            int[,] C = MultiplyMatrices(A, B);
//            Console.WriteLine("Matrix A:");
//            PrintMatrix(A);
//            Console.WriteLine("Matrix B:");
//            PrintMatrix(B);
//            Console.WriteLine("Matrix C = A * B:");
//            PrintMatrix(C);
//        }
//    }
//}

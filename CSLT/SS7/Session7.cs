using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CSLT.CSLT.SS7
{
    internal class Session7
    {
        //1.to calculate the average value of array elements.
        static int AveR(int[] arr)
        {
            int tong = 0;
            foreach (int v in arr)
            {
                tong += v;
            }
            return tong / arr.Length;
        }


        //2.to test if an array contains a specific value.
        static bool Contain(int[] arr, int target)
        {
            foreach (var c in arr)
            {
                if (arr.Contains(target))
                {
                    return true;
                }
            }
            return false;
        }


        //3.to find the index of an array element.
        static int index(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] RemoveElement(int[] arr, int target)
        {
            int targetIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    targetIndex = i;
                    break;
                }
            }

            // Target not found; copy original array manually
            if (targetIndex == -1)
            {
                int[] same = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++) same[i] = arr[i];
                return same;
            }

            // Allocate array with one less slot
            int[] result = new int[arr.Length - 1];
            int writeIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != targetIndex)
                {
                    result[writeIndex] = arr[i];
                    writeIndex++;
                }
            }
            return result;
        }

        // 5. Find Min and Max
        static void FindMinMax(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
        }

        // 6. Reverse array in-place (Two-pointer swap)
        static void ReverseInPlace(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

        // 7. Find duplicate values (pure nested loop check)
        static int[] FindDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                bool hasDuplicateAhead = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        hasDuplicateAhead = true;
                        break;
                    }
                }

                if (hasDuplicateAhead)
                {

                    bool alreadyRecorded = false;
                    for (int k = 0; k < count; k++)
                    {
                        if (temp[k] == arr[i])
                        {
                            alreadyRecorded = true;
                            break;
                        }
                    }

                    if (!alreadyRecorded)
                    {
                        temp[count] = arr[i];
                        count++;
                    }
                }
            }


            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        // 8. Remove duplicate elements (keeps first occurrences)
        static int[] RemoveDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                bool isDuplicate = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (temp[j] == arr[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp[uniqueCount] = arr[i];
                    uniqueCount++;
                }
            }


            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        //Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        //Request a sentence from the user, then ask to enter a word.Search if the word appears in the phrase using the linear search algorithm.
        static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static int LinearSearch(string[] words, string target)
        {
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        static void TaoMangNgauNhien(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void PrintMatrix(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintRow(int[,] mat, int rowIndex)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            Console.Write($"Hang {rowIndex}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mat[rowIndex, j] + "\t");
            }
            Console.WriteLine();
        }

        static void PrintCol(int[,] mat, int colIndex)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            Console.Write($"Cot {colIndex}: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(mat[i, colIndex] + "\t");
            }
            Console.WriteLine();
        }


        static int FindMax(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int max = mat[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                    }
                }
            }
            return max;
        }

        
        static int FindMinOfRow(int[,] mat, int rowIndex)
        {
            int cols = mat.GetLength(1);
            int min = mat[rowIndex, 0];

            for (int j = 1; j < cols; j++)
            {
                if (mat[rowIndex, j] < min)
                {
                    min = mat[rowIndex, j];
                }
            }
            return min;
        }

        static int FindMinOfCol(int[,] mat, int colIndex)
        {
            int rows = mat.GetLength(0);
            int min = mat[0, colIndex];

            for (int i = 1; i < rows; i++)
            {
                if (mat[i, colIndex] < min)
                {
                    min = mat[i, colIndex];
                }
            }
            return min;
        }

        
        static int[,] Transpose(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = mat[i, j];
                }
            }
            return result;
        }

       
        static void PrintDiagonals(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("Khong phai ma tran vuong, khong co duong cheo.");
                return;
            }

            Console.Write("Duong cheo chinh: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(mat[i, i] + "\t");
            }
            Console.WriteLine();

            Console.Write("Duong cheo phu: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(mat[i, rows - 1 - i] + "\t");
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
        {
        

           

            
        }
    }
}

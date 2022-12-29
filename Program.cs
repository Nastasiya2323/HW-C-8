// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] New2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 int maxj = k;
//                 if (array[i, j] > array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Enter row:   ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols:   ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min:   ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max:   ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = New2dArray(rows, cols, min, max);
// ShowArray(array);
// Console.WriteLine();
// int[,] changeArray = ChangeArray(array);
// ShowArray(changeArray);



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] New2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Minsum(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         Console.WriteLine("Указан неверный размер массива!");
//     }

//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         int sumrow1 = 0;                                //нахожу значение суммы элементов в первой строке (индекс k=0)
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             sumrow1 = sumrow1 + array[0, k];
//         }
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;                                    //ввожу параметр sum  после описания цикла for 
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum = sum + array[i, j];                    //нахожу значение суммы в строке
//             }

//             int minsum=0;
//             if (sum < sumrow1 && sum > minsum)             //сравниваю значение сумм в каждой с троке с первой //для случая, когда значений сумм строк, которых меньше sumrow1, несколько
//             {
//                 sumrow1 = sum;                             //присваиваю значению sum значение, которое меньше
//                 minsum=sum;
//                 Console.WriteLine($"Номер строки наименьшей суммой элементов: {i + 1} строка.");
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Enter row:   ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols:   ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min:   ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max:   ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = New2dArray(rows, cols, min, max);
// ShowArray(array);
// Console.WriteLine();
// int[,] rowmin = Minsum(array);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Matrix1(int rows, int cols, int min1, int max1)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min1, max1 + 1);
//         }
//     }
//     return array;
// }

// int[,] Matrix2(int rows, int cols, int min2, int max2)
// {
//     int[,] arr = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             arr[i, j] = new Random().Next(min2, max2 + 1);
//         }
//     }
//     return arr;
// }

// void ShowMatrix1(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// void ShowMatrix2(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Proizv(int[,] array, int[,] arr)
// {
//     int[,] proizvArray = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int m = 0; m < array.GetLength(0); m++)
//                 proizvArray[i, j] += array[i, m] * arr[m, j];
//         }
//     }
//     return proizvArray;
// }

// void ShowproizvArray(int[,] proizvArray)
// {
//     for (int i = 0; i < proizvArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < proizvArray.GetLength(1); j++)
//         {
//             Console.Write(proizvArray[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter row:   ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols:   ");
// int cols = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter min1:   ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max1:   ");
// int max1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter min2:   ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max2:   ");
// int max2 = Convert.ToInt32(Console.ReadLine());

// int[,] array = Matrix1(rows, cols, min1, max1);
// int[,] arr = Matrix2(rows, cols, min2, max2);
// ShowMatrix1(array);
// Console.WriteLine();
// ShowMatrix2(arr);
// Console.WriteLine();
// if (array.GetLength(0) != array.GetLength(1))
// {
//     Console.WriteLine("Указан неверный размер массива");
// }
// else
// {
//     int[,] proizvArray = Proizv(array, arr);
//     ShowproizvArray(proizvArray);
// }


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }



int[,,] Create3DArray(int rows, int cols, int pages)
{
    int[,,] array = new int[rows, cols, pages];
    int[] values = new int[89];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temporary = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temporary;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Enter row:   ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter cols:   ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter pages:   ");
int pages = Convert.ToInt32(Console.ReadLine());

Create3DArray(rows, cols, pages);
int[,,]array = Create3DArray(rows, cols, pages);
Show3DArray(array);

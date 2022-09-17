// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] GenArray(int numb)

// {
//     int[] arr = new int[numb];

//     for (int i = 0; i < numb; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }

//     return arr;

// }

// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length - 1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }

//     System.Console.Write(array[length - 1]);
// }

// int FindEvenNumb(int[] array)
// {   int count = 0;
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count += 1; 
//         }
//     }
//     return count;
// }

// var arr = GenArray(n);
// var count = FindEvenNumb(arr);
// PrintArray(arr);
// System.Console.WriteLine();
// System.Console.WriteLine($"Количество чётных чисел в массиве => {count}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int mingen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - верхняя граница интервала");
// int maxgen = Convert.ToInt32(Console.ReadLine());

// int[] GenArray(int numb, int mingen, int maxgen)
// {
//     int[] arr = new int[numb];
//     for (int i = 0; i < numb; i++)
//     {
//         arr[i] = new Random().Next(mingen, maxgen + 1);
//     }

//     return arr;
// }

// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length - 1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write(array[length - 1]);
// }
// int SumOddIndex(int[] array)

// {
//     int length = array.Length;
//     int sum = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             sum = array[i] + sum;

//         }
//     }
//     return sum;
// }

// var arr = GenArray(n, mingen, maxgen);
// var sum  = SumOddIndex(arr);
// PrintArray(arr);
// System.Console.WriteLine();
// System.Console.WriteLine($" Сумма чисел с нечетным индексом в массиве => {sum}");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int mingen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - верхняя граница интервала");
// int maxgen = Convert.ToInt32(Console.ReadLine());

// double[] RandMas(int n, int minvalue, int maxvalue)
// {
//     double[] arr = new double[n];

//     var rand = new Random();

//     for (int i = 0; i < n; i++)
//     {
//         arr[i] = Math.Round(rand.NextDouble() * (maxvalue - minvalue) + minvalue, 2);
//     }
//     return arr;
// }

// void PrintArray(double[] array)

// {
//     int length = array.Length;

//     if (length == 1)
//     {
//         System.Console.WriteLine($"[{array[0]}]");
//     }
//     else
//     {
//         System.Console.Write("[ ");
//         for (int i = 0; i < length - 1; i++)
//         {
//             System.Console.Write($"{array[i]}, ");
//         }
//         System.Console.WriteLine($"{array[length - 1]} ]");
//     }
// }

// double[] FindDiffNumb(double[] array)
// {
//     var length = array.Length;
//     double minvalue = array[0];
//     double maxvalue = array[0];
//     if (length == 1)
//     {
//         System.Console.WriteLine("Невозможно вычислить, введите два или боле значений.");

//     }
//     else
//     {

//         for (int i = 0; i < length; i++)
//         {
//             if (array[i] < minvalue)
//             {
//                 minvalue = array[i];
//             }
//             if (array[i] > maxvalue)
//             {
//                 maxvalue = array[i];
//             }

//         }
//     }
//     var diffvalue = maxvalue - minvalue;

//     double[] arrays = new double[3] {maxvalue,minvalue,diffvalue};
    
//     return arrays;
// }

// void PrintDiffNumb(double[] array)
//     {
//     System.Console.WriteLine("Разница между максимальным и минимальным значением массива");
//     System.Console.WriteLine($"{array[0]} - {array[1]} => {array[2]}");
//     }

// double[] arr = RandMas(n, mingen, maxgen);
// PrintArray(arr);
// var arrays = FindDiffNumb(arr);
// PrintDiffNumb(arrays);


// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int mingen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int maxgen = Convert.ToInt32(Console.ReadLine());


// int[] RandMas ( int numbers, int minnumbers,int maxnumbers )

// {
//     int[] arr = new int[numbers];
//     int length = arr.Length;

//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(minnumbers, maxnumbers + 1);

//     }
//     return arr;
// }

// int[] arr = RandMas(n, mingen, maxgen);

// int[] SumDigit (int[]array)


// {
//     int length = array.Length;
//     int possum = 0;
//     int negsum = 0;


//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] > 0)
//         {

//             possum += array[i];
//         }

//         else
//         {
//             negsum += array[i];
//         }

//     }

//     int[] result = new int[2];
//     result[0] = possum;
//     result[1] = negsum;

//             return result;    

//     }

// void PrintResult(int[] array, int[] maxminvalue)


//     {
//          var length = array.Length;
//          for (int i = 0; i < length; i++)
//          {
//             System.Console.Write($"{arr[i]} ");
//          }

//         System.Console.WriteLine();
//         System.Console.WriteLine($"Сумма положительныч чисел {maxminvalue[0]}");
//         System.Console.WriteLine($"Сумма отрицательных чисел {maxminvalue[1]}");

//     }

// int[] result = SumDigit(arr);

// PrintResult(arr, result);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int mingen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int maxgen = Convert.ToInt32(Console.ReadLine());

// int[] RandMas(int numbers, int mingen, int maxgen)

// {
//     int[] arr = new int[numbers];
//     var length = arr.Length;

//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(mingen, maxgen + 1);
//     }
//     return arr;
// }

// int[] arr = RandMas(n, mingen, maxgen);

// // ArrayPrint(arr);



// int[] NumbReverse(int[] arrays)

// {
//     var length = arrays.Length;
//     for (int i = 0; i < length; i++)
//     {

//         arrays[i] *= -1;

//     }

//     return arrays;
// }

// int[] arrays = NumbReverse(arr);

// void ArrayPrint(int[] input)

// {

//     var length = input.Length;
//     for (int i = 0; i < length; i++)
//     {
//         System.Console.Write($"{input[i]} ");
//     }

//     System.Console.WriteLine();

// }

// ArrayPrint(arrays);


// void FindDigit(int[] ar)

// {
//     System.Console.WriteLine("Введите число для поиска");
//     int findnumb = Convert.ToInt32(Console.ReadLine());
//     var sucfind = false;
//     var length = ar.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (ar[i] == findnumb)
//         {
//             System.Console.WriteLine($"Число {findnumb} присутствует, позиция {i + 1}");
//             sucfind = true;
//         }

//     }

//     if (sucfind == false)
//     {
//         System.Console.WriteLine($"Число {findnumb} отсутствует в выборке");
//     }
// }

// FindDigit(arr);

// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int mingen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - верхняя граница интервала");
// int maxgen = Convert.ToInt32(Console.ReadLine());

// int[] RandMas(int numbsize, int minint, int maxint)
// {
//     int[] arr = new int[numbsize];
//     var length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(minint, maxint);
//     }
//     return arr;
// }



// void FindDigitCount(int[] array)
// {
//     System.Console.WriteLine("Введите число - нижняя граница интервала поиска ");
//     int minfind = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите число - верхняя граница интервала");
//     int maxfind = Convert.ToInt32(Console.ReadLine());
//     var length = array.Length;


//     var countdigit = 0;

//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] >= minfind & array[i] <= maxfind)
//         {

//             countdigit += 1;
//         }
//     }

//     System.Console.WriteLine();
//     System.Console.WriteLine($"Количество значений массива в отрезке  {minfind}<==>{maxfind} => {countdigit}");


// }
// void ArrayPrint(int[] arrprint)
// {
//     for (int i = 0; i < arrprint.Length-1; i++)
//     {
//       System.Console.Write($"{arrprint[i]}, ");
//     }
//     System.Console.Write(arrprint[arrprint.Length-1]);
//     System.Console.WriteLine();

// }

// var arr = RandMas(n, mingen, maxgen);
// ArrayPrint(arr);

// FindDigitCount(arr);

// System.Console.WriteLine("Введите количество чисел в массиве");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - нижняя граница интервала");
// int mingen = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число - верхняя граница интервала");
// int maxgen = Convert.ToInt32(Console.ReadLine());

// int[] RandMas(int numbsize, int minint, int maxint)
// {
//     int[] arr = new int[numbsize];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minint, maxint + 1);
//     }
//     return arr;
// }

// void ArrayPrint(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");

//     }
//     System.Console.Write(array[array.Length - 1]);
//     System.Console.WriteLine();
// }


// var arr = RandMas(n, mingen, maxgen);
// ArrayPrint(arr);


// int[] MirrorMultiply(int[] array)
// {
//     int arrsize;

//     if(array.Length % 2 == 0)
//     {
//        arrsize = array.Length/2;      
//     }
//     else
//     {
//         arrsize = array.Length/2 + 1;
//     }

//     int[] multiarray = new int[arrsize];

//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             multiarray[i] = array[i] * array[array.Length - 1 - i];

//         }
//     if(array.Length % 2 == 1)
//     {
//         multiarray[array.Length/2] = array[array.Length/2];
//     }
  
    
//     return multiarray;
// }
// var multiarray = MirrorMultiply(arr);

// ArrayPrint(multiarray);


// int n = 546;

// var q = Convert.ToString(n);

// System.Console.WriteLine(q.Length);
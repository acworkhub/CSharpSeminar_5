
System.Console.WriteLine("Введите количество чисел в массиве");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число - нижняя граница интервала");
int mingen = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число - нижняя граница интервала");
int maxgen = Convert.ToInt32(Console.ReadLine());

int[] RandMas ( int numbers, int minnumbers,int maxnumbers )

{
    int[] arr = new int [numbers];
    int length = arr.Length;

    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(minnumbers, maxnumbers+1);
        
    }
return  arr;
}

int[] arr = RandMas(n, mingen, maxgen);

int[] SumDigit (int[]array)


    {
       int length  = array.Length; 
       int possum = 0;
       int negsum = 0;
        
      
        for (int i = 0; i < length; i++)
            {   
                if (array[i] > 0)
                    {
                       
                        possum+= array[i]; 
                    }   
            
                else 
                    {
                        negsum+=array[i];
                    }
            
            }

            int[] result = new int[2];
            result[0] = possum;
            result[1] = negsum;

            return result;    

    }

void PrintResult(int[] array, int[] maxminvalue)


    {
         var length = array.Length;
         for (int i = 0; i < length; i++)
         {
            System.Console.Write($"{arr[i]} ");
         }

        System.Console.WriteLine();
        System.Console.WriteLine($"Сумма положительныч чисел {maxminvalue[0]}");
        System.Console.WriteLine($"Сумма отрицательных чисел {maxminvalue[1]}");

    }

int[] result = SumDigit(arr);

PrintResult(arr, result);
           


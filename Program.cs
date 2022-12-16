//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
 int Stepen (int num, int step)

{
    int prod = 1;
     
    for (int current = 1;current<=step;current ++)
    {
        prod = prod * num;  
    }
     return prod;
}

Console.Write("Input a number for stepen: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a stepen:");
int Step = Convert.ToInt32(Console.ReadLine());

double result = Stepen(Num,Step);
Console.Write($"{Num}in {Step} is {result}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int num)
{
   int sum = 0;
   if (num == 0) sum = 1;
   while (num !=0)
   {
      sum = sum + (num % 10);
      num /= 10;

   }
   return sum;
   
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(number);
Console.Write($"Sum of digits in {number} is {result}");
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[]CreateArray(int size, int min, int max)
{
   int[]array = new int[8];

   for(int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(min, max + 1);
   }
    return array;
}


void ShowArray(int[] array)
{
   for (int i = 0; i < array.Length;i++)
   {
      Console.WriteLine($"array[{i+1}] is {array[i]}");
   }
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateArray(size,min,max);
ShowArray(myArray);


//Семинар.1 Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;
if (num1>num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}
Console.WriteLine($"Большее это: {max}");
Console.WriteLine($"Меньшее это:{min}");
*/


//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > num1)
{
    max = num2;
}
if (num3 > num1)
{
    max = num3;
}
Console.WriteLine(max);
*/


// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if  (num % 2 == 0)
Console.Write("Yes");
else
Console.Write("No"); 
*/ 

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

if (num > 1)
{
    while (current <= num)
    {
        Console.Write(current + " ");
        current += 2; 
    } 
}   

*/

//  Семинар.2 Задача.1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
 /*
int CutNumber(int num)
{
    int two = num/10;
    int result = two % 10;

    if (num/100 >0 && num/1000 == 0)

        return result;
    
    else return -1;     
}

Console.Write("Input three-digit number");

int randNum = Convert.ToInt32(Console.ReadLine());

int newNum = CutNumber(randNum);

Console.WriteLine($"Second number of {randNum} is {newNum}");

*/



// Задача.2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
  /*
  int CutNumber(int num)
 {
    while (num > 999)
    {  num = num/10;

       }
    int Third = num % 10; 
    int no = -1;

    if (num / 100 > 0)
    return Third;
     
    else
    return no;
 }

 Console.Write("Input a number: ");
 int Num = Convert.ToInt32(Console.ReadLine());

 int ThirdNumber = CutNumber(Num);

 Console.WriteLine("Third number of " + ThirdNumber);
 */

// Задача.3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayNum(int num)
{
    int current = num;
    if (current == 6 || current == 7)
       return true;
    else 
       return false;
}


Console.Write("Input a day number: ");
int Num = Convert.ToInt32(Console.ReadLine());
 bool dayNum = DayNum(Num); 

Console.Write("Your day of week: " + dayNum);
*/











 
    

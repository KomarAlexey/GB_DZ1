
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Clear();
// Console.Write("Введите А: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите В: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// { 
//       Console.WriteLine("А больше В");
// }
// else
// {
//     if (num1 < num2)
//     {
//         Console.WriteLine("В больше А");
//     }
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear();

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;
// if (max < num2 );
// {
//    max = num2;
// }
// if (max < num3);
// {
//     max = num3;
// }
// Console.WriteLine($"максимальное число = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if ( num1 % 2 ==0)
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число не четное");
}
// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// void RoadToN(int n,int m)
// {
//     if (n==m-1)   return;  
//     //System.Console.Write($"{n } ");
//     RoadToN(n-1,m);
//     System.Console.Write($"{n} ");
// }

// System.Console.WriteLine("Введите число m:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число n:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// //int n = getInt("Введите число :");
// // int m = getInt("Введите число :");
// if (n<m)
// {
//     RoadToN(m,n);
// }
// else
// {
//     RoadToN(n,m);
// }
//----------------------------------------
// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if ((m > 0) && (n == 0))
//     {
//         return Akkerman(m - 1, 1);
//         //Console.WriteLine($"A({m}, {n}) = {Akkerman(m-1,1);}"); 
//     }
//     else
//     {
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//         // Akkerman(m,n-1);
//         // double r=Akkerman(m,n-1);
//     }
// }

// System.Console.WriteLine("Введите число m:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число n:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// // Akkerman(m, n);
// int result = Akkerman(m, n);
// Console.WriteLine($"A({m}, {n}) = {result}");




// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int result = Ackermann(m, n);

//         Console.WriteLine($"A({m}, {n}) = {result}");
//     }

//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }
// }


// System.Console.WriteLine("Введите число m:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число n:  ");
// int n = Convert.ToInt32(Console.ReadLine()); 

// --------------------------------------------------------
// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// void PrintArrayReverse(int[] arr, int index)
// {
//     {
//         Console.Write(arr[index]);
//         PrintArrayReverse(arr, index - 1);
//     }
// }
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] myArray = new int[n];
// for (int i = 0; i < n; i++)
// {
//     myArray[i] = new Random().Next(0, 11);
//     Console.Write(myArray[i]);
// }
// Console.WriteLine("");
// PrintArrayReverse(myArray, myArray.Length - 1);
// ---------------------------------------------------------
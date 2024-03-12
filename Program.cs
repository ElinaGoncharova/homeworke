// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// пример: M=1; N=5; => "1,2,3,4,5"
//         M=4; N=8; => "4,5,6,7,8"

// РЕШЕНИЕ:

// void SequenceOfNumbers(int m, int n)
// {
//     if (n == m - 1)
//     {
//         return;
//     }
//     SequenceOfNumbers(m, n - 1);
//     Console.Write(n+" ");
// }

// Console.Write("Введите минимальное число М: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SequenceOfNumbers(m, n);


// ЗАДАЧА 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// пример: m=2, n=3; A(m,n) = 29

// Решение:

// static int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
//     return -1;

// }
// Console.Write(Akkerman(2, 5));

// ЗАДАЧА 3:
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// РЕШЕНИЕ:
    // {
    //     int[] array = { 1, 2, 5, 0, 10, 34}; 

    //     PrintArrayReversed(array, array.Length - 1);
    // }
    // static void PrintArrayReversed(int[] arr, int index)
    // {
    //     if (index >= 0)
    //     {
    //         Console.Write(arr[index] + " "); 
    //         PrintArrayReversed(arr, index - 1); 
    //     }
    // }


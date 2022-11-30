//                                  ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 9

// // ЗАДАЧА 64. Задайте значение N. Напишите программу, 
// //            которая выведет все натуральные числа в промежутке от N до 1
//               (только непонятно - на семинаре чуть другая формулировка этой задачи была - от M до N.
//               я сделал как в содержании программы)

// void NaturalNumbers(int N)
// {
//     Console.Write(N + " ");
//     if(N > 1) NaturalNumbers(N - 1);
// }

// NaturalNumbers(5);
// Console.WriteLine();


// // ЗАДАЧА 66. Задайте значения M и N. Напишите программу, 
// //            которая найдет сумму натуральных элементов в промежутке от M до N

// int SumNambersInterval(int M, int N)
// {
//     if(M > N) return SumNambersInterval(M, N + 1) + N;
//     if(N > M) return SumNambersInterval(M + 1, N) + M;
//     return N;
// }

// Console.WriteLine(SumNambersInterval(15, 1));


// // ЗАДАЧА 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// //            Даны два неотрицательных числа m и n

// int AkkermanFunction(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else
//     if ((m != 0) & (n == 0)) return AkkermanFunction(m - 1, 1);
//     else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }

// Console.WriteLine(AkkermanFunction(3, 2));






//                                             ЗАДАЧИ СЕМИНАРА 9

// // ЗАДАЧА 1. Задайте значение N. Напишите программу, 
// //           которая выведет все натуральные числа в промежутке от 1 до N

// void NaturalNumbers(int N)
// {
//     if(N > 1) NaturalNumbers(N - 1);
//     Console.WriteLine(N + " ");
// }

// NaturalNumbers(10);


// // ЗАДАЧА 2. Напишите программу, которая будет принимать на вход число и возвращать сумму цифр

// int SumDigits(int N)
// {
//     if(N > 0) return SumDigits(N / 10) + N % 10;
//     else return 0;
// }

// Console.WriteLine(SumDigits(333));


// ЗАДАЧА 3. Задайте значения M и N. Напишите программу, 
//           которая выведет все натуральные числа в промежутке от M до N

// void NaturalDigits(int N, int M)
// {
//     //Console.Write($"{Math.Max(N, M)}");
//     if(Math.Max(N, M) != Math.Min(N, M)) 
//     {
//         NaturalDigits(Math.Min(N, M), Math.Max(N, M) - 1);
//         Console.Write(Math.Max(N, M) + " ");
//     }
    
// }

// NaturalDigits(20, 3);


// // ЗАДАЧА 4. Напишите программу, которая на вход принимает два числа А и В,
// //           и возводит одно число А в целую степень В с помощью рекурсии
// double FindPower(int a, int b)
// {
//     if(b > 0) return FindPower(a, b - 1) * a;
//     if(b < 0) return (FindPower(a, b + 1)) / a;
//     return 1.0;
// }

// Console.WriteLine(FindPower(3, 5));
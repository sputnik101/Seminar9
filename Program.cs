// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введи число"); 

// int num = Convert.ToInt32(Console.ReadLine());

// int sNum=1;

// Console.WriteLine(PrintNumbers(num,sNum));

// string PrintNumbers(int num1, int num2) 
// {

//     if(num2>=num1)
//     {
//         return num2.ToString();
//     }

//     return (num1+ " " + PrintNumbers(num1-1,num2)); 
// }

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = InputInt("Введите M:");
// int n = InputInt("Введите N:");
// Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int CountNaturalSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + CountNaturalSum(m, n - 1);
// }

// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите два положительных числа: M и N.");
// int m = InputInt("Введите M: ");
// int n = InputInt("Введите N: ");
// Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }
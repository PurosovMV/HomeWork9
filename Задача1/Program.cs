/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int start, int end)
{
    Console.Write($"{start}, ");
    if (start == end) return;
    PrintNumbers(start - 1, end);
}


int N = ReadInput("Введите число: ");
PrintNumbers(N, 1);

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */


int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintNumbers(int start, int end)
{
    int sum = 0;
    if (start == end) return start;
    sum = start + PrintNumbers(start + 1, end);
    return sum;
}

int M = ReadInput("Введите число M: ");
int N = ReadInput("Введите число N: ");
int product = PrintNumbers(M, N);
Console.Write(product);




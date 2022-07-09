// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {NaturalNumber(m, n)}");

int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
        return NaturalNumber(m, n - 1) + n;
}
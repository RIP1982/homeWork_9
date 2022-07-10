//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int finNum = 1;
Console.WriteLine($"{ReverseNuturalNumbers(n, finNum)} - натуральные числа от {n} до {finNum}");

int ReverseNuturalNumbers(int n, int finNum)
{
    if (finNum == n) return n;
    else Console.Write($"{ReverseNuturalNumbers(n, finNum + 1)},  ");
    return finNum;
}
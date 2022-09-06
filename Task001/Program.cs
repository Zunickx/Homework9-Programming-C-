// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

Console.Write("Введите число M: ");
string numberN = Console.ReadLine()!;
Console.Write("Введите число N: ");
string numberM = Console.ReadLine()!;
int m = int.Parse(numberN);
int n = int.Parse(numberM);

void PrintNaturalNumbers(int m, int n)
{
    if (m == n) Console.Write($"{n} "); 
    else 
    { 
        Console.Write($"{m} "); 
        PrintNaturalNumbers(m + 1, n); 
    } 
}

PrintNaturalNumbers(m, n);
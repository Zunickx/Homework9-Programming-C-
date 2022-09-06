// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
string numberN = Console.ReadLine()!;
Console.Write("Введите число N: ");
string numberM = Console.ReadLine()!;
int m = int.Parse(numberN);
int n = int.Parse(numberM);

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}

Console.Write(Akk(m, n));
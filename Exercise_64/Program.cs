// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
Console.Clear();
int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int OutputNaturelNumbers(int n, int m)
{
    if (n == m) 
    {
        return n;
    }
    else Console.Write($"{OutputNaturelNumbers(n, m + 1)}, ");
    return m;
}
int n = EnterNumber("Input N: ");
OutputNaturelNumbers(n, 0);

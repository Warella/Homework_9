// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int OutputSum(int m, int n)
{
    if (m == n) 
    {
        return n;
    }
    return n + OutputSum(m, n - 1);
}
int m = EnterNumber("Input M: ");
int n = EnterNumber("Input N: ");
Console.WriteLine(OutputSum(m, n));

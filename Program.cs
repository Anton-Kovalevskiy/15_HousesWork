/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите номер задачи: ");
string? task = Console.ReadLine();
switch (task)
{
    case "64":
    Task64 (task);
    break;
    case "66":
    Task66 (task);
    break;
    case "68":
    Task68 (task);
    break;
    default:
    break;
}

void Task64 (string task)                                   // Решение задачи №64
{
    string mes = "Введите значение N: ";
    int n = size (mes);
    Console.Write (NumberRow(n, 1));
}

void Task66 (string task)                                   // Решение задачи №66
{
    string mes = "Введите значение M: ";
    int m = size (mes);
    mes = "Введите значение N: ";
    int n = size (mes);
    int sum = 0;
    Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равно {SumNumber(m, n, sum)}");
}

void Task68 (string task)                                   // Решение задачи №68
{
    string mes = "Введите неотрицательное число m: ";
    int m = size (mes);
    mes = "Введите неотрицательное число n: ";
    int n = size (mes);
    Console.Write($"Функция Аккермана А({m},{n}) = {AccermansFunction(m, n)}");
}

int size (string message)                                   // Определение параметров
{
    Console.Write(message);
    int s = Convert.ToInt32(Console.ReadLine());
    return (s);
}

string NumberRow (int N, int end)                           // Заполнение последовательности
{
    if (N == end) 
    {
        return N.ToString();
    }
        return (N + " " + NumberRow(N - 1, end));
}

int SumNumber (int m, int n, int sum)                       // Сумма элементов последовательности
{
    if (m > n)
    {
        return (sum);
    }
    return (sum + m + SumNumber(m + 1, n, sum));
}

int AccermansFunction (int m, int n)                        // Функция Аккермана
{
    if (m == 0) return (n + 1);
    else
    {
        if (n == 0) return AccermansFunction (m - 1, 1);
        return AccermansFunction (m - 1, AccermansFunction(m, n - 1));
    }
}
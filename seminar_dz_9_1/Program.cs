//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();
static int InitNumber()
{
    int nNubmer;
    while (true)
    {
        Console.Write($"Введите любое натуральное число: ");
        if (int.TryParse(Console.ReadLine(), out nNubmer))
        {
            if (nNubmer > 0)
            {
                return nNubmer;
            }
            else
            {
                Console.WriteLine($"Неверный ввод (необходимо ввести натуральное число)!!!!");
            }
        }
        else
        {
            Console.WriteLine($"Неверный ввод (необходимо ввести натуральное число)!!!!");
        }
    }
}

static string GetAllNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n + ", " + GetAllNumbers(n - 1);
    }
}

int N = InitNumber();
string allNumbers = GetAllNumbers(N);
Console.WriteLine($"N = {N} -> {allNumbers}");









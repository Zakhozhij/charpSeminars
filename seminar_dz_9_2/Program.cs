//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
//Метод проверки числа
static int CheckNaturalNumbers(int x)
{
    if (x < 0)
    {
        return 0;
    }
    else
    {
        return x;
    }
}
//Метод поиска суммы в диапазоне
static int SummBetweenNumbers(int a, int b)
{
    if(b<a){
        return 0;
    }
    else
    {
        return b + SummBetweenNumbers(a,b-1);
    }
    
}

int M, N;

Console.Write("Введите число M:");
try
{
    M = int.Parse(Console.ReadLine() ?? "");

}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных!!!! {exc.Message}");
    return;
}

Console.Write("Введите число N:");
try
{
    N = int.Parse(Console.ReadLine() ?? "");

}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных!!!! {exc.Message}");
    return;
}

if (CheckNaturalNumbers(M) <= CheckNaturalNumbers(N))
{
    int result = SummBetweenNumbers(M, N);
    Console.WriteLine($"M = {M}; N = {N} -> {result}");
}
else
{
    Console.WriteLine($"M = {M}; N = {N} -> Неверно задан диапазон");
}









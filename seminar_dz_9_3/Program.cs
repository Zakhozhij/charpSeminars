//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
static int InitNumber(string text)
{
    int nNubmer;
    
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out nNubmer))
        {
            if (nNubmer >= 0)
            {
                return nNubmer;
            }
            else
            {
                Console.WriteLine($"Неверный ввод (необходимо ввести неотрицательное число)!!!!");
            }
        }
        else
        {
            Console.WriteLine($"Неверный ввод (необходимо ввести неотрицательное число)!!!!");
        }
    }
}

static int CountAkkerman(int M,int N)
{
    if (M == 0)
    {
        return N+1;
    }
    else if (M > 0 && N==0)
    {
        return CountAkkerman(M-1,1);
    }
    else
    {
        return CountAkkerman(M-1,CountAkkerman(M,N-1));
    }
}

int m = InitNumber("Введите неотрицательное число m:");
int n = InitNumber("Введите неотрицательное число n:");
int result =CountAkkerman(m,n);
//string allNumbers = GetAllNumbers(N);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");










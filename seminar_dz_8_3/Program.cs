//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
//Метод заполнения массива данными
int[,] FillArray(int rows, int cols)
{
    int[,] inputsArr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            inputsArr[i, j] = new Random().Next(1, 10);
        }
    }
    return inputsArr;
}
//Метод вывода массива на экран
void PrintArray(int[,] inputsArr)
{
    for (int i = 0; i < inputsArr.GetLength(0); i++)
    {
        for (int j = 0; j < inputsArr.GetLength(1); j++)
        {
            Console.Write($"{inputsArr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Метод поиска строки с наименьшей суммой элементов
int[,] GetMultiplyAB(int[,] mA, int[,] mB, int a, int b, int c)
{
    int[,] mC = new int[a, b];
    for (int i = 0; i < mC.GetLength(0); i++)
    {
        for (int j = 0; j < mC.GetLength(1); j++)
        {
            for (int t = 0; t < c; t++)
            {
                mC[i, j] += mA[i, t] * mB[t, j];
            }
        }
    }

    return mC;
}

Console.Write("Введите количество строк матрицы А: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбоцв матрицы В: ");
int k = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов матрицы А (данное число равно количеству строк матрицы В): ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] A = FillArray(m, n);
Console.WriteLine("Матрица А ");
PrintArray(A);
int[,] B = FillArray(n, k);
Console.WriteLine("Матрица В ");
PrintArray(B);
int[,] C = GetMultiplyAB(A, B, m, k, n);
Console.WriteLine("Результирующая матрица С ");
PrintArray(C);




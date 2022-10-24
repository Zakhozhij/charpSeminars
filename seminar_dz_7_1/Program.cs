//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
//Метод заполнения массива данными
double[,] FillArray(int rows, int cols)
{
    double[,] inputsArr = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            inputsArr[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
    return inputsArr;
}
//Метод вывода массива на экран
void PrintArray(double[,] inputsArr)
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

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

double[,] array = FillArray(m, n);
PrintArray(array);



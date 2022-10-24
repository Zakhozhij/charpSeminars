//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
//Метод заполнения массива данными
int[,] FillArray(int rows, int cols)
{
    int[,] inputsArr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            inputsArr[i, j] = new Random().Next(1, 100);
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
//Метод вывода среднего арифметического элементов в каждом столбце
void CountColsSumm(int[,] inputsArr)
{
    double summ;
    for (int j = 0; j < inputsArr.GetLength(1); j++)
    {
        summ = 0;
        for (int i = 0; i < inputsArr.GetLength(0); i++)
        {
            summ += inputsArr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое элементов в столбце {j + 1} -> {Math.Round(summ / (inputsArr.GetLength(0)), 2)};");
    }
}




Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] array = FillArray(m, n);
PrintArray(array);
CountColsSumm(array);



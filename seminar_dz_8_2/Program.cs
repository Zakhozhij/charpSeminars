//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int GetMinSummRow(int[,] inputsArr)
{
    int summ;
    int minSummRow = 0;
    int NumberMinSummRow = 0;
    for (int i = 0; i < inputsArr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < inputsArr.GetLength(1); j++)
        {
            summ += inputsArr[i, j];
        }
        if (i == 0)
        {
            minSummRow = summ;
            NumberMinSummRow = i;
        }
        else
        {
            if (summ < minSummRow)
            {
                minSummRow = summ;
                NumberMinSummRow = i;
            }
        }
    }
    return NumberMinSummRow;
}


Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] array = FillArray(m, n);
PrintArray(array);
int NumberMinRow = GetMinSummRow(array);
Console.WriteLine($"Номер строки с наименьшей суммой элеиентов -> {NumberMinRow + 1}");//Увеличение на 1 так как отсчет элементов массива ведется с 0



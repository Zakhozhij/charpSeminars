//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

//Поиск элемента по позиции
string GetValueByPosition(int[,] inputsArr, int row, int col)
{
    if (row >= 0 && row < inputsArr.GetLength(0) && col >= 0 && col < inputsArr.GetLength(1))
    {
        return $"{row} {col} -> {inputsArr[row, col]}";
    }
    else
    {
        return $"{row} {col} -> такого числа в массиве нет";
    }
}


Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] array = FillArray(m, n);
PrintArray(array);

Console.Write("Введите номер строки для поиска элемента: ");
int row_position = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца для поиска элемента: ");
int col_position = int.Parse(Console.ReadLine() ?? "");

string searchResults = GetValueByPosition(array, row_position, col_position);
Console.WriteLine(searchResults);



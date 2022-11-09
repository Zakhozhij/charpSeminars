//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
//Метод сортировки строк
void SortArrayRows(int[,] inputsArr)
{
   int x;
    for (int rows = 0; rows < inputsArr.GetLength(0); rows++)
    {
        for (int cols = 0; cols < inputsArr.GetLength(1)-1; cols++)
        {
            for (int temp = cols + 1; temp < inputsArr.GetLength(1); temp++)
            {
                if (inputsArr[rows,cols] < inputsArr[rows,temp])
                {
                    x = inputsArr[rows,temp];
                    inputsArr[rows,temp] = inputsArr[rows,cols];
                    inputsArr[rows,cols] = x;
                }
            }
        }
    }
}


Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] array = FillArray(m, n);
PrintArray(array);
SortArrayRows(array);
Console.WriteLine();
PrintArray(array);



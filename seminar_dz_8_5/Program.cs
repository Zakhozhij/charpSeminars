//Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear();
//Метод заполнения массива данными
string[,] FillArray(int m, int k)
{
    string[,] inputsArr = new string[m, k];
    int x = 1;
    int i = 0;
    int j = 0;
    inputsArr[i, j] = "0" + Convert.ToString(x);
    while (x < m * k)
    {
        while (j + 1 < k && inputsArr[i, j + 1] == null) //Заполнение элементов слева направо
        {
            j++;
            x++;
            if (x < 10)
            {
                inputsArr[i, j] = "0" + Convert.ToString(x);
            }
            else
            {
                inputsArr[i, j] = Convert.ToString(x);
            }
        }

        while (i + 1 < m && inputsArr[i + 1, j] == null) //Заполнение элементов сверху вниз
        {
            i++;
            x++;
            if (x < 10)
            {
                inputsArr[i, j] = "0" + Convert.ToString(x);
            }
            else
            {
                inputsArr[i, j] = Convert.ToString(x);
            }
        }

        while (j - 1 >= 0 && inputsArr[i, j - 1] == null) //Заполнение элементов справа налево
        {
            j--;
            x++;
            if (x < 10)
            {
                inputsArr[i, j] = "0" + Convert.ToString(x);
            }
            else
            {
                inputsArr[i, j] = Convert.ToString(x);
            }
        }

        while (i - 1 >= 0 && inputsArr[i - 1, j] == null)//Заполнение элементов снизу вверх
        {
            i--;
            x++;
            if (x < 10)
            {
                inputsArr[i, j] = "0" + Convert.ToString(x);
            }
            else
            {
                inputsArr[i, j] = Convert.ToString(x);
            }
        }
    }

    return inputsArr;
}
//Метод вывода массива на экран
void PrintArray(string[,] inputsArr)
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
Console.WriteLine("---------------------------");
string[,] array = FillArray(4, 4);
PrintArray(array);



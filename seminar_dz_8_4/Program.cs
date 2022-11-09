//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
//Метод заполнения массива данными
int[,,] FillArray(int a, int b, int c)
{
    int[,,] inputsArr = new int[a, b, c];
    int x;
    bool v_check;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int t = 0; t < c; t++)
            {
                Found:
                x = new Random().Next(10, 99); 
                v_check=FindValueInArray(inputsArr,x);
                if(v_check){
                    goto Found;
                }
                inputsArr[i, j, t] = x;
            }
        }
    }
    return inputsArr;
}
//Метод поиска двузначного значения в массиве
bool FindValueInArray(int[,,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(2); t++)
            {
                if(array[i, j, t] == value)
                {
                    return true;
                }
            }
        }
    }
    return false;
}
//Метод проверки размера массива
bool CheckArray(int a, int b, int c)
{
    if(a*b*c<=90){
        return true;
    }else{
        return false;
    }
}

//Метод вывода массива на экран
void PrintArray(int[,,] inputsArr)
{
    for (int i = 0; i < inputsArr.GetLength(0); i++)
    {
        for (int j = 0; j < inputsArr.GetLength(1); j++)
        {
            for (int k = 0; k < inputsArr.GetLength(2); k++)
            {
                Console.WriteLine($"{inputsArr[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}




Console.WriteLine("Введите размеры массива AxBxC ");

Console.Write("Введите A: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите C: ");
int c = int.Parse(Console.ReadLine() ?? "");

bool CheckResults=CheckArray(a,b,c);

if(CheckResults){
    int[,,] array = FillArray(a, b, c);
    PrintArray(array);
}else{
    Console.WriteLine("Превышен максимальный размер!");
}



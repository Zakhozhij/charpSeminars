//Частотный словарь
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
//Метод вывода двумерного массива на экран
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
//Метод вывода одномерного массива на экран
void PrintArrayOne(int[] inputsArr)
{
    foreach(int val in inputsArr ) 
    {
        Console.Write($"{val} ");
    }
}

//Метод подсчета элементов
int[] Transporate(int[,] inputsArr)
{
    int[] t_array = new int[] {};
    int i=0;
    for (int rows = 0; rows < inputsArr.GetLength(0); rows++)
    {
        for (int cols = 0; cols < inputsArr.GetLength(1); cols++)
        {
            Array.Resize(ref t_array, t_array.Length + 1);
            t_array[i]=inputsArr[rows,cols];
            i++;
            
        }
    }
    return t_array;
}

int[] UniqArray(int[] array)
{
    int[] t_array = new int[] {};
    int i=0;
    for (int j = 0; j < array.Length; j++)
    {
        if(Array.IndexOf(t_array,array[j])==-1){
            Array.Resize(ref t_array, t_array.Length + 1);
            t_array[i]=array[j];
            i++;
        }
    }  
    return t_array;
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] array = FillArray(m, n);
int[] transporated_array=Transporate(array);
int[] uniq_transporated_array=UniqArray(transporated_array);



PrintArray(array);
Console.WriteLine();

void CreateDictionary(int[] array, int v)
{
    int sum=0;
    foreach(int val in array ) 
    {
        if(v==val){
            sum++;
        }
    }
    Console.WriteLine($"Количество элементов {v} -> {sum}");
}



foreach(int val in uniq_transporated_array){
    CreateDictionary(transporated_array,val);
}



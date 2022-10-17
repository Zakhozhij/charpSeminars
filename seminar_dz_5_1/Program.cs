//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
Console.Clear();
void FillArray(int[] inputsArr){
    int length = inputsArr.Length;
    for(int i = 0; i<length; i++){
        inputsArr[i]=new Random().Next(100, 1000);
    }
}
int GetCountEven(int[] inputsArr){
    int length = inputsArr.Length;
    int results = 0;
    for(int i = 0; i<length; i++){
        if(inputsArr[i] % 2 == 0){
            results++;
        }
    }
    return results;
}
Console.Write("Введите размер массива: ");
int size = 0;
try
{
    size=int.Parse(Console.ReadLine() ?? "");
}catch(Exception exc){
    Console.WriteLine($"Ошибка ввода данных!!!! {exc.Message}");
    return;
}
int[] array = new int[size];
FillArray(array);
int count_even = GetCountEven(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {count_even}");

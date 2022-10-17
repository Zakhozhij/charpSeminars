//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.Clear();
void FillArray(int[] inputsArr){
    int length = inputsArr.Length;
    for(int i = 0; i<length; i++){
        inputsArr[i]=new Random().Next(-100, 100);
    }
}
int GetCountNotEven(int[] inputsArr){
    int length = inputsArr.Length;
    int results = 0;
    for(int i = 0; i<length; i++){
        if(i % 2 != 0){
            results+=inputsArr[i];
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
int countNotEven = GetCountNotEven(array);


Console.WriteLine($"[{string.Join(", ", array)}] -> {countNotEven}");

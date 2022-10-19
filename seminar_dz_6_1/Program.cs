//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
void FillArray(int[] inputsArr){
    int length = inputsArr.Length;
    for(int i = 0; i<length; i++){
        Console.Write($"Введите {i+1} элемент массива -> ");
        inputsArr[i]=int.Parse(Console.ReadLine() ?? "");
    }
}
int CountPositive(int[] inputsArr){
    int results = 0;
    foreach (int val in inputsArr){
        if(val > 0){
            results++;
        }
    }
    return results;
}

Console.Write("Введите размер массива: ");
int size;
try
{
    size=int.Parse(Console.ReadLine() ?? "");
}catch(Exception exc){
    Console.WriteLine($"Ошибка ввода данных!!!! {exc.Message}");
    return;
}
int[] array = new int[size];
FillArray(array);
int CountPositiveValues = CountPositive(array);


Console.WriteLine($"[{string.Join(", ", array)}] -> {CountPositiveValues}");

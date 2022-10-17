//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
void FillArray(double[] inputsArr){
    int length = inputsArr.Length;
    for(int i = 0; i<length; i++){
        inputsArr[i]=Math.Round(new Random().NextDouble()*100,2);
    }
}
double GetMaxValue(double[] inputsArr){
    int length = inputsArr.Length;
    double max = inputsArr[0];
    if(length > 1 ) 
    {
        for(int i = 1; i<length; i++){
            if(inputsArr[i]>max){
                max=inputsArr[i];
            }
        }
    }
    return max;
}
double GetMinValue(double[] inputsArr){
    int length = inputsArr.Length;
    double min = inputsArr[0];
    if(length > 1 ) 
    {
        for(int i = 1; i<length; i++){
            if(inputsArr[i]<min){
                min=inputsArr[i];
            }
        }
    }
    return min;
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
double[] array = new double[size];
FillArray(array);
double MaxValue = GetMaxValue(array);
double MinValue = GetMinValue(array);


Console.WriteLine($"[{string.Join(" ", array)}] -> {Math.Round(MaxValue-MinValue,2)}");

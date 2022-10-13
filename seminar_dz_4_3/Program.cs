//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void FillArray(int[] inputsArr){
    int length = inputsArr.Length;
    int index = 0;
    for(int i = 0; i<length; i++){
        inputsArr[index]=new Random().Next(1, 10);
        index++;
    }
}
int[] array = new int[8];
FillArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");


//Task 1
Console.WriteLine("Задача 1 (максимальное из двух чисел)");
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int max = a;
if(b > max){
    max = b;
}
Console.WriteLine("Число a = " + a);
Console.WriteLine("Число b = " + b);
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("------------------------------");
//Task 2
Console.WriteLine("Задача 2 (максимальное из трех чисел)");
a = new Random().Next(1, 10);
b = new Random().Next(1, 10);
int c = new Random().Next(1, 10);
max = a;
if(b > max){
    max = b;
}
if(c > max){
    max = c;
}
Console.WriteLine("Число a = " + a);
Console.WriteLine("Число b = " + b);
Console.WriteLine("Число c = " + c);
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("------------------------------");
//Task 3
Console.WriteLine("Задача 3 (четное ли число)");
a = new Random().Next(-100, 100);
Console.WriteLine("Число a = " + a);
if((a % 2) == 0){
    Console.WriteLine("Четное");
}else{
    Console.WriteLine("Не четное");
}
Console.WriteLine("------------------------------");
//Task 4
Console.WriteLine("Задача 4 (четные числа в промежутке)");
Console.Write("Введите число N: ");
string end = Console.ReadLine() ?? "";
int N = int.Parse(end);
Console.Write("В промежутке от 1 до " + N + " следующие четные числа: ");
int start = 1;
while(start <= N){
    if((start % 2) == 0){
        Console.Write(start + " ");
    }
    start++;
}
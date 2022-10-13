//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "");
int x = 1;
for(int i =1; i<=b; i++){
    x*=a;
}
Console.WriteLine($"Результат возведения числа {a} в степень {b} -> {x} ");

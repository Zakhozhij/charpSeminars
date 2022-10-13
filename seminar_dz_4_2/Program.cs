//апишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число a: ");
int a,b;
try
{
    a = int.Parse(Console.ReadLine() ?? "");

}catch(Exception exc){
    Console.WriteLine($"Ошибка ввода данных!!!! {exc.Message}");
    return;
}
int SummNumbers(int x){
    int summ = 0;
    while(x>0){
        summ+=x%10;
        x/=10;
    }
    return summ;
}


b=SummNumbers(a);
Console.WriteLine($"Сумма цифр числа {a} -> {b} ");
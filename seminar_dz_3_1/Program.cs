//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
int number;
//Метод инициализации пятизначного числа
static int InitNumber()
{
    int varA;
    while(true){
        Console.Write($"Введите любое положительное пятизначное число: ");
        if(int.TryParse(Console.ReadLine(),out varA))
        {
            if(varA>9999 && varA<100000){
                return varA;
            }else{
                Console.WriteLine($"Неверный ввод (необходимо ввести любое положительное пятизначное число)!!!!");
            }
        }else{
            Console.WriteLine($"Неверный ввод (необходимо ввести любое положительное пятизначное число)!!!!");
        }
    }
}
//Метод проверки числа на полиндром
static void CheckPolindrom(int x)
{
    string x_to_str = Convert.ToString(x);
    string x_to_str_polindrom = new string(x_to_str.Reverse().ToArray());
    /*for(int i = x_to_str.Length-1; i>=0; i--){//Тоже сработает
        x_to_str_polindrom+=x_to_str[i];
    }*/

    if(x_to_str == x_to_str_polindrom){
        Console.WriteLine($"{x_to_str} -> Да");
    }else{
        Console.WriteLine($"{x_to_str} -> Нет");
    }
}
number = InitNumber();
CheckPolindrom(number);










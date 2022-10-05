Console.Clear();
int varA;
while(true){
    Console.Write($"Введите число (от 10 до 999): ");
    if(int.TryParse(Console.ReadLine(),out varA))
    {
        if(varA>99 && varA<1000){
            Console.WriteLine($"Третья цифра заданного числа {varA}: {varA % 10}");
            break;
        }else if(varA>9 && varA<100){
            Console.WriteLine($"{varA} -> третьей цифры нет");
            break;
        }else{
            Console.WriteLine($"Введите число (от 10 до 999)!!!!");
        }
    }else{
        Console.WriteLine($"Ошибка ввода: необходимо ввести число (от 10 до 999)");
    }
}


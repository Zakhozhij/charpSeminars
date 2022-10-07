Console.Clear();
int varA;
string result;
while(true){
    Console.Write($"Введите любое число (от 1 до бесконечности): ");
    if(int.TryParse(Console.ReadLine(),out varA))
    {
        if(varA>0 && varA<100){
            Console.WriteLine($"{varA} -> третьей цифры нет");
            break;
        }else if(varA>99){
            result=Convert.ToString(varA);
            Console.WriteLine($"Третья цифра заданного числа {result[2]}:");
            break;
        }else{
            Console.WriteLine($"Введите число (от 1 до бесконечности)!!!!");
        }
    }else{
        Console.WriteLine($"Ошибка ввода: необходимо ввести число (от 1 до бесконечности)");
    }
}


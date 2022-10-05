Console.Clear();
int EnterNumber(){
    int varA;
    while(true){
        Console.Write($"Введите число (от 1 до 7): ");
        if(int.TryParse(Console.ReadLine(),out varA))
        {
            if(varA>0 && varA<8){
                return varA;
            }else{
                Console.WriteLine($"Введите число (от 1 до 7)!!!!");
            }
        }else{
            Console.WriteLine($"Ошибка ввода: необходимо ввести число (от 1 до 7)");
        }
    }
}
int DayOfWeek=EnterNumber();
if(DayOfWeek==6 || DayOfWeek==7){
    Console.WriteLine($"{DayOfWeek} -> да");
}else{
    Console.WriteLine($"{DayOfWeek} -> нет");
}




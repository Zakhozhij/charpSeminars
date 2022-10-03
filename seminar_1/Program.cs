Console.Write("Введите a: ");
string a = Console.ReadLine() ?? "";
Console.Write("Введите b: ");
string b = Console.ReadLine() ?? "";
int int_a = int.Parse(a);
int int_b = int.Parse(b);
if(int_a == (int_b * int_b)){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}
Console.WriteLine("--------------------");
Console.Write("Введите день недели: ");
string weekday = Console.ReadLine() ?? "";
int int_weekday = int.Parse(weekday);
if(int_weekday >= 1 && int_weekday <= 7){
    if(int_weekday == 1){
        Console.WriteLine(int_weekday + " -> Понедельник");
    }else if(int_weekday == 2){
        Console.WriteLine(int_weekday + " -> Вторник");
    }else if(int_weekday == 3){
        Console.WriteLine(int_weekday + " -> Среда");
    }else if(int_weekday == 4){
        Console.WriteLine(int_weekday + " -> Четверг");
    }else if(int_weekday == 5){
        Console.WriteLine(int_weekday + " -> Пятница");
    }else if(int_weekday == 6){
        Console.WriteLine(int_weekday + " -> Суббота");
    }else if(int_weekday == 7){
        Console.WriteLine(int_weekday + " -> Воскресенье");
    }
    
}else{
    Console.WriteLine("Вышли за диапозон дней или что-то не то");
}
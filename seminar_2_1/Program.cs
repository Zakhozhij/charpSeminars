Console.Clear();
int a1 = new Random().Next(1, 11);
int a2 = new Random().Next(10, 1000);
int result = a2 % a1;
if(result== 0){
    Console.WriteLine($"{a2} кратно {a1}");
}else{
    Console.WriteLine($"{a2} не кратно {a1} остаток = {result}");
}



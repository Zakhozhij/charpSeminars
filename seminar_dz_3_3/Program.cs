//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

static void InitNumber()
{
    int N;
    while(true){
        Console.Write($"Введите любое натуральное число: ");
        if(int.TryParse(Console.ReadLine(),out N))
        {
            if(N>0){
                Console.Write($"{N} -> ");
                for(int i=1; i<=N;i++){
                    if(i != N){
                        Console.Write($"{Math.Pow(i,3)}, ");
                    }else{
                        Console.Write($"{Math.Pow(i,3)}");
                    }
                }
                break;
            }else{
                Console.WriteLine($"Неверный ввод (необходимо ввести натуральное число)!!!!");
            }
        }else{
            Console.WriteLine($"Неверный ввод (необходимо ввести натуральное число)!!!!");
        }
    }
}
InitNumber();










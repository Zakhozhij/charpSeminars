Console.Clear();
int A = InputA("Введите число А: ");


int count = workNumbers(A);
Console.WriteLine($"Количество цифра в числе {A} -> {count}");

int InputA(string Message)
{
    
    while(true){
        Console.Write(Message);
        bool isCorrect=int.TryParse(Console.ReadLine() ?? "", out int Anumber);
        if(isCorrect){
            return Anumber;
        }else{
            Console.WriteLine("Ошибка ввода");
        }
    }
} 

int workNumbers(int x)
{
    int result=1;
    for(int i=1; i<=x;i++){
        result*=i;
    }
    return result;
} 
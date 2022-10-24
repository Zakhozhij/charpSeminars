Console.Clear();
int inputValues(string Message){
    Console.Write(Message);
    int value=int.Parse(Console.ReadLine() ?? "");
    return value;
}
string CheckTriangle(int A, int B, int C){
    if(A >= (B+C) || B >= (A+C) || C >= (B+A)){
        return "Треугольник не может существовать!";
    }else{
        return "Все ОК!";
    }
}

int a = inputValues("Введите a: ");
int b = inputValues("Введите b: ");
int c = inputValues("Введите c: ");

string result = CheckTriangle(a, b, c);
Console.WriteLine(result);




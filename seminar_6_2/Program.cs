Console.Clear();
int inputValues(string Message){
    Console.Write(Message);
    int value=int.Parse(Console.ReadLine() ?? "");
    return value;
}
string ConvertTo2(int A){
    string result = "";
    while(A > 0){
        result = A%2  + result;
        A /= 2;
    }
    return result;
}
int a = inputValues("Введите a: ");
string resultOfConvertion = ConvertTo2(a);

Console.WriteLine(resultOfConvertion);



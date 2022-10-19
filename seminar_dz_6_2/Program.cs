//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
double inputValues(string Message){
    Console.Write(Message);
    double value=double.Parse(Console.ReadLine() ?? "");
    return value;
}
double k1 = inputValues("Введите k1: ");
double b1 = inputValues("Введите b1: ");
double k2 = inputValues("Введите k2: ");
double b2 = inputValues("Введите b2: ");
if(k1 - k2 == 0){
    Console.WriteLine($"k1 не может равняться k2!");
}else{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых -> ({x};{y})");
}




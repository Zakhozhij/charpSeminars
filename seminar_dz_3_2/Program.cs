//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1,y1,z1,x2,y2,z2;
double result = 0;
static int IniitCoordinates(string message){
    Console.Write($"{message}");
    int kords = int.Parse(Console.ReadLine() ?? "");
    return kords;
}
static double distance(int a1, int b1, int c1, int a2, int b2, int c2){
    
    double dis = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 - c1), 2));
    return Math.Round(dis,2);

}

x1 = IniitCoordinates("Введите x1: ");
y1 = IniitCoordinates("Введите y1: ");
z1 = IniitCoordinates("Введите z1: ");
x2 = IniitCoordinates("Введите x2: ");
y2 = IniitCoordinates("Введите y2: ");
z2 = IniitCoordinates("Введите z2: ");

Console.WriteLine($"Координаты точки A({x1},{y1},{z1})");
Console.WriteLine($"Координаты точки B({x2},{y2},{z2})");

result = distance(x1, y1, z1, x2, y2, z2);
Console.Write($"A({x1},{y1},{z1}); B({x2},{y2},{z2}), -> {result}");  
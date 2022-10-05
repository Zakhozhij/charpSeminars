Console.Clear();
int num = new Random().Next(100, 1000);
int result = ((num / 10) % 10);
Console.WriteLine($"Вторая цифра трехзначного числа {num}={result}");
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int x = number/10%10;
Console.Write($"{x}");

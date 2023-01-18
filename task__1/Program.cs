Console.WriteLine("Введи 1-ое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи 2-ое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("какое число больше?");
if(a>b)Console.Write($"{a} > {b} т.е max = {a}, min = {b}");
else Console.Write($"{b} > {a} т.е max = {b}, min = {a}"); 
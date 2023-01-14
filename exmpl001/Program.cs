// See https://aka.ms/new-console-template for more information
//int a = new Random().Next(1,100);
//Console.Write("Квадрат числа ");
//Console.Write(a);
//Console.Write(" = ");
//Console.Write(a*a);
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
//int.parse() тоже конвертирует строковую в цифровую
Console.Write("Квадрат числа ");
Console.Write(a);
Console.Write(" = ");
Console.Write(a*a);
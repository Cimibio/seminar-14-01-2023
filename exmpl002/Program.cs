// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine("число " + n1 + " больше числа " + n2);
}    
else
{
    Console.WriteLine("число " + n2 + " больше числа " + n1);
}
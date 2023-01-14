// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
//for (int i = -n; i <= n; i++ )
//{
//    Console.WriteLine(i);
//}
int i = -n;
while (i <= n)
{
    Console.WriteLine(i);
    i++;
}
//Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0) Console.WriteLine("число кратно одновременно 7 и 23");
else
{
    System.Console.WriteLine("Число не кратно 7 и 23");
}
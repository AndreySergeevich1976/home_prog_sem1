// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.Clear();
Console.Write("Введите число из отрезка [10, 99]: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10 || n > 99){
Console.Write("Вы ошиблись! Введите число из отрезка [10, 99]: ");
n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2) System.Console.WriteLine($"Первая цифра {n1} больше");
else 
if (n1 < n2) System.Console.WriteLine($"Вторая цифра {n2} больше");
else 
System.Console.WriteLine($"Первая цифра {n1} и вторая цифра {n1} одинаковые");
// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (т <= n){
//     n = n /10;
//     System.Console.WriteLine(n % 10);
// }

// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0)
// {
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }


// if (n > 0){
//     int i = 1;
//     while (i <= n){
//         if (i != n){
//             System.Console.Write($"{i}, ");
//         }
//         else
//         System.Console.Write($"{i}");
//         i++;
//     }
// }
// string s = Console.ReadLine()!;
// int n = Convert.ToInt32(s);
// Console.WriteLine(n % 2 == 0 ? "Четное" : "Не четное");

// using System; 
 
// namespace NumberDigits 
// { 
// class Program 
// { 
// static void Main(string[] args) 
// { 
// Console.WriteLine("Введите натуральное число N: "); 
// int N = Convert.ToInt32(Console.ReadLine()); 
//         if (N <= 0) 
//         { 
//             Console.WriteLine("Число должно быть натуральным"); 
//         } 
//         else 
//         { 
//             string digits = ""; 
 
//             while (N > 0) 
//             { 
//                 int digit = N % 10; 
//                 digits = digit + ", " + digits; 
//                 N = N / 10; 
//             } 
 
//             digits = digits.Remove(digits.Length - 2); // Удаляем лишнюю запятую и пробел в конце 
 
//             Console.WriteLine($"Цифры числа через запятую: {digits}"); 
//         } 
//     } 
// } 
// }

/* 
Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.
 /




var n = 12345;
Console.WriteLine($"{n / 10000}")
/
/
Console.WriteLine(n % 10);
while(n >= 10) {
    n = n / 10;
    Console.WriteLine(n % 10);
}*/

Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = (int)Math.Ceiling(Math.Log(n, 10)) - 1; i >= 0; i--) {
    Console.Write((n / (int)Math.Pow(10, i)) % 10);

    if (i == 0)
        Console.Write("\n");
    else
        Console.Write(",");
}

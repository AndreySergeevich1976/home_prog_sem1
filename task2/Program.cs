//Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Clear();
Console.Write("Введите координаты точки X ");
int x = int.Parse(Console.ReadLine()!);

while (x == 0){
Console.Write("Вы ошиблись! Введите X не равно 0: ");
x = int.Parse(Console.ReadLine()!);
}
Console.Write("Введите координаты точки Y ");
int y = int.Parse(Console.ReadLine()!);

while (y == 0){
Console.Write("Вы ошиблись! Введите Y не равно 0: ");
y = int.Parse(Console.ReadLine()!);
}

if (x > 0 && y > 0) Console.WriteLine($"x - {x} y - {y} в плоскости 1");
else 
if (x > 0 && y < 0) Console.WriteLine($"x - {x} y - {y} в плоскости 4");
else 
if (x < 0 && y < 0) Console.WriteLine($"x - {x} y - {y} в плоскости 3");
else 
if (x < 0 && y > 0) Console.WriteLine($"x - {x} y - {y} в плоскости 2");
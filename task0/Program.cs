// 17. Напишите программу, которая 
// 1.принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и 
// 2.выдаёт номер четверти плоскости, в которой находится эта
// точка.
//Console.Clear(); для очистки экрана при новом запуске

Console.WriteLine("Введите координаты точки: ");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Точка находится в первой четверти");
else if (x < 0 && y > 0) Console.WriteLine("Точка находится во второй четверти");
else if (x < 0 && y < 0) Console.WriteLine("Точка находится в третьей четверти");
else if (x > 0 && y < 0) Console.WriteLine("Точка находится в четвертой четверти");
else Console.WriteLine("Введены некорректные координаты");



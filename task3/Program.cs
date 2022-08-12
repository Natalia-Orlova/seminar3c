// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

// 3 -> 1, 4, 9
// 5 -> 1, 4, 9, 16, 25

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----------");
Console.WriteLine(" n  | n^2 ");
Console.WriteLine("----------");

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"{i, 3} | {i*i, 4}");  
}
Console.WriteLine("----------");

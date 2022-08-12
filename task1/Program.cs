// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string Range(int q)
{
    if (q == 1) return "Диапазон возможных координат : x > 0 и y > 0";
    if (q == 2) return "Диапазон возможных координат : x < 0 и y > 0";
    if (q == 3) return "Диапазон возможных координат : x < 0 и y < 0";
    if (q == 4) return "Диапазон возможных координат : x > 0 и y < 0";
    return "Введен некорректный номер четверти";
}

string result = Range(quarter);
Console.WriteLine(result);
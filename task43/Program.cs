// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;

Console.Write("Введите k1: ");
bool DigitK1 = int.TryParse(Console.ReadLine(), out int k1);
Console.Write("Введите b1: ");
bool DigitB1 = int.TryParse(Console.ReadLine(), out int b1);
Console.Write("Введите k2: ");
bool DigitK2 = int.TryParse(Console.ReadLine(), out int k2);
Console.Write("Введите b2: ");
bool DigitB2 = int.TryParse(Console.ReadLine(), out int b2);

if(!DigitK1 || !DigitB1 || !DigitK2 || !DigitB2)
{
    Console.WriteLine("Ошибка! Вы ввели не то! ПереВВедите!");
    return;
}

if (k1 == k2)
{
    Console.WriteLine("Прямые не перескаются");
    return;
}
(int, int) pointcrossline = GetPointCross(b1, b2, k1, k2); // метод Кортеже - когда метод передает два значения

Console.WriteLine($"Точка пересечения в координатах X = {pointcrossline.Item1}, Y = {pointcrossline.Item2}");

(int, int) GetPointCross(int b1, int b2, int k1, int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    return (x, y);
}
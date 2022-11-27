// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел которое собираетесь ввести");
int m = Convert.ToInt32(Console.ReadLine());

int [] numbers = FillArray(m);

PrintArray(numbers);

int count = GetCountPositive(numbers);
Console.Write($"Количество чисел больше  нуля = {count}");

int [] FillArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Вы ввели следующие числа: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int GetCountPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
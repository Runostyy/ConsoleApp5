using System;

class Program
{
    static void Main()
    {
        // Створення масиву чисел
        int[] numbers = { 12, 12, 15, 18, 17, 18, 28 };

        // Обчислення суми чисел
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        // Обчислення різниці чисел
        int difference = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            difference -= numbers[i];
        }

        // Виведення результатів
        Console.WriteLine($"Сума чисел: {sum}");
        Console.WriteLine($"Різниця чисел: {difference}");
    }
}

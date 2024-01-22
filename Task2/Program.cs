using System;

class Program
{
    static void Main()
    {
       
        int arraySize = 10; 

        int[] numbers = GenerateRandomNumbers(arraySize);

        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);

        int evenCount = CountEvenNumbers(numbers);
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        return numbers;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}


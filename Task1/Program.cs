using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число (для завершения введите 'q'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (IsEvenSum(int.Parse(input)))
            {
                Console.WriteLine("Сумма цифр чётная. Программа завершена.");
                break;
            }
        }
    }

    static bool IsEvenSum(int number)
    {
        int sum = 0;
        foreach (char digit in number.ToString())
        {
            sum += int.Parse(digit.ToString());
        }

        return sum % 2 == 0;
    }
}

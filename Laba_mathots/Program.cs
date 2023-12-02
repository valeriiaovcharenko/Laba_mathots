using System;

//1 завдання
class Calculator
{
    static double PerformOperation(double operand1, double operand2, char operation)
    {
        switch (operation)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                if (operand2 != 0)
                    return operand1 / operand2;
                else
                    throw new DivideByZeroException("Не може дорiвнювати 0");
            default:
                throw new ArgumentException("Провал");
        }
    }
    static void Main()
    {
        double operand1, operand2, result;
        char operation;

        Console.Write("операнда 1: ");
        operand1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("операнда 2: ");
        operand2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Оберiть операцiю (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        try
        {
            result = PerformOperation(operand1, operand2, operation);
            Console.WriteLine($"результат: {result}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
        }

        //2 завдання
        int numberToCheck = 17;
        bool isPrime = IsPrime(numberToCheck);
        Console.WriteLine($"2. {numberToCheck} є простим числом: {isPrime}");

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        //3 завдання

        double amount = 100;
        double exchangeRate = 40;
        string convertedCurrency = convertCurrency(amount, exchangeRate, "EUR", "UAH");

        Console.WriteLine($"{amount} EUR = {convertedCurrency} ");

        static double ConvertCurrency(double amount, double exchangeRate)
        {
            return amount * exchangeRate;
        }

        static string convertCurrency(double amount, double exchangeRate, string fromCurrency, string toCurrency)
        {
            double convertedAmount = ConvertCurrency(amount, exchangeRate);
            return $"{convertedAmount} {toCurrency}";
        }

        //4 завдання
        int[] array = { 5, 2, 8, 1, 7, 3, 9, 4, 6 };
        var minMax = FindMinMax(array);
        Console.WriteLine($"4. Найменший елемент: {minMax.Item1}");
        Console.WriteLine($"Найбiльший елемент: {minMax.Item2}");

        static Tuple<int, int> FindMinMax(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException(" Масив не повинен бути порожнiм або нульовим.");
            }

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return new Tuple<int, int>(min, max);
        }

        //5 завдання

        string inputString = "Hello, World!";
        var counts = CountVowelsAndConsonants(inputString);

        Console.WriteLine($"5. Кiлькiсть голосних Hello, World!: {counts.Item1}");
        Console.WriteLine($"Кiлькiсть приголосних: {counts.Item2}");

        static Tuple<int, int> CountVowelsAndConsonants(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Рядок не повинен бути порожнiм або нульовим.");
            }

            int vowelsCount = 0;
            int consonantsCount = 0;

            string lowercaseInput = input.ToLower();

            foreach (char ch in lowercaseInput)
            {
                if (char.IsLetter(ch))
                {
                    if ("aeiou".Contains(ch))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantsCount++;
                    }
                }
            }

            return new Tuple<int, int>(vowelsCount, consonantsCount);

        }

        //6 завдання
        Console.Write(" Введiть довжину ребра куба: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double surfaceArea = CalculateSurfaceArea(sideLength);
        double volume = CalculateVolume(sideLength);

        Console.WriteLine($"Площа куба: {surfaceArea}");
        Console.WriteLine($"Об'єм куба: {volume}");

        static double CalculateSurfaceArea(double sideLength)
        {
            return 6 * sideLength * sideLength;
        }

        // Функція для обчислення об'єму куба
        static double CalculateVolume(double sideLength)
        {
            return Math.Pow(sideLength, 3);
        }

    }
}
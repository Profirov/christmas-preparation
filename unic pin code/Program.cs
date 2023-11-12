
        int firstDigitLimit = int.Parse(Console.ReadLine());
        int secondDigitLimit = int.Parse(Console.ReadLine());
        int thirdDigitLimit = int.Parse(Console.ReadLine());

        for (int firstDigit = 2; firstDigit <= firstDigitLimit; firstDigit += 2)
        {
            for (int secondDigit = 2; secondDigit <= secondDigitLimit; secondDigit++)
            {
                if (IsPrime(secondDigit))
                {
                    for (int thirdDigit = 2; thirdDigit <= thirdDigitLimit; thirdDigit += 2)
                    {
                        Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                    }
                }
            }
        }
    

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }


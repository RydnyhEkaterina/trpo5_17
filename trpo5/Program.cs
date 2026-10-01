

        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 10)
        {
            Console.WriteLine("Число должно содержать минимум 2 цифры.");
            return;
        }

int temp = n;
int totalSum = 0;

        while (temp > 0)
        {
            totalSum += temp % 10;
            temp /= 10;
        }

int rightSum = 0;
int divisor = 10;
int minDiff = int.MaxValue;
int bestLeft = 0;
int bestRight = 0;

        while (divisor <= n / 10)
        {
    int digit = (n % divisor) / (divisor / 10);
            rightSum += digit;

    int left = n / divisor;
    int right = n % divisor;
    int leftSum = totalSum - rightSum;

    int diff = Math.Abs(leftSum - rightSum);

            if (diff < minDiff)
            {
                minDiff = diff;
                bestLeft = left;
                bestRight = right;
            }

    divisor *= 10;

        }

        Console.WriteLine("Первая часть: " + bestLeft);
        Console.WriteLine("Вторая часть: " + bestRight);
        Console.WriteLine("Минимальная разность: " + minDiff);
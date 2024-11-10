using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 3;
        Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;

        if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);

        if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));

        throw new ArgumentException("Geçersiz parametreler: m ve n negatif olamaz.");
    }
}

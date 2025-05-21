namespace Fundamentals.Helpers
{
    public static class NumeroPrimo
    {
        public static void Print()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool isPrimo = true;
                if (i > 1)
                {
                    for (int x = 2; x < i; x++)
                    {
                        double result = i % (double)x;
                        if (result == 0) isPrimo = false;
                    }
                }
                if (isPrimo) Console.WriteLine($"{i} es primo");
            }
        }
    }
}
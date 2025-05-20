namespace Fundamentals.Helpers
{
    public static class Fibonacci
    {
        public static void Start()
        {
            long num1 = 0;
            long num2 = 1;
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(num1);
                long newNum2 = num1 + num2;
                num1 = num2;
                num2 = newNum2;
            }
        }
    }
}
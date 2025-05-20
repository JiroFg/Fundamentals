namespace Fundamentals.Helpers
{
    public static class FizzBuzz
    {
        public static void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                string value = "";
                if (i % 3 == 0) value = "fizz";
                if (i % 5 == 0) value += "buzz";
                Console.WriteLine($"{i}: {value}");
            }
        }
    }
}
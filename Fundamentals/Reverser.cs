namespace Fundamentals.Helpers
{
    public class Reverser
    {
        public static void Reverse(string text)
        {
            string reverseText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText += text[i];
            }
            System.Console.WriteLine(reverseText);
        }
    }
}
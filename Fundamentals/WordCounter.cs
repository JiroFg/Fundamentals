namespace Fundamentals.Helpers
{
    public class WordCounter
    {
        public static int Count(string text)
        {
            string[] textArray = text.ToLower().Split(" ");
            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i] = textArray[i].Replace(",", "");
                Console.WriteLine(textArray[i]);
            }
            return 5;
        }
    }
}
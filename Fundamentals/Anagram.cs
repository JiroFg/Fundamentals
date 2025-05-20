namespace Fundamentals.Helpers
{
    public static class Anagram
    {
        public static bool IsAnagram(string firstWord, string secondWord)
        {
            char[] firstChartAux = firstWord.ToLower().ToArray();
            char[] secondChartAux = secondWord.ToLower().ToArray();
            if (firstWord.ToLower().Equals(secondWord.ToLower())) return false;
            Array.Sort(firstChartAux);
            Array.Sort(secondChartAux);
            if (new string(firstChartAux).Equals(new string(secondChartAux)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
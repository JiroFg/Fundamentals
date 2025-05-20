using Fundamentals.Helpers;

// FizzBuzz.Start();
string firstWord = Console.ReadLine();
string secondWord = Console.ReadLine();
bool result = Anagram.IsAnagram(firstWord, secondWord);
System.Console.WriteLine(result);

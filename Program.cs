using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        int vowelCount = CountRussianVowels(input);

        Console.WriteLine($"Количество гласных букв: {vowelCount}");
    }

    static int CountRussianVowels(string text)
    {
        if (string.IsNullOrEmpty(text))
            return 0;

        char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

        int count = 0;

        foreach (char c in text)
        {
            char LowerChar = char.ToLower(c);

            if (Array.IndexOf(vowels, LowerChar) >= 0)
            {
                count++;
            }
        }
        return count;
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение: ");
        string inputPhrase = Console.ReadLine();
        string reversedPhrase = ReverseWords(inputPhrase);
        Console.WriteLine("Предложение с переставлеными словами ");
        Console.WriteLine(reversedPhrase);
        Console.ReadKey();
    }
    //метод разделения предложения на слова
    static string[] SplitText(string text)
    {
        //разделения строки по пробелам и удаления пустых элементов
        string[] words = text.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }
    // Метод для перестановки слов в обратной последовательности
    static string ReverseWords(string inputPhrase)
    {
        string[] words = SplitText(inputPhrase);
        Array.Reverse(words); // Перестановка слов в обратной последовательности

        // Сборка слов обратно в предложение с пробелами
        string reversedPhrase = string.Join(" ", words);

        return reversedPhrase;
    }
}
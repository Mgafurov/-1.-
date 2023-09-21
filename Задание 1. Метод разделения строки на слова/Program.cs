using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение: ");
        string inputText = Console.ReadLine();
        string[] words = SplitText(inputText);
        Console.WriteLine("Слова в предложении: ");
        PrintWords(words);
        Console.ReadKey();
    }
    //метод разделения строки на слова
    static string[] SplitText(string text)
    {
        //разделения строки по пробелам и удаление пустых элементов
        string[] words = text.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }
    //метод для вывода слов на экран
    static void PrintWords(string[] words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
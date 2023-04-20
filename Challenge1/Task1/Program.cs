using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
 

        // Відкриваємо вхідний файл для читання
        string inputPath = "D:/lab/input.txt";
        StreamReader inputFile = new StreamReader(inputPath);

        // Відкриваємо вихідний файл для запису
        string outputPath = "D:/lab/output.txt";
        StreamWriter outputFile = new StreamWriter(outputPath);

        // Зчитуємо дані з вхідного файлу та записуємо їх у зворотньому порядку у вихідний файл
        string line;
        while ((line = inputFile.ReadLine()) != null)
        {
            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            outputFile.WriteLine(new string(charArray));
        }

        // Закриваємо файли
        inputFile.Close();
        outputFile.Close();

        Console.WriteLine("File successfully reversed.");
    }
}
using System;
class Program
{
    static void Main(string[] args)
    {
        //Ііедення індексу
        string input;
        Console.WriteLine("Введiть iндекс");
        input = Console.ReadLine();
        int index = Int32.Parse(input);

        
        int fibonacci = Fibonacci(index);

        // Виводимо результат
        Console.WriteLine("Fibonacci({0}) = {1}", index, fibonacci);
    }
    // Обчислюємо число Фібоначчі
    static int Fibonacci(int index)
    {
        if (index < 0)
        {
            throw new ArgumentException("Індекс повинен бути вищим нуля");
        }

        int a = 0;
        int b = 1;

        for (int i = 0; i < index; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a;
    }
}

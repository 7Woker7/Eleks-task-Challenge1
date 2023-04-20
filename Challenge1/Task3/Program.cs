using System;

class Program
{
    static void Main(string[] coordinates)
    {

        //Перевірка введення координат
        if (coordinates.Length < 4)
        {
            Console.WriteLine("Заданих координат недостатньо для обчислення");
            return;
        }

        // Перетворюємо кординати в числа
        double x1, y1, x2, y2;
        if (!double.TryParse(coordinates[0], out x1) || !double.TryParse(coordinates[1], out y1)
            || !double.TryParse(coordinates[2], out x2) || !double.TryParse(coordinates[3], out y2))
        {
            Console.WriteLine("Координати введено некоректно");
            return;
        }

        // Обчислюємо кути відносно вісі ОХ для точок А та В
        double angleA = Math.Atan2(y1, x1) * 180 / Math.PI;
        double angleB = Math.Atan2(y2, x2) * 180 / Math.PI;

        // Визначаємо, який відрізок утворює більший кут
        if (angleA > angleB)
        {
            Console.WriteLine("ОА утворює більший кут з віссю ОХ.");
        }
        else if (angleB > angleA)
        {
            Console.WriteLine("ОВ утворює більший кут з віссю ОХ.");
        }
        else
        {
            Console.WriteLine("ОА та ОВ утворюють однаковий кут з віссю ОХ.");
        }
    }
}
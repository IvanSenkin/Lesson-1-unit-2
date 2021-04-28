using System;

namespace Lesson_1_unit_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            Console.Write("Введите вес человека в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост человека в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Индекс массы тела: {weight / (height * height):F3}");
        }
    }
}

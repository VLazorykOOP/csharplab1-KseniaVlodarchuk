#nullable enable
using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace webadd_Khoyskiy;

class Program
{
    static void task1()
    {
        Console.WriteLine("Task1 !");
        Console.Write("Введіть значення першого члена геометричної прогресії\n");
        int a1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть значення знаменника геометричної прогресії\n");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість членів геометричної прогресії\n");
        int n = int.Parse(Console.ReadLine());

        long sum = 0;

        for (int i = 0; i < n; i++)
        {           
            long currentTerm = a1 * (long)Math.Pow(q, i);
            sum += currentTerm;
        }
        Console.WriteLine("Сума членів геометричної прогресії: " + sum);

    }
    static void task2()
    {
        Console.WriteLine("Task2 !");
        Console.Write("Введіть сторони трикутника : ");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Трикутник рівносторонній");
        }
        else { Console.WriteLine("Трикутник не рівносторонній"); }


    }
    static void task3()
    {
        Console.WriteLine("Task3 !");
        Console.Write("Введiть x та y:  ");
        string? strx = Console.ReadLine();

        float x = 0, y = 0;
        if (strx != null)
        {
            x = float.Parse(strx);
        }
        string? stry = Console.ReadLine();
        if (stry != null)
        {
            y = float.Parse(stry);
        }
        if (y <= 23 && y >= 0 && x >= -23 && x <= 0)
        {
            if (y == 23 || x == 0 || -x == y) { Console.WriteLine("На межi"); }
            else if (y > (-x)) { Console.WriteLine("Так"); }
            else { Console.WriteLine("Нi"); }
        }
        else { Console.WriteLine("Нi"); }
    }
    static void task4()
    {
        // Зчитуємо порядковий номер місяця з консолі
        Console.Write("Введіть порядковий номер місяця: ");
        int month = int.Parse(Console.ReadLine());

        // Перевіряємо чи введено коректний номер місяця
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Некоректний номер місяця. Введіть число від 1 до 12.");
        }
        else
        {
            // Обчислюємо кількість місяців до кінця року
            int monthsLeft = 12 - month;

            // Виводимо результат на екран
            Console.WriteLine($"Залишилось {monthsLeft} місяців до кінця року.");
        }
    }
    static int Cube(int a, int b)
    {
        int product = a * b;
        int cube = product * product * product;

        return cube;

    }
    static void task6()
    {
        Console.WriteLine("Введiть перше число:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введiть друге число:");
        int m = int.Parse(Console.ReadLine());
        double result = (n + m) * (((n+1.0)/(m+1.0))+(5.0/m));
        Console.WriteLine("Answer " + result.ToString($"F{3}"));
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Lab 1 !");
            Console.WriteLine("Введiть номер завдання:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    Console.WriteLine("Введiть перше число:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введiть друге число:");
                    int num2 = int.Parse(Console.ReadLine());

                    int result = Cube(num1, num2);

                    Console.WriteLine($"Куб з добутку {num1} i {num2} дорiвнює {result}");
                    break;
                case 6:
                    task6();
                    break;
                default:
                    Console.WriteLine("Не вiрно");
                    break;
            }
        }
    }
}

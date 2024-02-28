// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s= ");
    string? str = Console.ReadLine();
    float s = 0; 
    if (str != null) s = float.Parse(str);
    double p = 4 * Math.Sqrt(s);
    Console.WriteLine("p=" + p);

}
Console.WriteLine("Lab 1 !");
task1();
// continue ...

 
static void Main()
{
    Console.WriteLine("Input the first term of the geometric progression:");
    double firstTerm = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Input the denominator of the geometric progression:");
    double commonRatio = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the number of members of the geometric progression:");
    int numberOfTerms = Convert.ToInt32(Console.ReadLine());

    double sum = CalculateGeometricProgressionSum(firstTerm, commonRatio, numberOfTerms);

    Console.WriteLine($"Sum {numberOfTerms} members of the geometric progression: {sum}");
}

static double CalculateGeometricProgressionSum(double firstTerm, double commonRatio, int numberOfTerms)
{
    // Перевірка на те, чи знаменник не дорівнює 1, щоб уникнути ділення на нуль
    if (commonRatio == 1)
    {
        Console.WriteLine("The denominator cannot be equal to 1 in a geometric progression");
        return double.NaN; // Повертаємо не число у випадку помилки
    }

    // Використовуємо формулу суми геометричної прогресії
    double sum = firstTerm * (1 - Math.Pow(commonRatio, numberOfTerms)) / (1 - commonRatio);
    return sum;
}


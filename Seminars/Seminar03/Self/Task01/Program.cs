internal class Program
{
    public static void Main()
    {
        Console.Write("Введите количество углов: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите длину стороны: ");
        int l = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((n * Math.Pow(l, 2)) / (4 * Math.Tan(Math.PI / n)));

        Console.ReadKey();
    }
}
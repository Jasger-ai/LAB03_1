namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма {num1 + num2}");
            Console.WriteLine($"Произведение {num1 * num2}");
            Console.WriteLine($"Частное {num1 / num2}");
            Console.WriteLine($"Ср. арифм {(num1 + num2)/2}");
        }
    }
}

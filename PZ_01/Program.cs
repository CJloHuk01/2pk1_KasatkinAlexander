namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводим переменные а b с
            Console.WriteLine("Введите переменную a");
            double a = double.Parse(Console.ReadLine());
            if (a < 0) // проверка на недопустимые значения a
            {
                Console.WriteLine("Недопустимое значение, введите снова корректное число");
                a = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите переменную b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите переменную c");
            double c = double.Parse(Console.ReadLine());
            if (c == 0) // проверка на недопустимые значения c
            {
                Console.WriteLine("Недопустимое значение, введите снова корректное число");
                c = double.Parse(Console.ReadLine());
            }
            // разбиваем пример на части и решаем по отдельности 
            double num1 = Math.Pow(10, 4) * Math.Pow(Math.Sin(2.5 * c), 2);
            double num2 = (0.32 * Math.Pow(c, 3) + (4 * c) + b) / Math.Cos(2 * a);
            double num3 = Math.Pow(0.32 * Math.Pow(c, 3) - b, 1 / 6);
            double result = num1 - num2 * num3 + Math.Abs(b);
            Console.WriteLine("Ваш результат: " + result); // выводим результат        
        }
    }
}
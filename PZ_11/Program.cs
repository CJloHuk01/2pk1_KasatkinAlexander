namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            int radius = Convert.ToInt32(Console.ReadLine());

            // Вычисляем площадь круга
            double S_circle = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"Площадь круга равна {S_circle}");

            // Вычисляем объем и площадь сферы
            double obem = Math.Pow(radius, 3) * (4 / 3) * Math.PI;
            double S_spheri = 4 * Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine($"Объем сферы  равен {obem}");
            Console.WriteLine($"Площадь сферы равна {S_spheri}");

        }
    }
}

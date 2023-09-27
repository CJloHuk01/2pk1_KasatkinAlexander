namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-100, 101);
                Console.Write($" {array[i]}, ");
            }

            Console.WriteLine();
            int min = array.Min();
            Console.WriteLine($"Минимальный элемент: {min}");

            int max = array.Max();
            Console.WriteLine($"Максимальный элемент: {max}");

            int sum = min + max;
            int a = min * max;
            Console.WriteLine($"Сумма минимального и максимального элементов: {sum}");
            Console.WriteLine($"Произведение минимального и максимального элементов: {a}");

            double b = array.Sum(); 
            double c = b / array.Length; 
            Console.WriteLine($"Среднее арифметическое элементов массива: {c}");

        }
    }
}
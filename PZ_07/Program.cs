namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту и длину массива: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] array = new int[i, i];
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < i; b++)
                {
                    array[a, b] = rnd.Next(-100, 100);
                }
            }
            Console.WriteLine();
            int v = array.GetLength(0);
            int s = array.GetLength(1);
            for (int a = 0; a < v; a++)
            {
                for (int b = 0; b < s; b++)
                {
                    Console.Write(array[a, b] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("сумма элементов в столбцах: ");
            int sum = 0;
            for (int b = 0; b < array.GetLength(0); b++)
            {
                for (int a = 0; a < array.GetLength(1); a++)
                {
                    sum += array[a, b];
                }
                Console.Write(sum + "\t");
                sum = 0;
            }
        }
    }
}
//почему-то не работает код, если задать разное кол-во столбцов и строк, поэтому будут одинаковыe

using System;

namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:"); 
            string s = Console.ReadLine();

            Console.WriteLine("\nВведите требуемую длину строки:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Проверка на то, что N больше 0
            if (n > 0)
            {
                // Если длина строки больше N, отбрасываем первые символы
                if (s.Length > n)
                    s = s.Substring(s.Length - n);

                // Иначе, если длина строки меньше N, добавляем точки в начало строки
                else if (s.Length < n)
                    s = new String('.', n - s.Length) + s;
                Console.WriteLine($"Отформатированная строка длины {n}: {s}");
            }
            else Console.WriteLine("Число должно быть больше 0");            
        }
    }
}
        
    

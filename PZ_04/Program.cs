namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            for (int i = 30; i <= 120; i += 3) 
            {
            Console.WriteLine(i);
            }
            //
            //
            Console.WriteLine("Задание 2");
          
            for (char a = 'M'; a < 'R'; a++)
            Console.Write(a + " ");
            Console.WriteLine();
            //
            //
            Console.WriteLine("Задание 3");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("#");
                    Console.WriteLine();
                }
            }
            //
            //
            Console.WriteLine("Задание 4");
            int b = 0;
            for(int p = -100; p < 0; p++)
             
                if (p  % 7 == 0) 
                { 
                 Console.Write(p + " ");
                    b++;
                }
                Console.WriteLine();
                Console.WriteLine( "Количество чисел: " + b);
            //
            //
            Console.WriteLine("Задание 5");
            for (int q = 4, l = 50; q - l <= 12; q++, l--)
                Console.WriteLine(q + " " + l);

           

        }
    }
}
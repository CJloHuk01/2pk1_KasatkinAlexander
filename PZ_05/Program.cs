namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (N % 2 == 0 && N !=0) 
            {
                N = (N / 2);
                k++;
            
            }
            Console.WriteLine(k);
        }

    }
}
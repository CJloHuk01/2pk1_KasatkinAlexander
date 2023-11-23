namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вводим текст
            string text = Console.ReadLine();
            //делим текст на предложения
            string[] predlojenie = text.Split( ". ");
            //создание массива
            string[][] words = new string[predlojenie.Length][];

            for (int i = 0; i < predlojenie.Length; i++)
            {
                //разделение строки на слова
                string[] predlojWords = predlojenie[i].Split(' ');
                words[i] = predlojWords;
            }

            Console.WriteLine("Двумерный массив слов:");

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"Строка {i + 1}: ");
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
    

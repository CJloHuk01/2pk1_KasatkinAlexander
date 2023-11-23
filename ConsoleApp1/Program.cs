namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Произвольный текст ыравыоар выщары флы лы л. для сортировки предложений по. количеству слов.";

            // Разделение текста на предложения
            string[] sentences = text.Split('.');

            // Удаление пустых предложений
            sentences = sentences.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            // Сортировка предложений по количеству слов
            Array.Sort(sentences, (a, b) => a.Split(' ').Length.CompareTo(b.Split(' ').Length));

            // Вывод отсортированных предложений
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
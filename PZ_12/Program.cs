namespace PZ_12
{
    internal class Program
    {
        static bool IsPalindrome(string str)
        {
            // Удаление знаков препинания, пробелов и приведение к нижнему регистру
            string cleanedStr = "";
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    cleanedStr += char.ToLower(c);
                }
            }

            // Проверка на палиндром
            int left = 0;
            int right = cleanedStr.Length - 1;

            while (left < right)
            {
                if (cleanedStr[left] != cleanedStr[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPalindrome = IsPalindrome(input);

            Console.WriteLine($"{input} - {isPalindrome}");
        }
    }
}


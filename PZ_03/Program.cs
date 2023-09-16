namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Висит груша нельзя скушать. Что это?");
         
                var a = Console.ReadLine();

                switch (a)
                {
                    case "сдаюсь":
                        Console.WriteLine("Правильный ответ: лампочка");
                        break;
                    case "лампочка":
                        Console.WriteLine("Правильно");
                        return;
                    default:
                        Console.WriteLine("Ответ не верный");
                    break;


                }
        }
    }
}
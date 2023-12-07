namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к каталогу:");
            string path = Console.ReadLine();
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            DirectoryInfo[] subDirs = dirInfo.GetDirectories();
            Array.Sort(subDirs, (x, y) =>
            {
                long xSize = x.GetFiles(".", SearchOption.AllDirectories).Length;
                long ySize = y.GetFiles(".", SearchOption.AllDirectories).Length;
                return (xSize > ySize) ? -1 : 1;
            });
            for (int i = 0; i < subDirs.Length; i++)
            {
                Console.WriteLine(subDirs[i].Name);
            }
            Console.ReadKey();
        }
    }
}

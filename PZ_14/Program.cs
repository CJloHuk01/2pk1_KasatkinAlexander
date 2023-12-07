using System;
using System.IO;
using System.Reflection.Metadata;
namespace PZ_14
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //создание перепенных для работы с ними
            string file1 = "f1.txt";
            string file2 = "f2.txt";
            //прочтение первого файла
            using (StreamReader reader = new StreamReader(file1))
            //измененение вотрого файла с помощью while и if
            using (StreamWriter writer = new StreamWriter(file2))
            {
                
                string line;
                int lineNumber = 1;
                //пока строка не пустая, то есть 0, выполняется цикл
                while ((line = reader.ReadLine()) != null)
                {
                    //четность строки
                    if (lineNumber % 2 == 0)
                    {
                        writer.WriteLine(line);
                    }

                    lineNumber++;
                }
            }

            Console.WriteLine("Четные строки из файла f1 записаны в файл f2.");
        }
    }
    
}

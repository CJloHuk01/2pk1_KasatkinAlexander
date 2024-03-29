﻿namespace PZ_20
{
    /*
     * ФИО студента: Касаткин Александр Геннадьевич
     * номер варианта: 10
     * условие задачи (скопировать из листа задания): За основу берется класс, разработанный на 17 практике (создание простого класса).
Для этого класса необходимо реализовать следующие интерфейсы:
1. IClonable с реализацией глубокого копирования (если присутствуют ссылочные
поля)
2. IComporable (по какому из полей будет производится сравнение объектов –
выбираете на свое усмотрение, главное адекватность. Например, сравнение
посылок по весу, пользователей по дате регистрации и т.д.)
Создать массив/список на 10 объектов данного класса и отсортировать эту
коллекцию через стандартный метод Sort()
3. IDisposable. (разбор самостоятельный здесь)
4. Создать пользовательский интерфейс, в который вынести контракт на реализацию
специфичного для вашего класса функционала (например, для пользователя
ресурса (IUser) это может быть идентификатор(свойство) регистрация(метод)
удаление аккаунта (метод)).
Создать новый класс, в котором реализовать данный интерфейс.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil[] pupil =
            {
                new Pupil("Sasha", "7Б", 5, 3, 3),
                new Pupil("Kirill", "7A", 5, 5, 4),
                new Pupil("Daniil", "6Г", 4, 5, 5),
                new Pupil("Andrey", "8A", 3, 3, 3),
                new Pupil("Ilya", "6A", 4, 4, 2),
                new Pupil("Dmitriy", "9Ж", 5, 5, 5),
                new Pupil("Ivan", "6C", 4, 5, 5),
                new Pupil("Timofey", "5Ы", 5, 2, 2),
                new Pupil("NIkita", "8Й", 2, 2, 5),
                new Pupil("Oleg", "9Г", 2, 2, 2)
            };

            Array.Sort(pupil);
            foreach (Pupil pup in pupil)
            {
                Console.WriteLine(pup);
            }

            Pupil pupil12 = (Pupil)pupil[5].Clone();
            pupil12.klass = "5Б";
            pupil12.name = "Nadezhda";
            Console.WriteLine($"\n\nKлонированный ученик:\n\n" +
                $"{pupil12}\n\n");
            pupil[0].Present();
            pupil[4].Absent();
        }
    }
}
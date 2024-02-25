using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_20
{
    internal class Pupil : ICloneable, IComparable<Pupil>, IDisposable
    {
        public string name;
        public string klass;
        public int mathMark;
        public int physMark;
        public int chemMark;
        public double mediumMark;
        private bool disposedValue;

        public double GetMediumMark()
        {
            return (mathMark + physMark + chemMark) / 3;
        }

        public override string ToString()
        {
            return $"Человек: {name}\n" +
                 $"класс: {klass}\n" +
                 $"оценка по математике: {mathMark}\n" +
                 $"оценка по физике: {physMark}\n" +
                 $"оценка по химии: {chemMark}\n" +
                 $"средняя оценка по предметам: {mediumMark}\n";
        }
        public Pupil(string name, string klass, int mathMark, int physMark, int chemMark)
        {
            this.name = name;
            this.klass = klass;
            this.mathMark = mathMark;
            this.physMark = physMark;
            this.chemMark = chemMark;
            mediumMark = GetMediumMark();

        }
        public object Clone()
        {
            return new Pupil(this.name, this.klass, this.mathMark, this.physMark, this.chemMark);
        }
        public int CompareTo(Pupil other)
        {
            return name.CompareTo(other.name);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~Pupil()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void Present()
        {
            Console.WriteLine($"{name} присутствует на уроке");
        }
        public void Absent()
        {
            Console.WriteLine($"{name} отсутствует на уроке(пропуск)");
        }
    }
}

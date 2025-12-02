using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Rang<T> where T : INumber<T> , IComparable<T>
    {
        public T Minmum { get; set; }
        public T Maxmum { get; set; }

        public Rang(T min , T max){
            Minmum = min; Maxmum = max;

            }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minmum) >= 0 && value.CompareTo(Maxmum) <=0;
        }

        public T Length()
        {
            return Maxmum - Minmum;

        }

    }
}

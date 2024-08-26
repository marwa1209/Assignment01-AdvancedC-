using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_AdvancedC_.Question2
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T max, T min)
        {
            if (min.CompareTo(max) > 0)
            {
                Console.WriteLine("Minimum value should not be greater than maximum value.");
            }
            Max = max;
            Min = min;
        }
        public bool IsInRange(T value)
        {
            if (value is not null)
            {
                return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
            }
            return false;
        }
        public T Length()
        {
            return (dynamic)Max - (dynamic)Min;
        }
    }
}

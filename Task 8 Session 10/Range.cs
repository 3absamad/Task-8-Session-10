using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8_Session_10
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }
            Max = max;
            Min = min;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >=0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length() {
            return (dynamic) Max - (dynamic)Min;
        }
    }
}

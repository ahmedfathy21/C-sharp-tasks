using System;

namespace GenericRange
{
    // Generic Range<T> class
    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min must be less than or equal to Max.");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length()
        {
            try
            {
                return (dynamic)Max - (dynamic)Min;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                throw new InvalidOperationException("Length can only be calculated for numeric types.");
            }
        }
    }

    // Test class with Main method
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔍 Testing Range<int>:");
            var intRange = new Range<int>(10, 20);
            Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");   // True
            Console.WriteLine($"Is 25 in range? {intRange.IsInRange(25)}");   // False
            Console.WriteLine($"Length: {intRange.Length()}");                // 10

            Console.WriteLine("\n🔍 Testing Range<double>:");
            var doubleRange = new Range<double>(3.5, 7.2);
            Console.WriteLine($"Is 5.1 in range? {doubleRange.IsInRange(5.1)}");   // True
            Console.WriteLine($"Length: {doubleRange.Length()}");                 // 3.7

            Console.WriteLine("\n🔍 Testing Range<DateTime>:");
            var start = new DateTime(2024, 1, 1);
            var end = new DateTime(2024, 12, 31);
            var dateRange = new Range<DateTime>(start, end);
            Console.WriteLine($"Is 2024-06-01 in range? {dateRange.IsInRange(new DateTime(2024, 6, 1))}");  // True

            // Length for DateTime will throw unless handled separately, since you can't subtract DateTimes directly this way
            try
            {
                Console.WriteLine($"Length: {dateRange.Length()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Length Error: {ex.Message}");
            }
        }
    }
}

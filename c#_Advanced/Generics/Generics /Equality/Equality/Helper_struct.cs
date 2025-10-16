namespace Generics
{
    public struct HelperStruct<T> where T : IEquatable<T>
    {
        // Equality Operators Overload
        public static bool operator ==(HelperStruct<T> left, HelperStruct<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(HelperStruct<T> left, HelperStruct<T> right)
        {
            return !left.Equals(right);
        }

        // Optional: override Equals and GetHashCode for proper struct equality
        public override bool Equals(object obj)
        {
            // Structs are value types, so compare the actual data
            return obj is HelperStruct<T>; // Placeholder logic — real use depends on your intent
        }

        public override int GetHashCode()
        {
            return typeof(T).GetHashCode(); // or just 0 if it's stateless
        }

        // Linear Search - Safe & Null Tolerant
        public static int LinearSearch(T[] arr, T value)
        {
            if (arr is null || arr.Length == 0)
                return -1;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            for (int i = 0; i < arr.Length; i++)
            {
                if (comparer.Equals(arr[i], value))
                    return i;
            }
            return -1;
        }

        // Generic Swap
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
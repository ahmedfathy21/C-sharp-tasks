namespace Is_As;

public class Helper<T> where T : IEquatable<T>

{
 public static int Linear_Search(T[] arr, T value)
 {
  for (int i = 0; i < arr.Length; i++)
  {
   if (arr[i].Equals(value))
    return i;
  }
  return -1;
 }
 public static void Swap(ref T a, ref T b)
 {
  (a, b) = (b, a);
 }
 
}
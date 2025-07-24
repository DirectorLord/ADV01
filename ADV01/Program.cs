namespace ADV01;
public class BibbleSort
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        //parent loop
        for (int i = 0; i < n - 1; i++)
        {//child loop
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {   //bruh
                    //Swap(ref arr[j], ref arr[j+1]);
                    //will make a swapping mechanism
                    int temp = arr[j]; //temp 3rd variable
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
    //creating class range with <T>
    public class Range<T> where T : IComparable<T> {
        private T min;
        private T max;
        public Range(T min, T max) 
        {
            this.min = min;
            this.max = max;
        }
        public bool Equals(Range<T> value)
        //there was an error somewhere and when copilot fixed idk what it added
        {
            if (value.min.CompareTo(min) >= 0 && value.max.CompareTo(max) <= 0)
            {
                return true;
            }
            return false;
        }
    //making a T length comparison
    public T Length()
    {
        if (typeof(T) == typeof(int))
            return (T)(object)(Convert.ToInt32(max) - Convert.ToInt32(min));
        throw new InvalidOperationException("Length is only supported for types that can be converted to int.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("test");
    }
}

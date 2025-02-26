namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(10);
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nEnter the number you want to search: ");
            int search = int.Parse(Console.ReadLine());
            (int count, List<int> positions) = LinearSearch(array, search);
            Console.WriteLine($"Found {search} {count} times at {string.Join(',', positions)} positions.");
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
        }
        static (int, List<int>) LinearSearch(int[] array, int search)
        {
            int elementsCount = 0;
            List<int> values = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                {
                    elementsCount++;
                    values.Add(i);
                    if (i > 0)
                        (array[i-1], array[i]) = (array[i], array[i]);
                }
            }
            return (elementsCount, values);
        }
        static int[] GenerateArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }
    }
}

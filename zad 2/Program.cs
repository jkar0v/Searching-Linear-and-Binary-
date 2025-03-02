namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(100);
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nEnter the number you want to search: ");
            int search = int.Parse(Console.ReadLine());
            Array.Sort(array);
            (int count, List<int> positions) = BinarySearch(array, search);
            Console.WriteLine($"Found {search} {count} times at {string.Join(',', positions)} positions.");
        }
        static (int, List<int>) BinarySearch(int[] array, int search)
        {
            int elementsCount = 0;
            List<int> values = new List<int>();
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == search)
                {
                    elementsCount++;
                    values.Add(mid);

                    int tempLeft = mid - 1;
                    while (tempLeft >= left && array[tempLeft] == search)
                    {
                        elementsCount++;
                        values.Add(tempLeft);
                        tempLeft--;
                    }
                    int tempRight = mid + 1;
                    while (tempRight <= right && array[tempRight] == search)
                    {
                        elementsCount++;
                        values.Add(tempRight);
                        tempRight++;
                    }
                    break;
                }
                else if (array[mid] < search)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
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

// 
namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //..........Создаем и заполняем начальный массив..........//
            Console.WriteLine("Введите кол-во элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите значения массива");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]\n");
            Console.WriteLine("Отсортированный массив: [" + string.Join(", ", QuickSort(array, 0, array.Length - 1)) + "]");

            //..........Делаем сортировку..........//
            int[] QuickSort(int[] array, int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                    return array;
                int pivot = GetPivotIndex(array, minIndex, maxIndex);
                QuickSort(array, minIndex, pivot - 1);
                QuickSort(array, pivot - 1, maxIndex);
                return array;
            }

            int GetPivotIndex(int[] array, int minIndex, int maxIndex)
            {
                int pivotIndex = minIndex - 1;
                for (int i = minIndex; i <= maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivotIndex++;
                        Swap(ref array[pivotIndex], ref array[i]);
                    }
                }
                pivotIndex++;
                Swap(ref array[pivotIndex], ref array[maxIndex]);
                return pivotIndex;
            }

            void Swap(ref int leftValue, ref int rightValue)
            {
                int temp = leftValue;
                leftValue = rightValue;
                rightValue = temp;
            }

            void Swap2(int[] array, int leftValue, int rightValue)
            {
                int temp = array[leftValue];
                array[leftValue] = array[rightValue];
                array[rightValue] = temp;
            }
        }
    }
}
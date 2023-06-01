using System;

namespace WindowsPE.Algorithms
{
    public class QuickSort<T>
    {
        public T[] Array { get; set; }
        public Func<T, T, int> Comparator { get; set; }
        public int High { get; set; }
        public int Low { get; set; }

        public QuickSort(T[] arrayList, Func<T, T, int> c)
        {
            Array = arrayList;
            Comparator = c;
            High = arrayList.Length - 1;
            Low = 0;
        }

        public QuickSort(T[] arrayList, int low, int high, Func<T, T, int> c)
        {
            Array = arrayList;
            Comparator = c;
            High = high;
            Low = low;
        }

        public void Sort() => Qsort(this.Array, this.Low, this.High, this.Comparator);
        public T[] getArrayList() => Array;

        void Qsort(T[] array, int low, int high, Func<T, T, int> Comparator)
        {
            if (low < high)
            {
                int p = Partition(array, low, high, Comparator);
                Qsort(array, low, p - 1, Comparator);
                Qsort(array, p + 1, high, Comparator);
            }
        }

        void Swap(T[] array, int pos1, int pos2)
        {
            T temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        int Partition(T[] array, int low, int high, Func<T, T, int> Comparator)
        {
            T pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                try
                {
                    if (Comparator(array[j], pivot) <= 0)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
                catch { return 0; }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }


    }
}
  

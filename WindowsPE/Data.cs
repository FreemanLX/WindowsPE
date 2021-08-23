using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPE
{
    public static class Data
    {
        public static System.Drawing.Color color = System.Drawing.SystemColors.HotTrack; //blue
        public static System.Drawing.Color theme = System.Drawing.Color.White;
        public static System.Drawing.Color fortheme = System.Drawing.Color.Black;
        public static bool connected_to_internet = false;
        public static int opaque = 250;
    }

    public class Pair<Tpair1, Tpair2>
    {
        private Tpair1 first;
        private Tpair2 second;

        public Pair(Tpair1 pair1, Tpair2 pair2)
        {
            this.first = pair1;
            this.second = pair2;
        }

        public Tpair1 get_first()
        {
            return first;
        }

        public Tpair2 get_second()
        {
            return second;
        }

    }


    public class QuickSort<T>
    {

        T[] array;
        Func<T, T, int> comparator;
        int high;
        int low;


        public QuickSort(T[] arrayList, Func<T, T, int> c)
        {
            this.array = arrayList;
            this.comparator = c;
            this.high = arrayList.Length - 1;
            this.low = 0;
        }

        public QuickSort(T[] arrayList, int low, int high, Func<T, T, int> c)
        {
            this.array = arrayList;
            this.comparator = c;
            this.high = high;
            this.low = low;
        }

        public void sort()
        {
            qsort(this.array, this.low, this.high, this.comparator);
        }


        public T[] getArrayList()
        {
            return array;
        }

        void qsort(T[] array, int low, int high, Func<T, T, int> c)
        {
            if (low < high)
            {
                int p = partition(array, low, high, c);
                qsort(array, low, p - 1, c);
                qsort(array, p + 1, high, c);
            }
        }

        void swap_array_list(T[] array, int pos1, int pos2)
        {
            T temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        int partition(T[] array, int low, int high, Func<T, T, int> c)
        {
            T pivot = array[high];
            int index = low - 1;
            for (int jndex = low; jndex < high; jndex++)
            {
                try
                {
                    if (c(array[jndex], pivot) <= 0)
                    {
                        index++;
                        swap_array_list(array, index, jndex);
                    }
                }
                catch { return 0; }
            }
            swap_array_list(array, index + 1, high);
            return index + 1;
        }


    }

    public class XMLSettings
    {







    }
}
  

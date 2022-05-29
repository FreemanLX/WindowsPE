using System;
using System.Drawing;
using System.Windows.Forms;

namespace Browser
{
    public static class Data
    {
        public static Color color = Color.DarkViolet; //default
        public static Color theme = Color.White;
        public static Color fortheme = Color.Black;
        public static bool Connected = false;
        public static int opaque = 100;
        public static Main form = null;
        public static int fit = 3; ///fill
        public static Image image;
        public static int screenWidth = 0;
        public static int screenHeight = 0;

        public static String[] resolutions = null;

        public static string ToString(this int fit)
        {
            switch (fit)
            {
                case 0: return "Fill";
                case 1: return "Tile";
                case 2: return "Center";
                case 3: return "Stretch";
                case 4: return "Zoom";
                default: return null;
            }
        }

        public static int ToFit(this string FitString)
        {
            switch (FitString)
            {
                case "Stretch":
                     return (int)ImageLayout.Stretch;
                case "Center":
                     return (int)ImageLayout.Center;
                case "Tile":
                     return (int)ImageLayout.Tile;
                case "Fill":
                     return (int)ImageLayout.None;
                case "Fit":
                     return (int)ImageLayout.Zoom;
                 default:
                     return -1;
            }
        }
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
  

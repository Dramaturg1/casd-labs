namespace sorting
{
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void ShakerSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
                swapped = false;
                end = end - 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                start = start + 1;
            }
        }

        public static void CombSort(int[] array)
        {
            int length = array.Length;
            int gap = length;
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);
                swapped = false;
                for (int i = 0; i < length - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
        }

        static int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
            {
                return 1;
            }
            return gap;
        }

        public static void IncertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}

using System;

using NET.W._2018.Zenovich._01.API;

namespace NET.W._2018.Zenovich._01.Model
{
    public class ArrayUtils : IArrayUtils
    {
        #region Utils
        public void Swap<T>(T[] array, int left, int right)
        {
            if (left != right)
            {
                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }

        private bool IsGreatThan<T>(T left, T right)
            where T : IComparable<T>
        {
            return left.CompareTo(right) > 0;
        }

        private bool IsLessThan<T>(T left, T right)
            where T : IComparable<T>
        {
            return left.CompareTo(right) < 0;
        }
        #endregion

        #region MergeSort
        public void MergeSort<T>(T[] array) 
            where T : IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            
            if (array.Length == 0)
            {
                return;
            }

            SortMerge(array, 0, array.Length - 1);
        }

        private void MainMerge<T>(T[] numbers, int left, int mid, int right) 
            where T : IComparable<T>
        {
            T[] temp = new T[numbers.Length];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (IsLessThan(numbers[left], numbers[mid]))
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        private void SortMerge<T>(T[] numbers, int left, int right) 
            where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
        #endregion

        #region QuickSort
        public void QuickSort<T>(T[] array) 
            where T : IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                return;
            }

            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort<T>(T[] array, int left, int right)
            where T : IComparable<T>
        {
            int i = left, j = right;
            T pivot = array[(left + right) >> 1];

            while (i <= j)
            {
                while (IsLessThan(array[i],pivot))
                {
                    i++;
                }

                while (IsGreatThan(array[j],pivot))
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(array, i, j);

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(array, left, j);
            }

            if (i < right)
            {
                QuickSort(array, i, right);
            }
        }
        #endregion
    }
}

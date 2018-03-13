using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._01.API
{
    public interface IArrayUtils
    {
        void QuickSort<T>(T[] array)
            where T: IComparable;
        void MergerSort<T>(T[] array)
            where T: IComparable;
    }
}

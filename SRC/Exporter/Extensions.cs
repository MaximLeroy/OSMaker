using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exporter
{
    static class Extensions
    {
        public static T[] SubArray<T>(this T[] data, int from, int to)
        {
            T[] result = new T[to - from];
            Array.Copy(data, from, result, 0, result.Length);
            return result;
        }
    }
}

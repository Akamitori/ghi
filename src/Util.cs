namespace Ghi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Xml;
    using System.Xml.Linq;

    internal static class Util
    {
        internal static int FirstIndexOf<T>(this IEnumerable<T> enumerable, Func<T, bool> func)
        {
            int index = 0;
            var enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (func(enumerator.Current))
                {
                    return index;
                }

                ++index;
            }

            return -1;
        }
    }
}

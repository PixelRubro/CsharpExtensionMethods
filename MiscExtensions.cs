using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YoukaiFox.CsharpExtensions
{
    public static class MiscExtensions
    {
        /// <summary>
        /// Swap the two values provided.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <typeparam name="T"></typeparam>
        public static void Swap<T>(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}

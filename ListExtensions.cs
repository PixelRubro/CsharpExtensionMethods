using System.Collections.Generic;

namespace YoukaiFox.CsharpExtensions
{
    public static class ListExtensions 
    {
        /// <summary>
        /// Add multiple items to a list at once.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="elements"></param>
        /// <typeparam name="T"></typeparam>
        public static void AddMultiple<T>(this List<T> list, params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(elements[i]);
            }
        }

        /// <summary>
        /// Returns a string with all the list data.
        /// </summary>
        /// <param name="self"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ToString<T>(this List<T> self)
        {
            System.Text.StringBuilder listContent = new System.Text.StringBuilder();

            foreach (T item in self)
            {
                listContent.Append($"{item},\n");
            }

            listContent.Append($"List items count: {self.Count}.\n");
            return listContent.ToString();
        }
    }
}


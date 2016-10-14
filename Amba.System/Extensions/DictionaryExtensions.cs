using System.Collections.Generic;

namespace Amba.System.Extensions
{
    public static class DictionaryExtensions
    {
        public static IDictionary<K, V> Clone<K, V>(this IDictionary<K, V> dictionary)
        {
            var result = new Dictionary<K, V>();
            foreach (var pair in dictionary)
            {
                result.Add(pair.Key, pair.Value);
            }
            return result;
        }

        public static IDictionary<K, V> Set<K, V>(this IDictionary<K, V> dictionary, K key, V value)
        {
            dictionary[key] = value;
            return dictionary;
        }

    }
}

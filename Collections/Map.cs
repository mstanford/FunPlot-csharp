// ------------------------------------------------------------------------
// 
// This is free and unencumbered software released into the public domain.
// 
// Anyone is free to copy, modify, publish, use, compile, sell, or
// distribute this software, either in source code form or as a compiled
// binary, for any purpose, commercial or non-commercial, and by any
// means.
// 
// In jurisdictions that recognize copyright laws, the author or authors
// of this software dedicate any and all copyright interest in the
// software to the public domain. We make this dedication for the benefit
// of the public at large and to the detriment of our heirs and
// successors. We intend this dedication to be an overt act of
// relinquishment in perpetuity of all present and future rights to this
// software under copyright law.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org/>
// 
// ------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunPlot.Collections
{
    public class Map<T, U>
    {
        private readonly Dictionary<T, U> _dictionary;

        public Map() { _dictionary = new Dictionary<T, U>(); }
        public Map(Map<T, U> map) { _dictionary = new Dictionary<T, U>(map._dictionary); }
        public Map(Map<T, U> map, T t, U u) { _dictionary = new Dictionary<T, U>(map._dictionary); _dictionary.Add(t, u); }
        public Map(Map<T, U> map, Map<T, U> map2) { _dictionary = new Dictionary<T, U>(map._dictionary); foreach (KeyValuePair<T, U> kvp in map2._dictionary) _dictionary[kvp.Key] = kvp.Value; }
        public Map(Dictionary<T, U> dictionary) { _dictionary = dictionary; }

        public U this[T key]
        {
            get
            {
                if (!_dictionary.ContainsKey(key))
                    throw new System.Exception("UNKNOWN KEY: " + key);
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }

        public bool ContainsKey(T key) { return _dictionary.ContainsKey(key); }

        public string[] Split(T a, T b)
        {
            //string[] columns = new string[primaryColumns.Length + secondaryColumns.Length];
            //System.Array.Copy(primaryColumns, 0, columns, 0, primaryColumns.Length);
            //System.Array.Copy(secondaryColumns, 0, columns, primaryColumns.Length, secondaryColumns.Length);

            List<string> values = new List<string>(Split(a));
            values.AddRange(Split(b));
            return values.ToArray();
        }

        public string[] Split(T key)
        {
            if (!ContainsKey(key))
                return new string[0];

            U u = this[key];

            if (u is string)
            {
                string s = u as string;
                if (s.Contains(";") || s.Contains(", "))
                    return s.Split(';');
                return s.Split(',');
            }

            throw new System.Exception();
        }
    }
}

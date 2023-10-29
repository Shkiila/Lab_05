using System.Drawing;

namespace part_02
{
    class Programm
    {
        static void Main()
        {

        }
    }
    public class MyDictionary<TKey, TValue> //: IEnumerable<T>
    {
        private TKey[]? _key;
        private TValue[]? _value;
        //private Entry<TKey, TValue>[]? _dictionary;
        private int _count;
        public int Count { get { return _count; } }
        MyDictionary() { _count = 0; _key = null; _value = null; }
        MyDictionary(int size) { _count = size; _key = new TKey[size]; _value = new TValue[size]; }
        MyDictionary(MyDictionary<TKey,TValue> list) { _count = list.Count; _key = list._key; _value = list._value; }
        public TKey? key(int index)
        {
            return _key[index];
        }
        public TValue this[TKey key]
        {
            get
            {
                return this[key];
            }
            set
            {
                this[key] = value;
            }
        }
        public void Add(TKey key, TValue value) 
        { 
            for (int i = 0; i < _key.Length; i++)
            {
                if (Equals(key, _key[i])) { throw new ArgumentException("This key is already use"); }
            }
            MyDictionary<TKey, TValue> tmp = new MyDictionary<TKey, TValue>(_count + 1);
            for (int i = 0; i < _count; i++)
            {
                tmp._key[i] = _key[i];
                tmp._value[i] = _value[i];
            }
            tmp._key[_count] = _key[_count];
            tmp._value[_count] = _value[_count];
            _count++;
        }
        //public IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return (IEnumerator)this;
        //}
    }
}
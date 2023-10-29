namespace part_02
{
    class Programm
    {
        static void Main()
        {
            int[] list = { 1, 2, 3, 4, 5, };
            MyList<int> list2 = new MyList<int>(list);
            Console.WriteLine(list2.Count);
            for (int i = 0; i < list2.Count; i++) { Console.Write(list2[i].ToString().PadRight(3)); }
            Console.WriteLine();

            list2.Add(6);
            Console.WriteLine(list2.Count);
            for (int i = 0; i < list2.Count; i++) { Console.Write(list2[i].ToString().PadRight(3)); }
            Console.WriteLine();
        }
    }
    public class MyList<T>
    {
        T[]? list;
        private int _count;
        public int Count { get { return _count; } }
        public MyList() { _count = 0; list = null; }
        public MyList(T[]? list) { _count = list.Length; this.list = list; }
        public T this[int index] 
        {
            get
            {
                return list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }
        public void Add(T item)
        {
            _count++;
            T[] tmp = new T[list.Length + 1]; 
            for (int i = 0; i < list.Length; i++) { tmp[i] = list[i]; }
            tmp[list.Length] = item;
            this.list = tmp;
        }
        public void Clear() { _count= 0; list = null; }
    }
}
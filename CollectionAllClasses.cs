using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    public class CollectionAllClasses
    {
        public static void ArrayList()
        {
            ArrayList al = new ArrayList();//Non Generic
           // List<int> al = new List<int>();

            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);
            al.Add("Pritam");

            Console.WriteLine("ArrayList Elements");

            IEnumerator ie = al.GetEnumerator();//the way of print in iterative
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
        } 
        public static void HashtableMethod()
        {
            Hashtable ht = new Hashtable();//NonGeneric
            ht.Add(10,"Pritam");
            ht.Add(20,"Amar");
            ht.Add(30,"Ajay");
            ht.Add(40,"Abhi");
            ht.Add(50,"sachin");
            ht.Add(60, "shubham");
            Console.WriteLine("Hashtable elements");

            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }
           
        }


        public static void  Queuemethod()//Non Generic 
        {

            Queue names = new Queue();
            names.Enqueue("Sunil");
            names.Enqueue("Priya");
            names.Enqueue("Jay");
            names.Enqueue("Ram");
            names.Enqueue("Amar");
            names.Enqueue(10);
            names.Dequeue();
            names.Peek();

            Console.WriteLine("Queue elements");

            IEnumerator ie = names.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            Stack s = new Stack();//Non Generic
            s.Push("Pritam");
            s.Push("shubham");
            //s.Pop();
            s.Peek();
            
            
            Console.WriteLine("Stack elements");

            foreach (string s1 in s)
            {
                Console.WriteLine(s1);
            }

        } 
        public static void Hashsetmethod()
        {
            HashSet<int> hs = new HashSet<int>();//No duplicates
            hs.Add(10);
            hs.Add(10);
            hs.Add(20);
            hs.Add(10);
            hs.Add(20);
            hs.Add(40);
            Console.WriteLine("Hashset elements");
            foreach(int d in hs)
            {
                Console.WriteLine(d);
            }

        }
        public static void Dictonarymethod()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();//Generic
            d.Add(1, "pritam");
            d.Add(2, "pritesh");
            d.Add(3, "Priya");
            d.Add(4, "pranav");
            Console.WriteLine("Dictonary elements");
            // get keys
            /*var val = d.Keys.ToList();
            // sort
            val.Sort();
            // displaying sorted key
            foreach (var key in val)
            {
                Console.WriteLine(key );
            }*/
            foreach(KeyValuePair<int,string> pair in d)
            {
                Console.WriteLine("KEY: " + pair.Key);
                Console.WriteLine("VALUE: " + pair.Value);
            }

        }
        public  static void ShortedSetMethod()
        {
           var ss = new SortedSet<string>();
            ss.Add("Pritam");
            ss.Add("Amar");
            ss.Add("Abhi");
            ss.Add("Yogesh");

            Console.WriteLine("shortedset elements");
            foreach(var val in ss)
            {
                Console.WriteLine(val);
            }

        }
        public static void LinkedListMethod()
        {
            var ss = new LinkedList<string>();
            ss.AddLast("Pritam");
            ss.AddLast("Amar");
            ss.AddLast("Abhi");
            ss.AddLast("Yogesh");

            Console.WriteLine("LinkedList elements");
            foreach (var val in ss)
            {
                Console.WriteLine(val);
            }

        }
        public static void BitMethod()
        {
            BitArray b = new BitArray(2);
            b.Set(1, true);
            b.Set(2, false);

        }


        static void Main(string[] args)
        {
            ArrayList();
            HashtableMethod();
            Queuemethod();
            Hashsetmethod();
            Dictonarymethod();
            ShortedSetMethod();
            LinkedListMethod();


        }
    }
}

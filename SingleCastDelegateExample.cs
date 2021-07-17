using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInCSharp.DelegetsEx
{
    class SingleCastDelegateExample
    {
        public delegate void Del(int a, int b);
        static void Main(string[] ar)
        {
          /*  delegate d =  new delegate ();
            SingleCastTestDelegate singleCastTestDelegate = new SingleCastTestDelegate(d.add);
            singleCastTestDelegate(50, 100);*/

        }

    }
    class SingleCastTestDelegate
    {
         public void add(int a, int b)
         {
        Console.WriteLine(a + b);
        }
    }
}

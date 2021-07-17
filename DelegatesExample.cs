using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInCSharp.DelegetsEx
{
    public delegate void calDelegate(int num1, int num2);// this is delegate declaration
        
  public  class DelegatesExample
    {
        static void Main(string []ar)
        {
            DelgateTest delgateTest = new DelgateTest();

            calDelegate calAdd = new calDelegate(delgateTest.Add);
            calDelegate calSub = delgateTest.Sub;
            calDelegate calMul = delgateTest.Mul;
            calDelegate calDiv = delgateTest.Div;

            calDelegate calDelegate = calAdd + calSub + calMul + calDiv;
            calDelegate.Invoke(10, 20);
        }
        
    }
   public class DelgateTest
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x /y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    using System;
    using System.Collections.Generic;
    namespace Collection
    {
        class SortList
        {
            static void Main(string[] args)
            {
                SortedList<string, string> sl = new SortedList<string, string>();
                sl.Add("ora", "oracle");
                sl.Add("vb", "vb.net");
                sl.Add("cs", "cs.net");
                sl.Add("asp", "asp.net");

                foreach (KeyValuePair<string, string> kvp in sl)



                {

                    if (kvp.Key.Equals("aso"))
                    {
                        sl.Add("asp", kvp.Value + " core");
                        Console.Write(kvp.Key + " " + kvp.Value);
                        Console.Write("<br>");
                    }




                }
            }
        }
    }

}

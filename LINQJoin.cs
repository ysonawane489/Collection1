using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class LINQJoin
    {
        public static void Main(string[] args)
        {
			IList<string> strList1 = new List<string>() {
			"Sunday",
			"Monday",
			"Tuesday",
			"Thursday"
			};

			IList<string> strList2 = new List<string>() {
			"Jan",
			"Feb",
			"March",
			"Oct"
			};

			var innerJoinResult = strList1.Join(// outer sequence 
						  strList2,  // inner sequence 
						  str1 => str1,    // outerKeySelector
						  str2 => str2,  // innerKeySelector
						  (str1, str2) => str1);

			foreach (var str in innerJoinResult)
			{
				Console.WriteLine("{0} ", str);
			}

		}
	}
}

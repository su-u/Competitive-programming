using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC001D {
    class Program {
        static void Main(String[] args) {
            var n = Int32.Parse(Console.ReadLine());
            Int32[] start_time = new Int32[n];
            Int32[] end_time = new Int32[n];

            for(int i = 0;i < n; i++) {
                var s = Console.ReadLine().Split('-');
                start_time[i] = Int32.Parse(s[0]);
                end_time[i] = Int32.Parse(s[1]);
            }


            



        }
    }
}

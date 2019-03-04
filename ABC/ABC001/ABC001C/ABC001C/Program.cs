using System;

namespace ABC001C {
    class Program {
        static void Main(string[] args) {
            Program.Main1();
        }


        static void Main1() {
            var s = Console.ReadLine();
            var ss = s.Split(' ');
            var deg = int.Parse(ss[0]);
            var degs = string.Empty;

            var b = ((deg * 10 + 1125) / 2250) % 16;

            string[] a = { "N", "NNE", "NE", "EME", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WMW", "NW", "NNW" };

            degs = a[b];

            var dis = double.Parse(ss[1]);
            //Console.WriteLine(dis);
            var diss = 0;
            if(dis <= 12) {
                diss = 0;
                degs = "C";
            }else if(dis <= 90) {
                diss = 1;
            }else if(dis <= 198) {
                diss = 2;
            }else if(dis <= 324) {
                diss = 3;
            }else if(dis <= 474) {
                diss = 4;
            }else if(dis <= 642) {
                diss = 5;
            }else if(dis <= 828) {
                diss = 6;
            }else if(dis <= 1026) {
                diss = 7;
            }else if(dis <= 1242) {
                diss = 8;
            }else if(dis <= 1452) {
                diss = 9;
            }else if(dis <= 1704) {
                diss = 10;
            }else if(dis <= 1956) {
                diss = 11;
            } else {
                diss = 12;
            }
            dis = Math.Round(dis / 60.0, 1, MidpointRounding.AwayFromZero);
            //Console.WriteLine(dis);

            Console.WriteLine($"{degs} {diss}");
        }
    }
}

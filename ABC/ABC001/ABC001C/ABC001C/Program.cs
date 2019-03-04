using System;

namespace ABC001C {
    class Program {
        static void Main(string[] args) {
            //Program.Main1();
            for(int i = 0;i < 3600; i += 10) {
                Console.WriteLine($"{i}:{((i * 10 + 1125 / 2250) % 16)}");
            }
        }


        static void Main1() { 
            var s = Console.ReadLine();
            var ss = s.Split(' ');
            var deg = int.Parse(ss[0]);
            var degs = string.Empty;

            var b = ((deg * 10 + 1125 / 2250) % 16);

            string[] a = { "N", "NNE", "NE", "EME", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WMW", "NW", "NNW" };

            degs = a[b];

            var dis = double.Parse(ss[1]) / 60.0;
            Console.WriteLine(dis);
            dis = Math.Round(dis, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine(dis);
            var diss = 0;
            if(dis <= 0.2) {
                diss = 0;
                degs = "C";
            }else if(dis <= 1.5) {
                diss = 1;
            }else if(dis <= 3.3) {
                diss = 2;
            }else if(dis <= 5.4) {
                diss = 3;
            }else if(dis <= 7.9) {
                diss = 4;
            }else if(dis <= 10.7) {
                diss = 5;
            }else if(dis <= 13.8) {
                diss = 6;
            }else if(dis <= 17.1) {
                diss = 7;
            }else if(dis <= 20.7) {
                diss = 8;
            }else if(dis <= 24.4) {
                diss = 9;
            }else if(dis <= 28.4) {
                diss = 10;
            }else if(dis <= 32.6) {
                diss = 11;
            } else {
                diss = 12;
            }


            Console.WriteLine($"{degs} {diss}");
        }
    }
}

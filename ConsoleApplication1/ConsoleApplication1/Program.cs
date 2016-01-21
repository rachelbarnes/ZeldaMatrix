using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class EntryPoint {
        static void Main(string[] args) {
            Console.Out.WriteLine("test");
            Console.Out.WriteLine(MathThings.Add(1, 3));
            Console.ReadLine();
            Console.ReadLine();
        }

    }
    class MathThings {
        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Div(int x, int y) {
            return x / y;
        }
        public static int Abs(int x) {
            return x;
        }

    }
}

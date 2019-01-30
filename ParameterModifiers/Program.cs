using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Foo f1 = new Foo { N = 1 };
            Console.WriteLine($"Pre: {f1}");
            TestInOnly(f1);
            Console.WriteLine($"Post: {f1}");

            Foo f2 = new Foo { N = 2 };
            Console.WriteLine($"Pre: {f2}");
            TestInOut(ref f2);
            Console.WriteLine($"Post: {f2}");

            Foo f3 = new Foo { N = 3 };
            Console.WriteLine($"Pre: {f3}");
            TestOutOnly(out f3);
            Console.WriteLine($"Post: {f3}");
        }

        public static void TestInOnly(Foo f)
        {
            f = new Foo { N = 100 };
        }
        public static void TestInOut(ref Foo f)
        {
            f = new Foo { N = 200 };
        }
        public static void TestOutOnly(out Foo f)
        {
            f = new Foo { N = 300 };
        }
    }
    
    public class Foo
    {
        public int N { get; set; }
        public override string ToString()
        {
            return N.ToString();
        }
    }
}

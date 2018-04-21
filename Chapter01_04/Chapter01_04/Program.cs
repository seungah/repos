using System;

namespace Chapter01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object c = 1234567890L;
            object w = "abcde";
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(w);

            Console.WriteLine(a.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(w.GetType());

            if(a.GetType() == System.Type.GetType("System.Int32"))
            {
                Console.WriteLine("a is Int32");
            }

            float d = 1.2345f;
            int e = (int)d;
            int f = 12345;
            float g = 3.1415f;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("{0:D8}", f);
            Console.WriteLine(f.ToString("D8"));
            Console.WriteLine(String.Format("{0:D8}", f));
            Console.WriteLine(g.ToString("F3"));

            string h = "123456";
            string m = "1,23456";
            int o = int.Parse(h);
            float p = float.Parse(m);
            Console.WriteLine(o);
            Console.WriteLine(p);

            const int s = 567;

            EFruit tmpEF = EFruit.EF_Banana;
            Console.WriteLine(tmpEF);
            if(tmpEF == EFruit.EF_Apple)
            {
                Console.WriteLine("Apple");
            }
            switch (tmpEF)
            {
                case EFruit.EF_Apple:
                    Console.WriteLine("EF_Apple");
                    break;
                case EFruit.EF_Banana:
                    Console.WriteLine("EF_Banana");
                    break;
                case EFruit.EF_Lemon:
                    Console.WriteLine("EF_Lemon");
                    break;
            }

            int? r = null; //?가 달린이유: null을 넣을 수가 있음.
            Console.WriteLine(r.HasValue);
            if (r.HasValue == true)
            {
                Console.WriteLine(r.Value);
            }

            r = 234;
            Console.WriteLine(r.HasValue);
            if(r.HasValue == true)
            {
                Console.WriteLine(r.Value);
            }

            int _a = 111;
            int _b = _a + 50;
            int _c = 5 * 7;
            int _d = 123 / 5;
            double _e = _d * 5.0;
            int _f = _a++;
            int _g = _f--;
            string _h = "123" + "456";
            string _j = (_c == 35) ? "AAA" : "BBB";
            int _k = 1 << 4;
            int _l = 1 << 3;
            int _m = (_k | _l);
            int _n = (_k | _l) & (1 << 3);
            _c *= 3;
        
            Console.WriteLine(_a);
            Console.WriteLine(_b);
            Console.WriteLine(_c);
            Console.WriteLine(_d);
            Console.WriteLine(_e);
            Console.WriteLine(_f);
            Console.WriteLine(_g);
            Console.WriteLine(_h);
            Console.WriteLine(_j);
            Console.WriteLine(_k);
            Console.WriteLine(_l);
            Console.WriteLine(_m.ToString("x8")); //16진수 &&:참, 거짓 &:진수
            Console.WriteLine(_n.ToString("X8"));




            Console.ReadKey();
        }

        enum EFruit
        {
            EF_Apple,
            EF_Banana,
            EF_Lemon,
            EF_Count
        }
    }
}

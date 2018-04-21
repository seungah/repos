using System;

namespace Chapter02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CMyClass tmpMC1 = new CMyClass();
            Console.WriteLine(tmpMC1.GetName());

            Console.WriteLine(new CMyClass(1).GetName());
            Console.WriteLine(new CMyClass(3, "AAA").GetName());
            

            int a = 5;
            int b = 5;

            tmpMC1.Increase(a); //참조
            tmpMC1.Increase(ref b); //주소 (바뀐값을 읽게 됨)

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c;
            tmpMC1.MakeValue(out c); //다른 클래스에서 바꿨는데 Main에서도 바뀌어있음.(교환할때 쓰임)
            Console.WriteLine(c); //return값을 넘기는 것처럼

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            long b = 12345678901L;//L은 리터럴

            Console.WriteLine("int : {0}", a);
            Console.WriteLine("int : {0:D8}", a); //D4: 자릿수 (D는 정수)
            Console.WriteLine("long : {0}", b);

            //Console.WriteLine("{0}", 1234567 = 1234567);
            Console.WriteLine("{0}", 1234567L * 1234567 );

            Console.WriteLine("------------------------------");

            float c = 1.23456789f;
            double d = 1.234567890123;

            Console.WriteLine("{0}", c); //반올림됨.
            Console.WriteLine("{0:F5}", c); //2자리수에서 반올림됨. 뒤에서 반올림해주므로 상관없음.
            Console.WriteLine("{0}", d);

            Console.WriteLine("------------------------------");

            char e = 'a';
            string f = "abcdefgh";
            string g = "가나다라마바";

            Console.WriteLine("char : {0}", e);
            Console.WriteLine("string : {0}", f);
            Console.WriteLine("string : {0}", g);

            Console.WriteLine("------------------------------");

            string h = "\nUnicode Test\n";
            string i = "\u2602\u2605\u2606";
            Console.WriteLine("{0}", h);
            Console.WriteLine("\t code: {0}", i);

            Console.Write("Input Name: ");
            string tmpName = Console.ReadLine();
            Console.WriteLine(" Your Name : {0}", tmpName);
            //Console.Write("Input Number : ");
            //string tmpNumber = Console.ReadLine();
            //int tmp = int.Parse(tmpNumber);
            ////string = System과 String은 같다.
            ////int == System.Int32
            //Console.WriteLine("100 + input : {0}", 100 + tmpNumber);

            Console.Write("\nInput Char: ");
            ConsoleKeyInfo tmpkey = Console.ReadKey();

            int i;
            for(i = 0; i<tmpName.Length; i++)
            {
                if(tmpName[i].Equals(tmpkey.keyChar)==true)
                {
                    break;
                }
            }
            if(i == tmpName.Length)
            {
                Console.WriteLine("\nChar:{0} Fail", tmpkeyChar);
            }
            else
            {
                Console.WriteLine("\nChar:{0} Success", tmpkey.KeyChar);
            }



        }
    }
}

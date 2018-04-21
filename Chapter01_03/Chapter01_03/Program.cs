using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.write("input name: ");
            //string tmpname = console.readline();
            //console.writeline(" your name : {0}", tmpname);
            //console.write("input number : ");
            //string tmpnumber = console.readline();
            //int tmp = int.parse(tmpnumber);
            //string = system과 string은 같다.
            //int == system.int32
            //console.writeline("100 + input : {0}", 100 + tmpnumber);

            //console.write("\ninput char: ");
            //consolekeyinfo tmpkey = console.readkey();


            //int i;
            //for (i = 0; i < tmpname.length; i++)
            //{
            //    if (tmpname[i].equals(tmpkey.keychar) == true)
            //    {
            //        break;
            //    }
            //}
            //if (i == tmpname.length)
            //{
            //    console.writeline("\nchar:{0} fail", tmpkey.keychar);
            //}
            //else
            //{
            //    console.writeline("\nchar:{0} success", tmpkey.keychar);
            //}

            string strSW = "banana";
            switch (strSW)
            {
                case "apple":
                    Console.WriteLine("apple, apple");
                    break;
                case "banana":
                    Console.WriteLine("banana, banana");
                    break;
                default:
                    Console.WriteLine("Fruits");
                    break;
            }
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            foreach(int iter in arr)
            {
                Console.Write("{0} ", iter);

            }
            Console.WriteLine();

            Console.ReadKey();
            
        }
    }
}

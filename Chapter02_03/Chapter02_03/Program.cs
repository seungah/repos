using System;

namespace Chapter02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CPartialClass tmpPC = new CPartialClass();
            Console.WriteLine(tmpPC.theModule1);
            Console.WriteLine(tmpPC.theModule2);
            Console.WriteLine(tmpPC.FunctionA());
            Console.WriteLine(tmpPC.FunctionB());

            CVector2 tmpV2 = new CVector2();
            tmpV2.x = 3;
            Console.WriteLine(tmpV2.x);

            tmpV2.y = 7;
            Console.WriteLine(tmpV2.y);
            Console.WriteLine(tmpV2.theY);

            var tmpStudent = new { Number = 1, Name = "Mirim" };
            Console.WriteLine(tmpStudent.Number);
            Console.WriteLine(tmpStudent.Name);

        }
    }
    partial class CPartialClass
    {
        public int theModule2;
       
        public CPartialClass()
        {
            theModule1 = 3;
            theModule2 = 5;
        }
        public int FunctionB()
        {
            return 2;
        }
    }
}

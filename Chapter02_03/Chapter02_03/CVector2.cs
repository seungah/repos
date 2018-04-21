using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter02_03
{
    class CVector2
    {
        private int theX;
        public int theY;
        public CVector2()
        {
            theX = 0;
            theY = 0;
        }
        public int x
        {
            get
            {
                Console.WriteLine("GetX");
                return theX;

            }
            set
            {
                Console.WriteLine("SetX");
                theX = value;

            }
        }

        public int y
        {
            get;
            set;  

        
        }

    }
}

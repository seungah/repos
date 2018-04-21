using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter02_02
{
    class CSamsungPhone : CSmartPhone
    {
        public CSamsungPhone()
        {
             
        }
        public override string GetMarket()
        {
            string parentMarket = base.GetMarket();
            return (parentMarket + ", Samsung");
        }
        public int GetButtinCount()
        {
            return 3;
        }
    }
}

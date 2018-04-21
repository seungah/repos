using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter02_02
{
    class CLGPhone : CSmartPhone
    {
        public CLGPhone()
        {
        }
        public override string GetMarket()
        {
            string parentMarket = base.GetMarket();
            return (parentMarket + ", U+ Market");
        }
        public int GetButtinCount()
        {
            return 2;
        }
    }
}

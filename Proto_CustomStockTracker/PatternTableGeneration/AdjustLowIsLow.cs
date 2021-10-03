using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto_CustomStockTracker
{
    public class AdjustLowIsLow
    {
        public void KeepLowLower(NumericUpDown low, NumericUpDown high)
        {
            decimal lowNum = low.Value;
            decimal highNum = high.Value;
            if(lowNum >= highNum)
            {
                high.Value = lowNum + 1;
            }
        }
    }
}

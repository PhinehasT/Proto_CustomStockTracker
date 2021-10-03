using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class ToggleAutoScroll
    {
        public void ScrollingOn(TabPage tabPage)
        {
            tabPage.AutoScroll = true;
        }

        public void ScrollingOff(TabPage tabPage)
        {
            tabPage.AutoScroll = false;
        }
    }
}

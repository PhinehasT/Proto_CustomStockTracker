using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto_CustomStockTracker
{
    public class ClearWithTimer
    {
        Timer timer = new Timer();
        Label labelToEmpty;

        public void ClearLabelText(Label label)
        {
            if (timer.Interval >= 0)
            {
                labelToEmpty = label;
                timer.Interval = (7000);
                timer.Tick += new EventHandler(EmptyLabel);
                timer.Start();
            }
        }

        private void EmptyLabel(object sender, EventArgs e)
        {
            labelToEmpty.Text = "";
        }
    }
}

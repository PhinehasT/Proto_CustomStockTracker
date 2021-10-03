using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto_CustomStockTracker
{
    public class StandardMessages
    {       

        public void EmptyLabelMSG(Label empty)
        {
            empty.Text = "";
        }

        public void MaxDaysLabelMSG(Label maxDays)
        {
            maxDays.Text = "Length of Pattern can not exceed 31 days.";
        }

        public void MinDaysLabelMSG(Label minDays)
        {
            minDays.Text = "Length of Pattern must be 5 or greater.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto_CustomStockTracker
{
    public class EnableAndDisable
    {
        public void EnableObject(Button button)
        {
            button.Enabled = true;
        }

        public void EnableObject(Label label)
        {
            label.Enabled = true;
        }

        public void EnableObject(TableLayoutPanel table)
        {
            table.Enabled = true;
        }

        public void DisableObject(Button button)
        {
            button.Enabled = false;
        }

        public void DisableObject(Label label)
        {
            label.Enabled = false;
        }

        public void DisableObject(TableLayoutPanel table)
        {
            table.Enabled = false;
        }
    }
}

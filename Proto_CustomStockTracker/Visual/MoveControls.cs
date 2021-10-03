using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class MoveControls
    {
        public void MoveObject(TableLayoutPanel table, int xPos, int yPos)
        {
            table.SuspendLayout();
            table.Location = new Point(xPos, yPos);
            table.ResumeLayout();
        }

        public void MoveObject(Button button, int xPos, int yPos)
        {
            button.Location = new Point(xPos, yPos);
        }

        public void MoveObject(Label label, int xPos, int yPos)
        {
            label.Location = new Point(xPos, yPos);
        }
    }
}

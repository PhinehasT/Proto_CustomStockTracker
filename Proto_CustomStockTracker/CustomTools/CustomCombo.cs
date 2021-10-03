using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class CustomCombo
    {
        public ComboBox NewCustomComboBox()
        {
            ComboBox custom = new ComboBox()
            {
                AutoSize = true,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Verdana", 16, FontStyle.Regular),
                BackColor = Color.FromArgb(33, 33, 33),
                ForeColor = Color.FromArgb(209, 209, 209),
                Anchor = AnchorStyles.None
            };

            custom.Items.Add("Increase");
            custom.Items.Add("Decrease");

            return custom;
        }

    }
}

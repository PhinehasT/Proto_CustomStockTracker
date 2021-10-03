using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class VisualOnStart
    {
        EnableAndDisable enableAndDisable = new EnableAndDisable();
        ShowHideObjects showHideObjects = new ShowHideObjects();

        public void AdjustCountLabel(Label charCountLabel)
        {
            charCountLabel.ForeColor = Color.Aqua;
            charCountLabel.Text = "Pattern Name Must be 100 Characters or Less";
        }

        public void AdjustPatternLengthTB(TextBox pattLenghtTB, int days)
        {         
            pattLenghtTB.Text = $"{days}";
        }

        public void AdjustPatternGenButton(Button genPatternBT, int days)
        {
            genPatternBT.Text = $"Generate Pattern Table\n({days} Day Pattern)";
        }

        public void AdjustAdjustmentTable(TableLayoutPanel table, 
            ComboBox comboBox, NumericUpDown numericUpDown)
        {
            comboBox.SelectedIndex = 0;
            numericUpDown.Value = 5;
            enableAndDisable.DisableObject(table);
            showHideObjects.HideObject(table);
        }
    }
}

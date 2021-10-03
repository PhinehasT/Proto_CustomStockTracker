using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class AdjustTable
    {
        List<ComboBox> comboBoxes;
        List<NumericUpDown> lowNums;
        List<NumericUpDown> highNums;

        public void SetComboList(List<ComboBox> combos)
        {
            comboBoxes = combos;
        }

        public void SetLowNums(List<NumericUpDown> lowNumsList)
        {
            lowNums = lowNumsList;
        }

        public void SetHighNums(List<NumericUpDown> highNumsList)
        {
            highNums = highNumsList;
        }

        public void AdjustCombos(ComboBox comboBox)
        {
            int selected = comboBox.SelectedIndex;

            foreach(ComboBox combo in comboBoxes)
            {
                combo.SelectedIndex = selected;
            }
        }

        public void AdjustLowNums(NumericUpDown numericUpDown)
        {
            foreach(NumericUpDown numba in lowNums)
            {
                numba.Value = numericUpDown.Value;
            }    
        }

        public void AdjustHighNums(NumericUpDown numericUpDown)
        {
            foreach(NumericUpDown numba in highNums)
            {
                numba.Value = numericUpDown.Value;
            }
        }       
    }
}

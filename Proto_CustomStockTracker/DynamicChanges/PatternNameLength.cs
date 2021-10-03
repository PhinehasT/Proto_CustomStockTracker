using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class PatternNameLength
    {
        public void CountNameLength(TextBox pattNameTB, 
            Label charCountLabel, Button genPatternBT, 
            Button saveButton, bool patternExists)
        {
            EnableAndDisable enableAndDisable = new EnableAndDisable();

            int charCount = pattNameTB.Text.Length;
            if (charCount == 0)
            {
                charCountLabel.Text = "Pattern Name Must be 100 Characters or Less";
                enableAndDisable.DisableObject(genPatternBT);
                enableAndDisable.DisableObject(saveButton);
            }
            else
            {
                charCountLabel.Text = $"Pattern Name Must be 100 Characters or Less -  {charCount}";
                enableAndDisable.EnableObject(genPatternBT);
                if(patternExists)
                {
                    enableAndDisable.EnableObject(saveButton);
                }
            }

            if (charCount == 100)
            {
                charCountLabel.ForeColor = Color.Red;
            }
            else
            {
                charCountLabel.ForeColor = Color.Aqua;
            }
        }
    }
}

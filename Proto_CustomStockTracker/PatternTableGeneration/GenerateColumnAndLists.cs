using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class GenerateColumnAndLists
    {              
        List<int> DayNumList = new List<int>();
        List<ComboBox> IncOrDecList = new List<ComboBox>();
        List<NumericUpDown> LowNumList = new List<NumericUpDown>();
        List<NumericUpDown> HighNumList = new List<NumericUpDown>();

        GenerateProgress generateProgress = new GenerateProgress();
        ProgressBar theProgressBar;

        public void CreateDayNumColum(TableLayoutPanel table, int lenghtInDays, ProgressBar progressBar)
        {
            theProgressBar = progressBar;
            ClearAllLists();

            int column = 0;
            int row = 2;
            int dayNum = 1;

            for(int x = lenghtInDays; x > 0; x--)
            {
                Label theDay = new Label
                {
                    AutoSize = true,
                    Font = new Font("Verdana", 16, FontStyle.Regular),
                    Anchor = AnchorStyles.Right,
                    Text = $"Day {dayNum}:"
                };
                if(dayNum < 10) { theDay.Text = $"Day 0{dayNum}:"; }
                DayNumList.Add(dayNum);
                table.Controls.Add(theDay, column, row);
                generateProgress.OneStep(theProgressBar);
                row++;
                dayNum++;
            }
        }

        public void CreateIncDecColumn(TableLayoutPanel table, int lenghtInDays, ProgressBar progressBar)
        {
            theProgressBar = progressBar;

            int column = 1;
            int row = 2;

            for (int x = lenghtInDays; x > 0; x--)
            {
                
                ComboBox incDec = new ComboBox()
                {
                    AutoSize = true,
                    Font = new Font("Verdana", 16, FontStyle.Regular),
                    BackColor = Color.FromArgb(33, 33, 33),
                    ForeColor = Color.FromArgb(209, 209, 209),
                    Anchor = AnchorStyles.None
                };
                incDec.FlatStyle = FlatStyle.Flat;
                incDec.Items.Add("Increase");
                incDec.Items.Add("Decrease");               
                IncOrDecList.Add(incDec);
                table.Controls.Add(incDec, column, row);
                generateProgress.OneStep(theProgressBar);
                row++;
            }            
        }

        public void CreateLowNumColumn(TableLayoutPanel table, int lenghtInDays, ProgressBar progressBar)
        {
            theProgressBar = progressBar;

            int column = 3;
            int row = 2;

            for (int x = lenghtInDays; x > 0; x--)
            {
                NumericUpDown lowNum = new NumericUpDown()
                {
                    Value = 0,
                    Maximum = 99,
                    Minimum = 0,
                    Size = new Size(61, 31),
                    BackColor = Color.FromArgb(33, 33, 33),
                    ForeColor = Color.FromArgb(209, 209, 209),
                    Anchor = AnchorStyles.None,
                };
                lowNum.Click += new EventHandler(MustBeLower_Click);                
                LowNumList.Add(lowNum);
                table.Controls.Add(lowNum, column, row);
                generateProgress.OneStep(theProgressBar);
                row++;               
            }
        }

        public void CreateHighNumColumn(TableLayoutPanel table, int lenghtInDays, ProgressBar progressBar)
        {
            theProgressBar = progressBar;

            int column = 5;
            int row = 2;

            for (int x = lenghtInDays; x > 0; x--)
            {
                NumericUpDown highNum = new NumericUpDown()
                {
                    Value = 10,
                    Maximum = 100,
                    Minimum = 1,
                    Size = new Size(61, 31),
                    BackColor = Color.FromArgb(33, 33, 33),
                    ForeColor = Color.FromArgb(209, 209, 209),
                    Anchor = AnchorStyles.None
                };
                highNum.Click += new EventHandler(MustBeHigher_Click);
                HighNumList.Add(highNum);
                table.Controls.Add(highNum, column, row);
                generateProgress.OneStep(theProgressBar);
                row++;
            }
        }

        public void GiveOutLists(AdjustTable adjustTable)
        {
            adjustTable.SetComboList(IncOrDecList);
            adjustTable.SetLowNums(LowNumList);
            adjustTable.SetHighNums(HighNumList);
        }

        public void SetSelectedAll()
        {
            foreach(ComboBox c in IncOrDecList)
            {
                c.SelectedIndex = 0;
            }
        }

        private void ClearAllLists()
        {
            DayNumList.Clear();
            IncOrDecList.Clear();
            LowNumList.Clear();
            HighNumList.Clear();
        }

        private void MustBeLower_Click(object sender, EventArgs e)
        {
            int index = LowNumList.IndexOf((NumericUpDown)sender);
            NumericUpDown theLow = LowNumList[index];
            NumericUpDown theHigh = HighNumList[index];

            AdjustLowIsLow lowIsLow = new AdjustLowIsLow();
            lowIsLow.KeepLowLower(theLow, theHigh);
        }

        private void MustBeHigher_Click(object sender, EventArgs e)
        {
            int index = HighNumList.IndexOf((NumericUpDown)sender);
            NumericUpDown theLow = LowNumList[index];
            NumericUpDown theHigh = HighNumList[index];

            AdjustLowIsLow lowIsLow = new AdjustLowIsLow();
            lowIsLow.KeepLowLower(theLow, theHigh);
        }
    }
}

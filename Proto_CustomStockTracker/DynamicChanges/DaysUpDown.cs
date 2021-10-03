using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto_CustomStockTracker
{
    public class DaysUpDown
    {
        int days;

        public void IncreaseDayCount(TextBox textBox, int dayCount, Label error)
        {
            dayCount = ConfirmMinMax(dayCount);

            days = dayCount;
            if(days == 31)
            {
                UpdateDayCount(textBox, days);

                StandardMessages standardMessages = new StandardMessages();
                standardMessages.MaxDaysLabelMSG(error);

                ClearWithTimer clearWithTimer = new ClearWithTimer();
                clearWithTimer.ClearLabelText(error);
            }
            else
            {
                days++;
                UpdateDayCount(textBox, days);
            }
        }

        public void DecreaseDayCount(TextBox textBox, int dayCount, Label error)
        {
            dayCount = ConfirmMinMax(dayCount);

            days = dayCount;
            if (days == 5)
            {
                UpdateDayCount(textBox, days);

                StandardMessages standardMessages = new StandardMessages();
                standardMessages.MinDaysLabelMSG(error);

                ClearWithTimer clearWithTimer = new ClearWithTimer();
                clearWithTimer.ClearLabelText(error);
            }
            else
            {
                days--;
                UpdateDayCount(textBox, days);
            }
        }

        private void UpdateDayCount(TextBox pattLengthTB, int days)
        {
            pattLengthTB.Text = $"{days}";
        }

        public void UpdateGenButton(Button genPatternBT)
        {
            genPatternBT.Text = $"Generate Pattern Table\n({days} Day Pattern)";
        }

        public int DayCount()
        {
            return days;
        }

        private int ConfirmMinMax(int dayCount)
        {
            if(dayCount > 31)
            {
                dayCount = 31;
                return dayCount;
            }

            if(dayCount < 5)
            {
                dayCount = 5;
                return dayCount;
            }

            return dayCount;
        }

    }
}

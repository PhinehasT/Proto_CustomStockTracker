using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class GenerateProgress
    {

        public void SetBarParams(ProgressBar tableGen, int days)
        {
            int max = days * 4 + 12;
            tableGen.Maximum = max;
            tableGen.Minimum = 0;
            tableGen.Step = 1;
            tableGen.Value = 0;
        }

        public void TakeTwelve(ProgressBar tableGen)
        {
            for (int y = 12; y > 0; y--)
            {
                OneStep(tableGen);
            }
        }

        public void OneStep(ProgressBar tableGen)
        {
            tableGen.PerformStep();
        }

    }
}

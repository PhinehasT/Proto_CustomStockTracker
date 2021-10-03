using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class GenerateTopRow
    {
        readonly GenerateProgress generateProgress = new GenerateProgress();

        public void CreateHeader(TableLayoutPanel table)
        {
            table.Controls.Clear();

            int column = 0;
            int row = 0;
            //  column, row
            Label dayOf = new Label
            {
                AutoSize = true,
                Font = new Font("Verdana", 20, FontStyle.Bold),
                Anchor = AnchorStyles.Left,
                Text = "Day in Pattern"
            };
            table.Controls.Add(dayOf, column, row);
            column++;

            Label incOrDec = new Label
            {
                AutoSize = true,
                Font = new Font("Verdana", 20, FontStyle.Bold),
                Anchor = AnchorStyles.Left,
                Text = "Increase/Decrease"
            };
            table.Controls.Add(incOrDec, column, row);
            column++;

            Label betweenHeader = new Label
            {
                AutoSize = true,
                Font = new Font("Verdana", 20, FontStyle.Bold),
                Anchor = AnchorStyles.None,
                Text = "between"
            };
            table.Controls.Add(betweenHeader, column, row);
            column++;

            Label lowPercHeader = new Label
            {
                AutoSize = true,
                Font = new Font("Verdana", 20, FontStyle.Bold),
                Anchor = AnchorStyles.None,
                Text = "X%"
            };
            table.Controls.Add(lowPercHeader, column, row);
            column++;

            Label andHeader = new Label
            {
                AutoSize = true,
                Font = new Font("Verdana", 20, FontStyle.Bold),
                Anchor = AnchorStyles.Left,
                Text = "and"
            };
            table.Controls.Add(andHeader, column, row);
            column++;

            Label highPercHeader = new Label
            {
                AutoSize = true,
                Font = new Font("Verdana", 20, FontStyle.Bold),
                Anchor = AnchorStyles.None,
                Text = "Y%"
            };
            table.Controls.Add(highPercHeader, column, row);

            // Row of empty labels to create space under header
            char space = '\u0020';
            column = 0;
            row = 1;

            for(int x = 6; x > 0; x--)
            {
                Label emptyLabel = new Label
                {
                    Font = new Font("Verdana", 16, FontStyle.Regular),
                    Anchor = AnchorStyles.None,
                    Text = $"{space}"
                };
                table.Controls.Add(emptyLabel, column, row);
                column++;
            }
        }

    }
}

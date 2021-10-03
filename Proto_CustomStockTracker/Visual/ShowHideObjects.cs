using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proto_CustomStockTracker
{
    public class ShowHideObjects
    {
        readonly ToggleAutoScroll toggleAutoScroll = new ToggleAutoScroll();
        readonly MoveControls moveControls = new MoveControls();
        readonly Timer timer = new Timer();
        ProgressBar aProgressBar;
        TableLayoutPanel aTable;
        TabPage aTabPage;

        // ProgBarTimer handles a specific need for the app. Below the
        // following 2 methods are the ShowHide Overloaded Methods

        public void ProgBarTimer(ProgressBar progressBar, int time,
            TableLayoutPanel table, TabPage tabPage)
        {
            aProgressBar = progressBar;
            aTable = table;
            aTabPage = tabPage;
            timer.Interval = time;
            timer.Tick += new EventHandler(ShowTheTable);
            timer.Start();
        }

        private void ShowTheTable(object sender, EventArgs e)
        {
            aProgressBar.Visible = false;
            // instead need to create some kind of mask that covers the
            // generating table. Moving it just mucks everything up!
        }

        // All other Methods are Overloads of ShowObject and 
        // HideObject. Currently hande: TableLayoutPanel, ProgressBar,
        // Button & Label

        public void ShowObject(TableLayoutPanel table)
        {
            table.Show();
        }

        public void ShowObject(ProgressBar progressBar)
        {
            progressBar.Show();
        }

        public void ShowObject(Button button)
        {
            button.Show();
        }

        public void ShowObject(Label label)
        {
            label.Show();
        }

        public void HideObject(TableLayoutPanel table)
        {
            table.Hide();
        }

        public void HideObject(ProgressBar progressBar)
        {
            progressBar.Hide();
        }

        public void HideObject(Button button)
        {
            button.Hide();
        }

        public void HideObject(Label label)
        {
            label.Hide();
        }
    }
}

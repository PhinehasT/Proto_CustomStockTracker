using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto_CustomStockTracker
{
    public partial class TrackerGUI : Form
    {
        readonly DaysUpDown daysUpDown = new DaysUpDown();
        readonly StandardMessages standardMessages = new StandardMessages();
        readonly GenerateColumnAndLists generateColumnAndLists = new GenerateColumnAndLists();
        readonly AdjustTable adjustTable = new AdjustTable();


        int lengthInDays; // Value initialized in GUIOnStartUp();

        bool patternExists; // Used to prevent save button if no
                            // pattern table has been generated.

        public TrackerGUI()
        {
            InitializeComponent();
            GUIOnStartUp();
        }

        // This method dynamically updates Character Count while the
        // user is typing.
        private void pattNameTB_TextChanged(object sender, EventArgs e)
        {
            PatternNameLength patternNameLength = new PatternNameLength();
            patternNameLength.CountNameLength(pattNameTB, charCountLabel, genPatternBT, svPatternBT, patternExists);
        }

        public void GUIOnStartUp()
        {
            lengthInDays = 31;
            patternExists = false;
            pattNameTB.MaxLength = 100;

            ShowHideObjects showHideObjects = new ShowHideObjects();
            EnableAndDisable enableAndDisable = new EnableAndDisable();
            VisualOnStart StartGUI = new VisualOnStart();

            enableAndDisable.DisableObject(genPatternBT);
            enableAndDisable.DisableObject(svPatternBT);          

            StartGUI.AdjustCountLabel(charCountLabel);
            StartGUI.AdjustPatternLengthTB(pattLenghtTB, lengthInDays);

            standardMessages.EmptyLabelMSG(lengthError);

            StartGUI.AdjustPatternGenButton(genPatternBT, lengthInDays);
            StartGUI.AdjustAdjustmentTable(adjustmentsTable, adjustCombo, adjustHighNum);

            showHideObjects.HideObject(genProgBar);
        }

        private void incButton_Click(object sender, EventArgs e)
        {
            daysUpDown.IncreaseDayCount(pattLenghtTB, lengthInDays, lengthError);
            daysUpDown.UpdateGenButton(genPatternBT);
            lengthInDays = daysUpDown.DayCount();
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            daysUpDown.DecreaseDayCount(pattLenghtTB, lengthInDays, lengthError);
            daysUpDown.UpdateGenButton(genPatternBT);
            lengthInDays = daysUpDown.DayCount();
        }

        private void genPatternBT_Click(object sender, EventArgs e)
        {

            ShowHideObjects showHideObjects = new ShowHideObjects();
            MoveControls moveControls = new MoveControls();
            ToggleAutoScroll toggleAutoScroll = new ToggleAutoScroll();
            EnableAndDisable enableAndDisable = new EnableAndDisable();
            showHideObjects.ShowObject(genProgBar);
            toggleAutoScroll.ScrollingOff(createNewTab);

            GenerateProgress generateProgress = new GenerateProgress();
            generateProgress.SetBarParams(genProgBar, lengthInDays);

            GenerateTopRow generateTopRow = new GenerateTopRow();
            generateTopRow.CreateHeader(newPattTB);
            generateProgress.TakeTwelve(genProgBar);

            
            generateColumnAndLists.CreateDayNumColum(newPattTB, lengthInDays, genProgBar);
            generateColumnAndLists.CreateIncDecColumn(newPattTB, lengthInDays, genProgBar);
            generateColumnAndLists.CreateLowNumColumn(newPattTB, lengthInDays, genProgBar);
            generateColumnAndLists.CreateHighNumColumn(newPattTB, lengthInDays, genProgBar);
            generateColumnAndLists.SetSelectedAll();
            generateColumnAndLists.GiveOutLists(adjustTable);

            showHideObjects.ProgBarTimer(genProgBar, 1750, newPattTB, createNewTab);
            patternExists = true;
            enableAndDisable.EnableObject(svPatternBT);
            enableAndDisable.EnableObject(adjustmentsTable);
            showHideObjects.ShowObject(adjustmentsTable);
            toggleAutoScroll.ScrollingOn(createNewTab);
        }

        private void adjustComboBT_Click(object sender, EventArgs e)
        {
            adjustTable.AdjustCombos(adjustCombo);
        }

        private void adjustLowNumBT_Click(object sender, EventArgs e)
        {
            adjustTable.AdjustLowNums(adjustLowNum);
        }

        private void adjustHighNumBT_Click(object sender, EventArgs e)
        {
            adjustTable.AdjustHighNums(adjustHighNum);
        }

        private void LowAlwaysLow_Click(object sender, EventArgs e)
        {
            AdjustLowIsLow lowIsLow = new AdjustLowIsLow();
            lowIsLow.KeepLowLower(adjustLowNum, adjustHighNum);
        }

    }
}


namespace Proto_CustomStockTracker
{
    partial class TrackerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerGUI));
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.trackStocksTab = new System.Windows.Forms.TabPage();
            this.createNewTab = new System.Windows.Forms.TabPage();
            this.adjustmentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.adjustComboBT = new System.Windows.Forms.Button();
            this.adjustHighNum = new System.Windows.Forms.NumericUpDown();
            this.adjustCombo = new System.Windows.Forms.ComboBox();
            this.adjustHighNumBT = new System.Windows.Forms.Button();
            this.adjustLowNumBT = new System.Windows.Forms.Button();
            this.adjustLowNum = new System.Windows.Forms.NumericUpDown();
            this.genProgBar = new System.Windows.Forms.ProgressBar();
            this.newPattTB = new System.Windows.Forms.TableLayoutPanel();
            this.genSaveTable = new System.Windows.Forms.TableLayoutPanel();
            this.genPatternBT = new System.Windows.Forms.Button();
            this.svPatternBT = new System.Windows.Forms.Button();
            this.lengthError = new System.Windows.Forms.Label();
            this.decButton = new System.Windows.Forms.Button();
            this.incButton = new System.Windows.Forms.Button();
            this.pattLenghtTB = new System.Windows.Forms.TextBox();
            this.inDaysLabel = new System.Windows.Forms.Label();
            this.lenghtPattLabel = new System.Windows.Forms.Label();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.pattNameTB = new System.Windows.Forms.TextBox();
            this.namePattLabel = new System.Windows.Forms.Label();
            this.managePatterns = new System.Windows.Forms.TabPage();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.debugLog = new System.Windows.Forms.RichTextBox();
            this.TabMenu.SuspendLayout();
            this.createNewTab.SuspendLayout();
            this.adjustmentsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustHighNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustLowNum)).BeginInit();
            this.genSaveTable.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabMenu.Controls.Add(this.trackStocksTab);
            this.TabMenu.Controls.Add(this.createNewTab);
            this.TabMenu.Controls.Add(this.managePatterns);
            this.TabMenu.Controls.Add(this.debugTab);
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMenu.ItemSize = new System.Drawing.Size(160, 28);
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Padding = new System.Drawing.Point(10, 2);
            this.TabMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(1264, 681);
            this.TabMenu.TabIndex = 0;
            // 
            // trackStocksTab
            // 
            this.trackStocksTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.trackStocksTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.trackStocksTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackStocksTab.Location = new System.Drawing.Point(4, 32);
            this.trackStocksTab.Margin = new System.Windows.Forms.Padding(0);
            this.trackStocksTab.Name = "trackStocksTab";
            this.trackStocksTab.Size = new System.Drawing.Size(1256, 645);
            this.trackStocksTab.TabIndex = 0;
            this.trackStocksTab.Text = "Track Stocks";
            this.trackStocksTab.UseVisualStyleBackColor = true;
            // 
            // createNewTab
            // 
            this.createNewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.createNewTab.Controls.Add(this.adjustmentsTable);
            this.createNewTab.Controls.Add(this.genProgBar);
            this.createNewTab.Controls.Add(this.newPattTB);
            this.createNewTab.Controls.Add(this.genSaveTable);
            this.createNewTab.Controls.Add(this.lengthError);
            this.createNewTab.Controls.Add(this.decButton);
            this.createNewTab.Controls.Add(this.incButton);
            this.createNewTab.Controls.Add(this.pattLenghtTB);
            this.createNewTab.Controls.Add(this.inDaysLabel);
            this.createNewTab.Controls.Add(this.lenghtPattLabel);
            this.createNewTab.Controls.Add(this.charCountLabel);
            this.createNewTab.Controls.Add(this.pattNameTB);
            this.createNewTab.Controls.Add(this.namePattLabel);
            this.createNewTab.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.createNewTab.Location = new System.Drawing.Point(4, 32);
            this.createNewTab.Margin = new System.Windows.Forms.Padding(0);
            this.createNewTab.Name = "createNewTab";
            this.createNewTab.Size = new System.Drawing.Size(1256, 645);
            this.createNewTab.TabIndex = 1;
            this.createNewTab.Text = "Create New Pattern";
            // 
            // adjustmentsTable
            // 
            this.adjustmentsTable.AutoSize = true;
            this.adjustmentsTable.ColumnCount = 3;
            this.adjustmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.adjustmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.adjustmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.adjustmentsTable.Controls.Add(this.adjustComboBT, 0, 0);
            this.adjustmentsTable.Controls.Add(this.adjustHighNum, 2, 1);
            this.adjustmentsTable.Controls.Add(this.adjustCombo, 0, 1);
            this.adjustmentsTable.Controls.Add(this.adjustHighNumBT, 2, 0);
            this.adjustmentsTable.Controls.Add(this.adjustLowNumBT, 1, 0);
            this.adjustmentsTable.Controls.Add(this.adjustLowNum, 1, 1);
            this.adjustmentsTable.Location = new System.Drawing.Point(357, 175);
            this.adjustmentsTable.Name = "adjustmentsTable";
            this.adjustmentsTable.RowCount = 2;
            this.adjustmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adjustmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adjustmentsTable.Size = new System.Drawing.Size(672, 100);
            this.adjustmentsTable.TabIndex = 12;
            // 
            // adjustComboBT
            // 
            this.adjustComboBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adjustComboBT.AutoSize = true;
            this.adjustComboBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.adjustComboBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustComboBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.adjustComboBT.Location = new System.Drawing.Point(4, 8);
            this.adjustComboBT.Name = "adjustComboBT";
            this.adjustComboBT.Size = new System.Drawing.Size(215, 34);
            this.adjustComboBT.TabIndex = 11;
            this.adjustComboBT.Text = "Change All Inc/Dec";
            this.adjustComboBT.UseVisualStyleBackColor = false;
            this.adjustComboBT.Click += new System.EventHandler(this.adjustComboBT_Click);
            // 
            // adjustHighNum
            // 
            this.adjustHighNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adjustHighNum.AutoSize = true;
            this.adjustHighNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.adjustHighNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.adjustHighNum.Location = new System.Drawing.Point(528, 59);
            this.adjustHighNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adjustHighNum.Name = "adjustHighNum";
            this.adjustHighNum.Size = new System.Drawing.Size(62, 31);
            this.adjustHighNum.TabIndex = 20;
            this.adjustHighNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adjustHighNum.ValueChanged += new System.EventHandler(this.LowAlwaysLow_Click);
            // 
            // adjustCombo
            // 
            this.adjustCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adjustCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.adjustCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adjustCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.adjustCombo.FormattingEnabled = true;
            this.adjustCombo.Items.AddRange(new object[] {
            "Increase",
            "Decrease"});
            this.adjustCombo.Location = new System.Drawing.Point(57, 64);
            this.adjustCombo.Name = "adjustCombo";
            this.adjustCombo.Size = new System.Drawing.Size(109, 31);
            this.adjustCombo.TabIndex = 16;
            // 
            // adjustHighNumBT
            // 
            this.adjustHighNumBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adjustHighNumBT.AutoSize = true;
            this.adjustHighNumBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.adjustHighNumBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustHighNumBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.adjustHighNumBT.Location = new System.Drawing.Point(450, 8);
            this.adjustHighNumBT.Name = "adjustHighNumBT";
            this.adjustHighNumBT.Size = new System.Drawing.Size(218, 34);
            this.adjustHighNumBT.TabIndex = 18;
            this.adjustHighNumBT.Text = "Change All (Y%)";
            this.adjustHighNumBT.UseVisualStyleBackColor = false;
            this.adjustHighNumBT.Click += new System.EventHandler(this.adjustHighNumBT_Click);
            // 
            // adjustLowNumBT
            // 
            this.adjustLowNumBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adjustLowNumBT.AutoSize = true;
            this.adjustLowNumBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.adjustLowNumBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adjustLowNumBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.adjustLowNumBT.Location = new System.Drawing.Point(227, 8);
            this.adjustLowNumBT.Name = "adjustLowNumBT";
            this.adjustLowNumBT.Size = new System.Drawing.Size(215, 34);
            this.adjustLowNumBT.TabIndex = 17;
            this.adjustLowNumBT.Text = "Change All (X%)";
            this.adjustLowNumBT.UseVisualStyleBackColor = false;
            this.adjustLowNumBT.Click += new System.EventHandler(this.adjustLowNumBT_Click);
            // 
            // adjustLowNum
            // 
            this.adjustLowNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adjustLowNum.AutoSize = true;
            this.adjustLowNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.adjustLowNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.adjustLowNum.Location = new System.Drawing.Point(309, 59);
            this.adjustLowNum.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.adjustLowNum.Name = "adjustLowNum";
            this.adjustLowNum.Size = new System.Drawing.Size(50, 31);
            this.adjustLowNum.TabIndex = 19;
            this.adjustLowNum.ValueChanged += new System.EventHandler(this.LowAlwaysLow_Click);
            // 
            // genProgBar
            // 
            this.genProgBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genProgBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.genProgBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.genProgBar.Location = new System.Drawing.Point(13, 296);
            this.genProgBar.Maximum = 125;
            this.genProgBar.Name = "genProgBar";
            this.genProgBar.Size = new System.Drawing.Size(1012, 23);
            this.genProgBar.Step = 1;
            this.genProgBar.TabIndex = 13;
            // 
            // newPattTB
            // 
            this.newPattTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPattTB.AutoSize = true;
            this.newPattTB.ColumnCount = 6;
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.newPattTB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.newPattTB.Location = new System.Drawing.Point(13, 351);
            this.newPattTB.MaximumSize = new System.Drawing.Size(1000, 1400);
            this.newPattTB.Name = "newPattTB";
            this.newPattTB.RowCount = 31;
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.221135F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.221135F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.22613F));
            this.newPattTB.Size = new System.Drawing.Size(664, 1400);
            this.newPattTB.TabIndex = 12;
            // 
            // genSaveTable
            // 
            this.genSaveTable.AutoSize = true;
            this.genSaveTable.ColumnCount = 1;
            this.genSaveTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.genSaveTable.Controls.Add(this.genPatternBT, 0, 0);
            this.genSaveTable.Controls.Add(this.svPatternBT, 0, 1);
            this.genSaveTable.Location = new System.Drawing.Point(13, 175);
            this.genSaveTable.Name = "genSaveTable";
            this.genSaveTable.RowCount = 2;
            this.genSaveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.genSaveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.genSaveTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.genSaveTable.Size = new System.Drawing.Size(306, 100);
            this.genSaveTable.TabIndex = 11;
            // 
            // genPatternBT
            // 
            this.genPatternBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genPatternBT.AutoSize = true;
            this.genPatternBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.genPatternBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genPatternBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.genPatternBT.Location = new System.Drawing.Point(26, 8);
            this.genPatternBT.Name = "genPatternBT";
            this.genPatternBT.Size = new System.Drawing.Size(254, 34);
            this.genPatternBT.TabIndex = 9;
            this.genPatternBT.Text = "Generate Pattern Table";
            this.genPatternBT.UseVisualStyleBackColor = false;
            this.genPatternBT.Click += new System.EventHandler(this.genPatternBT_Click);
            // 
            // svPatternBT
            // 
            this.svPatternBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.svPatternBT.AutoSize = true;
            this.svPatternBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.svPatternBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.svPatternBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.svPatternBT.Location = new System.Drawing.Point(26, 58);
            this.svPatternBT.Name = "svPatternBT";
            this.svPatternBT.Size = new System.Drawing.Size(254, 34);
            this.svPatternBT.TabIndex = 10;
            this.svPatternBT.Text = "Save This Pattern";
            this.svPatternBT.UseVisualStyleBackColor = false;
            // 
            // lengthError
            // 
            this.lengthError.AutoSize = true;
            this.lengthError.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthError.Location = new System.Drawing.Point(353, 106);
            this.lengthError.Name = "lengthError";
            this.lengthError.Size = new System.Drawing.Size(102, 23);
            this.lengthError.TabIndex = 8;
            this.lengthError.Text = "(In Days)";
            // 
            // decButton
            // 
            this.decButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.decButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.decButton.Image = ((System.Drawing.Image)(resources.GetObject("decButton.Image")));
            this.decButton.Location = new System.Drawing.Point(322, 119);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(25, 15);
            this.decButton.TabIndex = 7;
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // incButton
            // 
            this.incButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.incButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.incButton.Image = ((System.Drawing.Image)(resources.GetObject("incButton.Image")));
            this.incButton.Location = new System.Drawing.Point(322, 103);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(25, 15);
            this.incButton.TabIndex = 6;
            this.incButton.UseVisualStyleBackColor = false;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // pattLenghtTB
            // 
            this.pattLenghtTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pattLenghtTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pattLenghtTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.pattLenghtTB.Location = new System.Drawing.Point(273, 103);
            this.pattLenghtTB.MaxLength = 2;
            this.pattLenghtTB.Name = "pattLenghtTB";
            this.pattLenghtTB.ReadOnly = true;
            this.pattLenghtTB.Size = new System.Drawing.Size(43, 31);
            this.pattLenghtTB.TabIndex = 5;
            this.pattLenghtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inDaysLabel
            // 
            this.inDaysLabel.AutoSize = true;
            this.inDaysLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDaysLabel.Location = new System.Drawing.Point(78, 129);
            this.inDaysLabel.Name = "inDaysLabel";
            this.inDaysLabel.Size = new System.Drawing.Size(102, 23);
            this.inDaysLabel.TabIndex = 4;
            this.inDaysLabel.Text = "(In Days)";
            // 
            // lenghtPattLabel
            // 
            this.lenghtPattLabel.AutoSize = true;
            this.lenghtPattLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenghtPattLabel.Location = new System.Drawing.Point(8, 100);
            this.lenghtPattLabel.Name = "lenghtPattLabel";
            this.lenghtPattLabel.Size = new System.Drawing.Size(259, 29);
            this.lenghtPattLabel.TabIndex = 3;
            this.lenghtPattLabel.Text = "Length of Pattern:";
            // 
            // charCountLabel
            // 
            this.charCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charCountLabel.Location = new System.Drawing.Point(223, 60);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(51, 18);
            this.charCountLabel.TabIndex = 2;
            this.charCountLabel.Text = "label1";
            // 
            // pattNameTB
            // 
            this.pattNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pattNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pattNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pattNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.pattNameTB.Location = new System.Drawing.Point(223, 20);
            this.pattNameTB.Name = "pattNameTB";
            this.pattNameTB.Size = new System.Drawing.Size(802, 31);
            this.pattNameTB.TabIndex = 1;
            this.pattNameTB.TextChanged += new System.EventHandler(this.pattNameTB_TextChanged);
            // 
            // namePattLabel
            // 
            this.namePattLabel.AutoSize = true;
            this.namePattLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePattLabel.Location = new System.Drawing.Point(8, 20);
            this.namePattLabel.Name = "namePattLabel";
            this.namePattLabel.Size = new System.Drawing.Size(209, 29);
            this.namePattLabel.TabIndex = 0;
            this.namePattLabel.Text = "Pattern Name:";
            // 
            // managePatterns
            // 
            this.managePatterns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.managePatterns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.managePatterns.Location = new System.Drawing.Point(4, 32);
            this.managePatterns.Margin = new System.Windows.Forms.Padding(0);
            this.managePatterns.Name = "managePatterns";
            this.managePatterns.Size = new System.Drawing.Size(1256, 645);
            this.managePatterns.TabIndex = 2;
            this.managePatterns.Text = "Manage Patterns";
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugLog);
            this.debugTab.Location = new System.Drawing.Point(4, 32);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(1256, 645);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug.Log";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // debugLog
            // 
            this.debugLog.Location = new System.Drawing.Point(8, 3);
            this.debugLog.Name = "debugLog";
            this.debugLog.Size = new System.Drawing.Size(418, 272);
            this.debugLog.TabIndex = 0;
            this.debugLog.Text = "";
            // 
            // TrackerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TabMenu);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "TrackerGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Stock Tracker";
            this.TabMenu.ResumeLayout(false);
            this.createNewTab.ResumeLayout(false);
            this.createNewTab.PerformLayout();
            this.adjustmentsTable.ResumeLayout(false);
            this.adjustmentsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustHighNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustLowNum)).EndInit();
            this.genSaveTable.ResumeLayout(false);
            this.genSaveTable.PerformLayout();
            this.debugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage trackStocksTab;
        private System.Windows.Forms.TabPage createNewTab;
        private System.Windows.Forms.TabPage managePatterns;
        private System.Windows.Forms.Label namePattLabel;
        private System.Windows.Forms.Label inDaysLabel;
        private System.Windows.Forms.Label lenghtPattLabel;
        public System.Windows.Forms.TextBox pattLenghtTB;
        public System.Windows.Forms.TextBox pattNameTB;
        public System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button incButton;
        public System.Windows.Forms.Label lengthError;
        private System.Windows.Forms.Button genPatternBT;
        private System.Windows.Forms.Button svPatternBT;
        private System.Windows.Forms.TableLayoutPanel genSaveTable;
        private System.Windows.Forms.TableLayoutPanel newPattTB;
        private System.Windows.Forms.TabPage debugTab;
        private System.Windows.Forms.RichTextBox debugLog;
        private System.Windows.Forms.ProgressBar genProgBar;
        private System.Windows.Forms.Button adjustComboBT;
        private System.Windows.Forms.ComboBox adjustCombo;
        private System.Windows.Forms.Button adjustHighNumBT;
        private System.Windows.Forms.Button adjustLowNumBT;
        private System.Windows.Forms.NumericUpDown adjustLowNum;
        private System.Windows.Forms.NumericUpDown adjustHighNum;
        private System.Windows.Forms.TableLayoutPanel adjustmentsTable;
    }
}


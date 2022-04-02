namespace ImFlagger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ebFlags = new System.Windows.Forms.TextBox();
            this.ctxMenuEbFlags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCtxMenuEbFlags = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtxMenuEbFlags = new System.Windows.Forms.ToolStripMenuItem();
            this.cxFlagsPreset = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbBit31 = new System.Windows.Forms.CheckBox();
            this.cbBit15 = new System.Windows.Forms.CheckBox();
            this.cbBit30 = new System.Windows.Forms.CheckBox();
            this.cbBit14 = new System.Windows.Forms.CheckBox();
            this.cbBit29 = new System.Windows.Forms.CheckBox();
            this.cbBit13 = new System.Windows.Forms.CheckBox();
            this.cbBit28 = new System.Windows.Forms.CheckBox();
            this.cbBit12 = new System.Windows.Forms.CheckBox();
            this.cbBit27 = new System.Windows.Forms.CheckBox();
            this.cbBit11 = new System.Windows.Forms.CheckBox();
            this.cbBit26 = new System.Windows.Forms.CheckBox();
            this.cbBit10 = new System.Windows.Forms.CheckBox();
            this.cbBit25 = new System.Windows.Forms.CheckBox();
            this.cbBit9 = new System.Windows.Forms.CheckBox();
            this.cbBit24 = new System.Windows.Forms.CheckBox();
            this.cbBit8 = new System.Windows.Forms.CheckBox();
            this.cbBit23 = new System.Windows.Forms.CheckBox();
            this.cbBit7 = new System.Windows.Forms.CheckBox();
            this.cbBit6 = new System.Windows.Forms.CheckBox();
            this.cbBit21 = new System.Windows.Forms.CheckBox();
            this.cbBit5 = new System.Windows.Forms.CheckBox();
            this.cbBit20 = new System.Windows.Forms.CheckBox();
            this.cbBit4 = new System.Windows.Forms.CheckBox();
            this.cbBit19 = new System.Windows.Forms.CheckBox();
            this.cbBit3 = new System.Windows.Forms.CheckBox();
            this.cbBit2 = new System.Windows.Forms.CheckBox();
            this.cbBit17 = new System.Windows.Forms.CheckBox();
            this.cbBit1 = new System.Windows.Forms.CheckBox();
            this.cbBit16 = new System.Windows.Forms.CheckBox();
            this.cbBit0 = new System.Windows.Forms.CheckBox();
            this.cbBit18 = new System.Windows.Forms.CheckBox();
            this.cbBit22 = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ctxMenuEbFlags.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ebFlags
            // 
            this.ebFlags.ContextMenuStrip = this.ctxMenuEbFlags;
            this.ebFlags.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ebFlags.Location = new System.Drawing.Point(232, 553);
            this.ebFlags.MaxLength = 100;
            this.ebFlags.Name = "ebFlags";
            this.ebFlags.ShortcutsEnabled = false;
            this.ebFlags.Size = new System.Drawing.Size(208, 27);
            this.ebFlags.TabIndex = 0;
            this.ebFlags.Text = "00";
            this.ebFlags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ebFlags.TextChanged += new System.EventHandler(this.ebFlags_TextChanged);
            this.ebFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ebFlags_KeyDown);
            this.ebFlags.Leave += new System.EventHandler(this.ebFlags_Leave);
            // 
            // ctxMenuEbFlags
            // 
            this.ctxMenuEbFlags.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuEbFlags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCtxMenuEbFlags,
            this.pasteCtxMenuEbFlags});
            this.ctxMenuEbFlags.Name = "ctxMenuEbFlags";
            this.ctxMenuEbFlags.Size = new System.Drawing.Size(164, 52);
            // 
            // copyCtxMenuEbFlags
            // 
            this.copyCtxMenuEbFlags.Name = "copyCtxMenuEbFlags";
            this.copyCtxMenuEbFlags.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyCtxMenuEbFlags.Size = new System.Drawing.Size(163, 24);
            this.copyCtxMenuEbFlags.Text = "Copy";
            this.copyCtxMenuEbFlags.ToolTipText = "Copy flags";
            this.copyCtxMenuEbFlags.Click += new System.EventHandler(this.copyCtxMenuEbFlags_Click);
            // 
            // pasteCtxMenuEbFlags
            // 
            this.pasteCtxMenuEbFlags.Name = "pasteCtxMenuEbFlags";
            this.pasteCtxMenuEbFlags.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteCtxMenuEbFlags.Size = new System.Drawing.Size(163, 24);
            this.pasteCtxMenuEbFlags.Text = "Paste";
            this.pasteCtxMenuEbFlags.ToolTipText = "Paste flags";
            this.pasteCtxMenuEbFlags.Click += new System.EventHandler(this.pasteCtxMenuEbFlags_Click);
            // 
            // cxFlagsPreset
            // 
            this.cxFlagsPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxFlagsPreset.FormattingEnabled = true;
            this.cxFlagsPreset.Items.AddRange(new object[] {
            "No Preset"});
            this.cxFlagsPreset.Location = new System.Drawing.Point(232, 12);
            this.cxFlagsPreset.Name = "cxFlagsPreset";
            this.cxFlagsPreset.Size = new System.Drawing.Size(307, 28);
            this.cxFlagsPreset.TabIndex = 1;
            this.cxFlagsPreset.Tag = "";
            this.cxFlagsPreset.SelectedIndexChanged += new System.EventHandler(this.cxFlagsPreset_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbBit31, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.cbBit15, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.cbBit30, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.cbBit14, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.cbBit29, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.cbBit13, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.cbBit28, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.cbBit12, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.cbBit27, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbBit11, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbBit26, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbBit10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbBit25, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbBit9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbBit24, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbBit8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbBit23, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbBit7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbBit6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbBit21, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbBit5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbBit20, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbBit4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbBit19, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbBit3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbBit2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBit17, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBit1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBit16, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbBit0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbBit18, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBit22, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249648F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 474);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cbBit31
            // 
            this.cbBit31.AutoSize = true;
            this.cbBit31.Location = new System.Drawing.Point(379, 438);
            this.cbBit31.Name = "cbBit31";
            this.cbBit31.Size = new System.Drawing.Size(65, 24);
            this.cbBit31.TabIndex = 31;
            this.cbBit31.Text = "bit31";
            this.cbBit31.UseVisualStyleBackColor = true;
            // 
            // cbBit15
            // 
            this.cbBit15.AutoSize = true;
            this.cbBit15.Location = new System.Drawing.Point(3, 438);
            this.cbBit15.Name = "cbBit15";
            this.cbBit15.Size = new System.Drawing.Size(65, 24);
            this.cbBit15.TabIndex = 30;
            this.cbBit15.Text = "bit15";
            this.cbBit15.UseVisualStyleBackColor = true;
            // 
            // cbBit30
            // 
            this.cbBit30.AutoSize = true;
            this.cbBit30.Location = new System.Drawing.Point(379, 409);
            this.cbBit30.Name = "cbBit30";
            this.cbBit30.Size = new System.Drawing.Size(65, 23);
            this.cbBit30.TabIndex = 29;
            this.cbBit30.Text = "bit30";
            this.cbBit30.UseVisualStyleBackColor = true;
            // 
            // cbBit14
            // 
            this.cbBit14.AutoSize = true;
            this.cbBit14.Location = new System.Drawing.Point(3, 409);
            this.cbBit14.Name = "cbBit14";
            this.cbBit14.Size = new System.Drawing.Size(65, 23);
            this.cbBit14.TabIndex = 28;
            this.cbBit14.Text = "bit14";
            this.cbBit14.UseVisualStyleBackColor = true;
            // 
            // cbBit29
            // 
            this.cbBit29.AutoSize = true;
            this.cbBit29.Location = new System.Drawing.Point(379, 380);
            this.cbBit29.Name = "cbBit29";
            this.cbBit29.Size = new System.Drawing.Size(65, 23);
            this.cbBit29.TabIndex = 27;
            this.cbBit29.Text = "bit29";
            this.cbBit29.UseVisualStyleBackColor = true;
            // 
            // cbBit13
            // 
            this.cbBit13.AutoSize = true;
            this.cbBit13.Location = new System.Drawing.Point(3, 380);
            this.cbBit13.Name = "cbBit13";
            this.cbBit13.Size = new System.Drawing.Size(65, 23);
            this.cbBit13.TabIndex = 26;
            this.cbBit13.Text = "bit13";
            this.cbBit13.UseVisualStyleBackColor = true;
            // 
            // cbBit28
            // 
            this.cbBit28.AutoSize = true;
            this.cbBit28.Location = new System.Drawing.Point(379, 351);
            this.cbBit28.Name = "cbBit28";
            this.cbBit28.Size = new System.Drawing.Size(65, 23);
            this.cbBit28.TabIndex = 25;
            this.cbBit28.Text = "bit28";
            this.cbBit28.UseVisualStyleBackColor = true;
            // 
            // cbBit12
            // 
            this.cbBit12.AutoSize = true;
            this.cbBit12.Location = new System.Drawing.Point(3, 351);
            this.cbBit12.Name = "cbBit12";
            this.cbBit12.Size = new System.Drawing.Size(65, 23);
            this.cbBit12.TabIndex = 24;
            this.cbBit12.Text = "bit12";
            this.cbBit12.UseVisualStyleBackColor = true;
            // 
            // cbBit27
            // 
            this.cbBit27.AutoSize = true;
            this.cbBit27.Location = new System.Drawing.Point(379, 322);
            this.cbBit27.Name = "cbBit27";
            this.cbBit27.Size = new System.Drawing.Size(65, 23);
            this.cbBit27.TabIndex = 23;
            this.cbBit27.Text = "bit27";
            this.cbBit27.UseVisualStyleBackColor = true;
            // 
            // cbBit11
            // 
            this.cbBit11.AutoSize = true;
            this.cbBit11.Location = new System.Drawing.Point(3, 322);
            this.cbBit11.Name = "cbBit11";
            this.cbBit11.Size = new System.Drawing.Size(65, 23);
            this.cbBit11.TabIndex = 22;
            this.cbBit11.Text = "bit11";
            this.cbBit11.UseVisualStyleBackColor = true;
            // 
            // cbBit26
            // 
            this.cbBit26.AutoSize = true;
            this.cbBit26.Location = new System.Drawing.Point(379, 293);
            this.cbBit26.Name = "cbBit26";
            this.cbBit26.Size = new System.Drawing.Size(65, 23);
            this.cbBit26.TabIndex = 21;
            this.cbBit26.Text = "bit26";
            this.cbBit26.UseVisualStyleBackColor = true;
            // 
            // cbBit10
            // 
            this.cbBit10.AutoSize = true;
            this.cbBit10.Location = new System.Drawing.Point(3, 293);
            this.cbBit10.Name = "cbBit10";
            this.cbBit10.Size = new System.Drawing.Size(65, 23);
            this.cbBit10.TabIndex = 20;
            this.cbBit10.Text = "bit10";
            this.cbBit10.UseVisualStyleBackColor = true;
            // 
            // cbBit25
            // 
            this.cbBit25.AutoSize = true;
            this.cbBit25.Location = new System.Drawing.Point(379, 264);
            this.cbBit25.Name = "cbBit25";
            this.cbBit25.Size = new System.Drawing.Size(65, 23);
            this.cbBit25.TabIndex = 19;
            this.cbBit25.Text = "bit25";
            this.cbBit25.UseVisualStyleBackColor = true;
            // 
            // cbBit9
            // 
            this.cbBit9.AutoSize = true;
            this.cbBit9.Location = new System.Drawing.Point(3, 264);
            this.cbBit9.Name = "cbBit9";
            this.cbBit9.Size = new System.Drawing.Size(57, 23);
            this.cbBit9.TabIndex = 18;
            this.cbBit9.Text = "bit9";
            this.cbBit9.UseVisualStyleBackColor = true;
            // 
            // cbBit24
            // 
            this.cbBit24.AutoSize = true;
            this.cbBit24.Location = new System.Drawing.Point(379, 235);
            this.cbBit24.Name = "cbBit24";
            this.cbBit24.Size = new System.Drawing.Size(65, 23);
            this.cbBit24.TabIndex = 17;
            this.cbBit24.Text = "bit24";
            this.cbBit24.UseVisualStyleBackColor = true;
            // 
            // cbBit8
            // 
            this.cbBit8.AutoSize = true;
            this.cbBit8.Location = new System.Drawing.Point(3, 235);
            this.cbBit8.Name = "cbBit8";
            this.cbBit8.Size = new System.Drawing.Size(57, 23);
            this.cbBit8.TabIndex = 16;
            this.cbBit8.Text = "bit8";
            this.cbBit8.UseVisualStyleBackColor = true;
            // 
            // cbBit23
            // 
            this.cbBit23.AutoSize = true;
            this.cbBit23.Location = new System.Drawing.Point(379, 206);
            this.cbBit23.Name = "cbBit23";
            this.cbBit23.Size = new System.Drawing.Size(65, 23);
            this.cbBit23.TabIndex = 15;
            this.cbBit23.Text = "bit23";
            this.cbBit23.UseVisualStyleBackColor = true;
            // 
            // cbBit7
            // 
            this.cbBit7.AutoSize = true;
            this.cbBit7.Location = new System.Drawing.Point(3, 206);
            this.cbBit7.Name = "cbBit7";
            this.cbBit7.Size = new System.Drawing.Size(57, 23);
            this.cbBit7.TabIndex = 14;
            this.cbBit7.Text = "bit7";
            this.cbBit7.UseVisualStyleBackColor = true;
            // 
            // cbBit6
            // 
            this.cbBit6.AutoSize = true;
            this.cbBit6.Location = new System.Drawing.Point(3, 177);
            this.cbBit6.Name = "cbBit6";
            this.cbBit6.Size = new System.Drawing.Size(57, 23);
            this.cbBit6.TabIndex = 12;
            this.cbBit6.Text = "bit6";
            this.cbBit6.UseVisualStyleBackColor = true;
            // 
            // cbBit21
            // 
            this.cbBit21.AutoSize = true;
            this.cbBit21.Location = new System.Drawing.Point(379, 148);
            this.cbBit21.Name = "cbBit21";
            this.cbBit21.Size = new System.Drawing.Size(65, 23);
            this.cbBit21.TabIndex = 11;
            this.cbBit21.Text = "bit21";
            this.cbBit21.UseVisualStyleBackColor = true;
            // 
            // cbBit5
            // 
            this.cbBit5.AutoSize = true;
            this.cbBit5.Location = new System.Drawing.Point(3, 148);
            this.cbBit5.Name = "cbBit5";
            this.cbBit5.Size = new System.Drawing.Size(57, 23);
            this.cbBit5.TabIndex = 10;
            this.cbBit5.Text = "bit5";
            this.cbBit5.UseVisualStyleBackColor = true;
            // 
            // cbBit20
            // 
            this.cbBit20.AutoSize = true;
            this.cbBit20.Location = new System.Drawing.Point(379, 119);
            this.cbBit20.Name = "cbBit20";
            this.cbBit20.Size = new System.Drawing.Size(65, 23);
            this.cbBit20.TabIndex = 9;
            this.cbBit20.Text = "bit20";
            this.cbBit20.UseVisualStyleBackColor = true;
            // 
            // cbBit4
            // 
            this.cbBit4.AutoSize = true;
            this.cbBit4.Location = new System.Drawing.Point(3, 119);
            this.cbBit4.Name = "cbBit4";
            this.cbBit4.Size = new System.Drawing.Size(57, 23);
            this.cbBit4.TabIndex = 8;
            this.cbBit4.Text = "bit4";
            this.cbBit4.UseVisualStyleBackColor = true;
            // 
            // cbBit19
            // 
            this.cbBit19.AutoSize = true;
            this.cbBit19.Location = new System.Drawing.Point(379, 90);
            this.cbBit19.Name = "cbBit19";
            this.cbBit19.Size = new System.Drawing.Size(65, 23);
            this.cbBit19.TabIndex = 7;
            this.cbBit19.Text = "bit19";
            this.cbBit19.UseVisualStyleBackColor = true;
            // 
            // cbBit3
            // 
            this.cbBit3.AutoSize = true;
            this.cbBit3.Location = new System.Drawing.Point(3, 90);
            this.cbBit3.Name = "cbBit3";
            this.cbBit3.Size = new System.Drawing.Size(57, 23);
            this.cbBit3.TabIndex = 6;
            this.cbBit3.Text = "bit3";
            this.cbBit3.UseVisualStyleBackColor = true;
            // 
            // cbBit2
            // 
            this.cbBit2.AutoSize = true;
            this.cbBit2.Location = new System.Drawing.Point(3, 61);
            this.cbBit2.Name = "cbBit2";
            this.cbBit2.Size = new System.Drawing.Size(57, 23);
            this.cbBit2.TabIndex = 4;
            this.cbBit2.Text = "bit2";
            this.cbBit2.UseVisualStyleBackColor = true;
            // 
            // cbBit17
            // 
            this.cbBit17.AutoSize = true;
            this.cbBit17.Location = new System.Drawing.Point(379, 32);
            this.cbBit17.Name = "cbBit17";
            this.cbBit17.Size = new System.Drawing.Size(65, 23);
            this.cbBit17.TabIndex = 3;
            this.cbBit17.Text = "bit17";
            this.cbBit17.UseVisualStyleBackColor = true;
            // 
            // cbBit1
            // 
            this.cbBit1.AutoSize = true;
            this.cbBit1.Location = new System.Drawing.Point(3, 32);
            this.cbBit1.Name = "cbBit1";
            this.cbBit1.Size = new System.Drawing.Size(57, 23);
            this.cbBit1.TabIndex = 2;
            this.cbBit1.Text = "bit1";
            this.cbBit1.UseVisualStyleBackColor = true;
            // 
            // cbBit16
            // 
            this.cbBit16.AutoSize = true;
            this.cbBit16.Location = new System.Drawing.Point(379, 3);
            this.cbBit16.Name = "cbBit16";
            this.cbBit16.Size = new System.Drawing.Size(65, 23);
            this.cbBit16.TabIndex = 1;
            this.cbBit16.Text = "bit16";
            this.cbBit16.UseVisualStyleBackColor = true;
            // 
            // cbBit0
            // 
            this.cbBit0.AutoSize = true;
            this.cbBit0.Location = new System.Drawing.Point(3, 3);
            this.cbBit0.Name = "cbBit0";
            this.cbBit0.Size = new System.Drawing.Size(57, 23);
            this.cbBit0.TabIndex = 0;
            this.cbBit0.Text = "bit0";
            this.cbBit0.UseVisualStyleBackColor = true;
            // 
            // cbBit18
            // 
            this.cbBit18.AutoSize = true;
            this.cbBit18.Location = new System.Drawing.Point(379, 61);
            this.cbBit18.Name = "cbBit18";
            this.cbBit18.Size = new System.Drawing.Size(65, 23);
            this.cbBit18.TabIndex = 5;
            this.cbBit18.Text = "bit18";
            this.cbBit18.UseVisualStyleBackColor = true;
            // 
            // cbBit22
            // 
            this.cbBit22.AutoSize = true;
            this.cbBit22.Location = new System.Drawing.Point(379, 177);
            this.cbBit22.Name = "cbBit22";
            this.cbBit22.Size = new System.Drawing.Size(65, 23);
            this.cbBit22.TabIndex = 13;
            this.cbBit22.Text = "bit22";
            this.cbBit22.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(446, 552);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(94, 29);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 5000;
            this.tooltip.InitialDelay = 100;
            this.tooltip.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 592);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cxFlagsPreset);
            this.Controls.Add(this.ebFlags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2048, 639);
            this.MinimumSize = new System.Drawing.Size(795, 639);
            this.Name = "Form1";
            this.Text = "Flag Editor";
            this.ctxMenuEbFlags.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox ebFlags;
        private ComboBox cxFlagsPreset;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox cbBit31;
        private CheckBox cbBit15;
        private CheckBox cbBit30;
        private CheckBox cbBit14;
        private CheckBox cbBit29;
        private CheckBox cbBit13;
        private CheckBox cbBit28;
        private CheckBox cbBit12;
        private CheckBox cbBit27;
        private CheckBox cbBit11;
        private CheckBox cbBit26;
        private CheckBox cbBit10;
        private CheckBox cbBit25;
        private CheckBox cbBit9;
        private CheckBox cbBit24;
        private CheckBox cbBit8;
        private CheckBox cbBit23;
        private CheckBox cbBit7;
        private CheckBox cbBit6;
        private CheckBox cbBit21;
        private CheckBox cbBit5;
        private CheckBox cbBit20;
        private CheckBox cbBit4;
        private CheckBox cbBit19;
        private CheckBox cbBit3;
        private CheckBox cbBit2;
        private CheckBox cbBit17;
        private CheckBox cbBit1;
        private CheckBox cbBit16;
        private CheckBox cbBit0;
        private CheckBox cbBit18;
        private CheckBox cbBit22;

        private bool bitEventHandlerDisabled = false;
        private Button btnCopy;
        private ToolTip tooltip;
        private ContextMenuStrip ctxMenuEbFlags;
        private ToolStripMenuItem copyCtxMenuEbFlags;
        private ToolStripMenuItem pasteCtxMenuEbFlags;
    }
}
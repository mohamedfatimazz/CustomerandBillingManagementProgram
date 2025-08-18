namespace CustomerandBillingManagementProgram
{
    partial class FormCustmer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNamePersson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCustmer = new System.Windows.Forms.Button();
            this.ExitPersson = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textPhone = new System.Windows.Forms.TextBox();
            this.datePr = new System.Windows.Forms.DateTimePicker();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.btnAddImgCustmer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFindCustmer = new System.Windows.Forms.Button();
            this.btnDeleteCustmer = new System.Windows.Forms.Button();
            this.picAddImg = new System.Windows.Forms.PictureBox();
            this.btnAmendCustmer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textId_Cu = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelNotA = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textAddres = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picAddImg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNamePersson
            // 
            this.textNamePersson.AcceptsReturn = true;
            this.textNamePersson.AcceptsTab = true;
            this.textNamePersson.Location = new System.Drawing.Point(111, 41);
            this.textNamePersson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textNamePersson.Name = "textNamePersson";
            this.textNamePersson.Size = new System.Drawing.Size(235, 20);
            this.textNamePersson.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textNamePersson, "Add The Name Persson\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustmer
            // 
            this.btnAddCustmer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddCustmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustmer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCustmer.Location = new System.Drawing.Point(128, 334);
            this.btnAddCustmer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddCustmer.Name = "btnAddCustmer";
            this.btnAddCustmer.Size = new System.Drawing.Size(105, 34);
            this.btnAddCustmer.TabIndex = 7;
            this.btnAddCustmer.Text = "➕ Add";
            this.toolTip1.SetToolTip(this.btnAddCustmer, "Add New Person");
            this.btnAddCustmer.UseVisualStyleBackColor = false;
            this.btnAddCustmer.Click += new System.EventHandler(this.btnAddCustmer_Click);
            // 
            // ExitPersson
            // 
            this.ExitPersson.BackColor = System.Drawing.Color.Crimson;
            this.ExitPersson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPersson.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitPersson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitPersson.Location = new System.Drawing.Point(378, 334);
            this.ExitPersson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitPersson.Name = "ExitPersson";
            this.ExitPersson.Size = new System.Drawing.Size(94, 34);
            this.ExitPersson.TabIndex = 10;
            this.ExitPersson.Text = "Exit";
            this.toolTip1.SetToolTip(this.ExitPersson, "Exit From Program");
            this.ExitPersson.UseVisualStyleBackColor = false;
            this.ExitPersson.Click += new System.EventHandler(this.ExitPersson_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Deefl";
            // 
            // textPhone
            // 
            this.textPhone.AcceptsReturn = true;
            this.textPhone.AcceptsTab = true;
            this.textPhone.Location = new System.Drawing.Point(111, 70);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(235, 20);
            this.textPhone.TabIndex = 25;
            this.toolTip1.SetToolTip(this.textPhone, "Add The Name Persson\r\n");
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // datePr
            // 
            this.datePr.Location = new System.Drawing.Point(111, 130);
            this.datePr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePr.Name = "datePr";
            this.datePr.Size = new System.Drawing.Size(235, 20);
            this.datePr.TabIndex = 11;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMale.Location = new System.Drawing.Point(7, 6);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(60, 20);
            this.checkBoxMale.TabIndex = 13;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFemale.Location = new System.Drawing.Point(105, 6);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(76, 20);
            this.checkBoxFemale.TabIndex = 14;
            this.checkBoxFemale.Text = "FeMale";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // btnAddImgCustmer
            // 
            this.btnAddImgCustmer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddImgCustmer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImgCustmer.Location = new System.Drawing.Point(541, 222);
            this.btnAddImgCustmer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddImgCustmer.Name = "btnAddImgCustmer";
            this.btnAddImgCustmer.Size = new System.Drawing.Size(100, 30);
            this.btnAddImgCustmer.TabIndex = 15;
            this.btnAddImgCustmer.Text = "Add Image";
            this.btnAddImgCustmer.UseVisualStyleBackColor = false;
            this.btnAddImgCustmer.Click += new System.EventHandler(this.btnAddImgCustmer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Type :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindCustmer
            // 
            this.btnFindCustmer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindCustmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindCustmer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindCustmer.Location = new System.Drawing.Point(258, 334);
            this.btnFindCustmer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindCustmer.Name = "btnFindCustmer";
            this.btnFindCustmer.Size = new System.Drawing.Size(112, 34);
            this.btnFindCustmer.TabIndex = 19;
            this.btnFindCustmer.Text = "Find";
            this.btnFindCustmer.UseVisualStyleBackColor = false;
            this.btnFindCustmer.Click += new System.EventHandler(this.btnFindCustmer_Click);
            // 
            // btnDeleteCustmer
            // 
            this.btnDeleteCustmer.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCustmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustmer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCustmer.Location = new System.Drawing.Point(128, 334);
            this.btnDeleteCustmer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCustmer.Name = "btnDeleteCustmer";
            this.btnDeleteCustmer.Size = new System.Drawing.Size(105, 34);
            this.btnDeleteCustmer.TabIndex = 20;
            this.btnDeleteCustmer.Text = "Delete";
            this.btnDeleteCustmer.UseVisualStyleBackColor = false;
            this.btnDeleteCustmer.Click += new System.EventHandler(this.btnDeleteCustmer_Click);
            // 
            // picAddImg
            // 
            this.picAddImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAddImg.Location = new System.Drawing.Point(541, 101);
            this.picAddImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picAddImg.Name = "picAddImg";
            this.picAddImg.Size = new System.Drawing.Size(100, 115);
            this.picAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddImg.TabIndex = 12;
            this.picAddImg.TabStop = false;
            // 
            // btnAmendCustmer
            // 
            this.btnAmendCustmer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAmendCustmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmendCustmer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendCustmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmendCustmer.Location = new System.Drawing.Point(128, 334);
            this.btnAmendCustmer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAmendCustmer.Name = "btnAmendCustmer";
            this.btnAmendCustmer.Size = new System.Drawing.Size(105, 34);
            this.btnAmendCustmer.TabIndex = 22;
            this.btnAmendCustmer.Text = "Amend";
            this.btnAmendCustmer.UseVisualStyleBackColor = false;
            this.btnAmendCustmer.Click += new System.EventHandler(this.btnAmendCustmer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(718, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = " CUSTMER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textId_Cu
            // 
            this.textId_Cu.Location = new System.Drawing.Point(110, 5);
            this.textId_Cu.Name = "textId_Cu";
            this.textId_Cu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textId_Cu.Size = new System.Drawing.Size(237, 20);
            this.textId_Cu.TabIndex = 28;
            this.textId_Cu.TextChanged += new System.EventHandler(this.textId_Cu_TextChanged);
            this.textId_Cu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textId_Cu_KeyPress);
            this.textId_Cu.Leave += new System.EventHandler(this.textId_Cu_Leave);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.RosyBrown;
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.Crimson;
            this.labelA.Location = new System.Drawing.Point(400, 67);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(64, 20);
            this.labelA.TabIndex = 142;
            this.labelA.Text = "Added !!";
            this.labelA.Visible = false;
            // 
            // labelNotA
            // 
            this.labelNotA.AutoSize = true;
            this.labelNotA.BackColor = System.Drawing.Color.LightGray;
            this.labelNotA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNotA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotA.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNotA.Location = new System.Drawing.Point(400, 67);
            this.labelNotA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotA.Name = "labelNotA";
            this.labelNotA.Size = new System.Drawing.Size(65, 20);
            this.labelNotA.TabIndex = 143;
            this.labelNotA.Text = "Available";
            this.labelNotA.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.66102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.33898F));
            this.tableLayoutPanel1.Controls.Add(this.textAddres, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textId_Cu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textNamePersson, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textPhone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datePr, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 196);
            this.tableLayoutPanel1.TabIndex = 144;
            // 
            // textAddres
            // 
            this.textAddres.FormattingEnabled = true;
            this.textAddres.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.textAddres.Location = new System.Drawing.Point(110, 100);
            this.textAddres.Name = "textAddres";
            this.textAddres.Size = new System.Drawing.Size(235, 21);
            this.textAddres.TabIndex = 146;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxMale, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxFemale, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(110, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 32);
            this.tableLayoutPanel2.TabIndex = 145;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LimeGreen;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(730, 32);
            this.tableLayoutPanel3.TabIndex = 145;
            // 
            // FormCustmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(730, 402);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelNotA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.btnAmendCustmer);
            this.Controls.Add(this.btnDeleteCustmer);
            this.Controls.Add(this.btnFindCustmer);
            this.Controls.Add(this.btnAddImgCustmer);
            this.Controls.Add(this.picAddImg);
            this.Controls.Add(this.ExitPersson);
            this.Controls.Add(this.btnAddCustmer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUSTMER";
            this.Load += new System.EventHandler(this.FromCustmer_Load);
            this.Move += new System.EventHandler(this.FormCustmer_Move);
            this.Resize += new System.EventHandler(this.FormCustmer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picAddImg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCustmer;
        private System.Windows.Forms.Button ExitPersson;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Button btnAddImgCustmer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFindCustmer;
        private System.Windows.Forms.Button btnDeleteCustmer;
        private System.Windows.Forms.Button btnAmendCustmer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox textNamePersson;
        private System.Windows.Forms.TextBox textId_Cu;
        public System.Windows.Forms.DateTimePicker datePr;
        public System.Windows.Forms.PictureBox picAddImg;
        public System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelNotA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox textAddres;
    }
}


namespace CustomerandBillingManagementProgram
{
    partial class FormProduct
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
            this.textNamePro = new System.Windows.Forms.TextBox();
            this.textPriceBuy = new System.Windows.Forms.TextBox();
            this.textPriceBay = new System.Windows.Forms.TextBox();
            this.picImgPro = new System.Windows.Forms.PictureBox();
            this.ExitPro = new System.Windows.Forms.Button();
            this.btnAddImgPro = new System.Windows.Forms.Button();
            this.btnAmendPro = new System.Windows.Forms.Button();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.btnFindPro = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdPro = new System.Windows.Forms.TextBox();
            this.textNameBra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textCountPro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNotA = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textTyprPro = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timerIdPro = new System.Windows.Forms.Timer(this.components);
            this.btnRemoval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImgPro)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNamePro
            // 
            this.textNamePro.Location = new System.Drawing.Point(217, 76);
            this.textNamePro.Margin = new System.Windows.Forms.Padding(4);
            this.textNamePro.Name = "textNamePro";
            this.textNamePro.Size = new System.Drawing.Size(234, 24);
            this.textNamePro.TabIndex = 1;
            // 
            // textPriceBuy
            // 
            this.textPriceBuy.Location = new System.Drawing.Point(217, 174);
            this.textPriceBuy.Margin = new System.Windows.Forms.Padding(4);
            this.textPriceBuy.Name = "textPriceBuy";
            this.textPriceBuy.Size = new System.Drawing.Size(234, 24);
            this.textPriceBuy.TabIndex = 2;
            this.textPriceBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPriceBuy_KeyPress);
            // 
            // textPriceBay
            // 
            this.textPriceBay.Location = new System.Drawing.Point(217, 209);
            this.textPriceBay.Margin = new System.Windows.Forms.Padding(4);
            this.textPriceBay.Name = "textPriceBay";
            this.textPriceBay.Size = new System.Drawing.Size(234, 24);
            this.textPriceBay.TabIndex = 3;
            this.textPriceBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPriceBay_KeyPress);
            // 
            // picImgPro
            // 
            this.picImgPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImgPro.Location = new System.Drawing.Point(668, 94);
            this.picImgPro.Margin = new System.Windows.Forms.Padding(4);
            this.picImgPro.Name = "picImgPro";
            this.picImgPro.Size = new System.Drawing.Size(116, 147);
            this.picImgPro.TabIndex = 4;
            this.picImgPro.TabStop = false;
            // 
            // ExitPro
            // 
            this.ExitPro.BackColor = System.Drawing.Color.Crimson;
            this.ExitPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitPro.Location = new System.Drawing.Point(469, 409);
            this.ExitPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExitPro.Name = "ExitPro";
            this.ExitPro.Size = new System.Drawing.Size(145, 42);
            this.ExitPro.TabIndex = 11;
            this.ExitPro.Text = "Exit";
            this.ExitPro.UseVisualStyleBackColor = false;
            this.ExitPro.Click += new System.EventHandler(this.ExitPro_Click);
            // 
            // btnAddImgPro
            // 
            this.btnAddImgPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddImgPro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImgPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddImgPro.Location = new System.Drawing.Point(668, 254);
            this.btnAddImgPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddImgPro.Name = "btnAddImgPro";
            this.btnAddImgPro.Size = new System.Drawing.Size(117, 27);
            this.btnAddImgPro.TabIndex = 16;
            this.btnAddImgPro.Text = "➕ Add Image";
            this.btnAddImgPro.UseVisualStyleBackColor = false;
            this.btnAddImgPro.Click += new System.EventHandler(this.btnAddImgPro_Click);
            // 
            // btnAmendPro
            // 
            this.btnAmendPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAmendPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmendPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmendPro.Location = new System.Drawing.Point(117, 395);
            this.btnAmendPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAmendPro.Name = "btnAmendPro";
            this.btnAmendPro.Size = new System.Drawing.Size(118, 42);
            this.btnAmendPro.TabIndex = 26;
            this.btnAmendPro.Text = "Amend";
            this.btnAmendPro.UseVisualStyleBackColor = false;
            this.btnAmendPro.Click += new System.EventHandler(this.btnAmendPro_Click);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.BackColor = System.Drawing.Color.Crimson;
            this.btnDeletePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePro.Location = new System.Drawing.Point(117, 409);
            this.btnDeletePro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(118, 42);
            this.btnDeletePro.TabIndex = 25;
            this.btnDeletePro.Text = "Delete";
            this.btnDeletePro.UseVisualStyleBackColor = false;
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // btnFindPro
            // 
            this.btnFindPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFindPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindPro.Location = new System.Drawing.Point(304, 409);
            this.btnFindPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFindPro.Name = "btnFindPro";
            this.btnFindPro.Size = new System.Drawing.Size(118, 42);
            this.btnFindPro.TabIndex = 24;
            this.btnFindPro.Text = "Find";
            this.btnFindPro.UseVisualStyleBackColor = false;
            this.btnFindPro.Click += new System.EventHandler(this.btnFindPro_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPro.Location = new System.Drawing.Point(117, 409);
            this.btnAddPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(118, 42);
            this.btnAddPro.TabIndex = 23;
            this.btnAddPro.Text = "➕ Add";
            this.btnAddPro.UseVisualStyleBackColor = false;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price Buying ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(7, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price Baye ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Type  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name Brand ";
            // 
            // textIdPro
            // 
            this.textIdPro.Location = new System.Drawing.Point(217, 6);
            this.textIdPro.Margin = new System.Windows.Forms.Padding(4);
            this.textIdPro.Name = "textIdPro";
            this.textIdPro.Size = new System.Drawing.Size(234, 24);
            this.textIdPro.TabIndex = 101;
            this.textIdPro.TextChanged += new System.EventHandler(this.textIdPro_TextChanged);
            this.textIdPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdPro_KeyPress_1);
            this.textIdPro.Leave += new System.EventHandler(this.textIdPro_Leave);
            // 
            // textNameBra
            // 
            this.textNameBra.Location = new System.Drawing.Point(217, 106);
            this.textNameBra.Margin = new System.Windows.Forms.Padding(4);
            this.textNameBra.Name = "textNameBra";
            this.textNameBra.Size = new System.Drawing.Size(234, 24);
            this.textNameBra.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(840, 37);
            this.label5.TabIndex = 103;
            this.label5.Text = "PRODUCT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(7, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 29);
            this.label8.TabIndex = 127;
            this.label8.Text = "Count Product ";
            // 
            // textCountPro
            // 
            this.textCountPro.Location = new System.Drawing.Point(217, 139);
            this.textCountPro.Margin = new System.Windows.Forms.Padding(4);
            this.textCountPro.Name = "textCountPro";
            this.textCountPro.Size = new System.Drawing.Size(234, 24);
            this.textCountPro.TabIndex = 128;
            this.textCountPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCountPro_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(7, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 28);
            this.label9.TabIndex = 130;
            this.label9.Text = "Name  ";
            // 
            // labelNotA
            // 
            this.labelNotA.AutoSize = true;
            this.labelNotA.BackColor = System.Drawing.Color.Gainsboro;
            this.labelNotA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNotA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotA.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNotA.Location = new System.Drawing.Point(526, 58);
            this.labelNotA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNotA.Name = "labelNotA";
            this.labelNotA.Size = new System.Drawing.Size(85, 25);
            this.labelNotA.TabIndex = 140;
            this.labelNotA.Text = "Available";
            this.labelNotA.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Silver;
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.Crimson;
            this.labelA.Location = new System.Drawing.Point(526, 58);
            this.labelA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(84, 25);
            this.labelA.TabIndex = 141;
            this.labelA.Text = "Added !!";
            this.labelA.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.85965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.14035F));
            this.tableLayoutPanel1.Controls.Add(this.textIdPro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textCountPro, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textNamePro, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textNameBra, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textPriceBuy, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textPriceBay, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textTyprPro, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 86);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 240);
            this.tableLayoutPanel1.TabIndex = 142;
            // 
            // textTyprPro
            // 
            this.textTyprPro.FormattingEnabled = true;
            this.textTyprPro.Location = new System.Drawing.Point(217, 42);
            this.textTyprPro.Margin = new System.Windows.Forms.Padding(4);
            this.textTyprPro.Name = "textTyprPro";
            this.textTyprPro.Size = new System.Drawing.Size(234, 24);
            this.textTyprPro.TabIndex = 131;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(856, 43);
            this.tableLayoutPanel2.TabIndex = 143;
            // 
            // timerIdPro
            // 
            this.timerIdPro.Tick += new System.EventHandler(this.timerIdPro_Tick);
            // 
            // btnRemoval
            // 
            this.btnRemoval.BackColor = System.Drawing.Color.DarkViolet;
            this.btnRemoval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoval.Location = new System.Drawing.Point(668, 288);
            this.btnRemoval.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoval.Name = "btnRemoval";
            this.btnRemoval.Size = new System.Drawing.Size(117, 30);
            this.btnRemoval.TabIndex = 144;
            this.btnRemoval.Text = "❌ Removal";
            this.btnRemoval.UseVisualStyleBackColor = false;
            this.btnRemoval.Visible = false;
            this.btnRemoval.Click += new System.EventHandler(this.btnRemoval_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.btnRemoval);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelNotA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAmendPro);
            this.Controls.Add(this.btnDeletePro);
            this.Controls.Add(this.btnFindPro);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.btnAddImgPro);
            this.Controls.Add(this.ExitPro);
            this.Controls.Add(this.picImgPro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCT";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.Move += new System.EventHandler(this.FormProduct_Move);
            this.Resize += new System.EventHandler(this.FormProduct_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImgPro)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitPro;
        private System.Windows.Forms.Button btnAddImgPro;
        private System.Windows.Forms.Button btnAmendPro;
        private System.Windows.Forms.Button btnDeletePro;
        private System.Windows.Forms.Button btnFindPro;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textNamePro;
        public System.Windows.Forms.TextBox textPriceBuy;
        public System.Windows.Forms.TextBox textPriceBay;
        public System.Windows.Forms.PictureBox picImgPro;
        public System.Windows.Forms.TextBox textIdPro;
        public System.Windows.Forms.TextBox textNameBra;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textCountPro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelNotA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timerIdPro;
        private System.Windows.Forms.ComboBox textTyprPro;
        private System.Windows.Forms.Button btnRemoval;
    }
}
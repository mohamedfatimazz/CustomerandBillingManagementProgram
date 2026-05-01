namespace CustomerandBillingManagementProgram
{
    partial class FormInvoice
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
            System.Windows.Forms.ComboBox comboBox1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkPaid = new System.Windows.Forms.CheckBox();
            this.checkUnPaid = new System.Windows.Forms.CheckBox();
            this.btnAmendInv = new System.Windows.Forms.Button();
            this.btnDeleteInv = new System.Windows.Forms.Button();
            this.btnFindInv = new System.Windows.Forms.Button();
            this.btnAddInv = new System.Windows.Forms.Button();
            this.ExitInv = new System.Windows.Forms.Button();
            this.label_IdPro = new System.Windows.Forms.Label();
            this.label_IdCu = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFind = new System.Windows.Forms.TextBox();
            this.label_VI_IN = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelRest = new System.Windows.Forms.Label();
            this.textRest = new System.Windows.Forms.TextBox();
            this.btnRuturn = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelNotA = new System.Windows.Forms.Label();
            this.btnSeveInv = new System.Windows.Forms.Button();
            this.textIdInvoice = new System.Windows.Forms.TextBox();
            this.textIdCU = new System.Windows.Forms.TextBox();
            this.textCountPro = new System.Windows.Forms.TextBox();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textValuePro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.timerInv = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView_PDT_Add = new System.Windows.Forms.DataGridView();
            this.Name_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textIdProd = new System.Windows.Forms.ComboBox();
            this.Add_G_V_D_PDT = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PDT_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.AccessibleName = "";
            comboBox1.CausesValidation = false;
            comboBox1.Enabled = false;
            comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox1.Items.AddRange(new object[] {
            "Paid",
            "UnPaid"});
            comboBox1.Location = new System.Drawing.Point(427, 572);
            comboBox1.Margin = new System.Windows.Forms.Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(131, 31);
            comboBox1.TabIndex = 149;
            // 
            // checkPaid
            // 
            this.checkPaid.AutoSize = true;
            this.checkPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPaid.Location = new System.Drawing.Point(-74, 6);
            this.checkPaid.Margin = new System.Windows.Forms.Padding(4);
            this.checkPaid.Name = "checkPaid";
            this.checkPaid.Size = new System.Drawing.Size(1, 28);
            this.checkPaid.TabIndex = 108;
            this.checkPaid.Text = "Paid";
            this.checkPaid.UseVisualStyleBackColor = true;
            this.checkPaid.CheckedChanged += new System.EventHandler(this.checkPaid_CheckedChanged);
            // 
            // checkUnPaid
            // 
            this.checkUnPaid.AutoSize = true;
            this.checkUnPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnPaid.Location = new System.Drawing.Point(-118, 6);
            this.checkUnPaid.Margin = new System.Windows.Forms.Padding(4);
            this.checkUnPaid.Name = "checkUnPaid";
            this.checkUnPaid.Size = new System.Drawing.Size(94, 28);
            this.checkUnPaid.TabIndex = 109;
            this.checkUnPaid.Text = "UnPaid";
            this.checkUnPaid.UseVisualStyleBackColor = true;
            this.checkUnPaid.CheckedChanged += new System.EventHandler(this.checkUnPaid_CheckedChanged);
            // 
            // btnAmendInv
            // 
            this.btnAmendInv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAmendInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmendInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmendInv.Location = new System.Drawing.Point(321, 636);
            this.btnAmendInv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAmendInv.Name = "btnAmendInv";
            this.btnAmendInv.Size = new System.Drawing.Size(104, 42);
            this.btnAmendInv.TabIndex = 115;
            this.btnAmendInv.Text = "Amend";
            this.btnAmendInv.UseVisualStyleBackColor = false;
            this.btnAmendInv.Click += new System.EventHandler(this.btnAmendInv_Click);
            // 
            // btnDeleteInv
            // 
            this.btnDeleteInv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteInv.Location = new System.Drawing.Point(447, 636);
            this.btnDeleteInv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeleteInv.Name = "btnDeleteInv";
            this.btnDeleteInv.Size = new System.Drawing.Size(104, 42);
            this.btnDeleteInv.TabIndex = 114;
            this.btnDeleteInv.Text = "Delete";
            this.btnDeleteInv.UseVisualStyleBackColor = false;
            this.btnDeleteInv.Click += new System.EventHandler(this.btnDeleteInv_Click);
            // 
            // btnFindInv
            // 
            this.btnFindInv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFindInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindInv.Location = new System.Drawing.Point(194, 636);
            this.btnFindInv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFindInv.Name = "btnFindInv";
            this.btnFindInv.Size = new System.Drawing.Size(104, 42);
            this.btnFindInv.TabIndex = 113;
            this.btnFindInv.Text = "Find";
            this.btnFindInv.UseVisualStyleBackColor = false;
            this.btnFindInv.Click += new System.EventHandler(this.btnFindInv_Click);
            // 
            // btnAddInv
            // 
            this.btnAddInv.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddInv.Location = new System.Drawing.Point(194, 636);
            this.btnAddInv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(106, 42);
            this.btnAddInv.TabIndex = 112;
            this.btnAddInv.Text = "➕ Add";
            this.btnAddInv.UseVisualStyleBackColor = false;
            this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
            // 
            // ExitInv
            // 
            this.ExitInv.BackColor = System.Drawing.Color.Crimson;
            this.ExitInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitInv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitInv.Location = new System.Drawing.Point(845, 636);
            this.ExitInv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExitInv.Name = "ExitInv";
            this.ExitInv.Size = new System.Drawing.Size(99, 42);
            this.ExitInv.TabIndex = 111;
            this.ExitInv.Text = "Exit ❎";
            this.ExitInv.UseVisualStyleBackColor = false;
            this.ExitInv.Click += new System.EventHandler(this.ExitInv_Click);
            // 
            // label_IdPro
            // 
            this.label_IdPro.AutoSize = true;
            this.label_IdPro.BackColor = System.Drawing.Color.Transparent;
            this.label_IdPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_IdPro.Location = new System.Drawing.Point(82, 214);
            this.label_IdPro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_IdPro.Name = "label_IdPro";
            this.label_IdPro.Size = new System.Drawing.Size(126, 29);
            this.label_IdPro.TabIndex = 116;
            this.label_IdPro.Text = "ID Product";
            // 
            // label_IdCu
            // 
            this.label_IdCu.AutoSize = true;
            this.label_IdCu.BackColor = System.Drawing.Color.Transparent;
            this.label_IdCu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdCu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_IdCu.Location = new System.Drawing.Point(66, 127);
            this.label_IdCu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_IdCu.Name = "label_IdCu";
            this.label_IdCu.Size = new System.Drawing.Size(142, 29);
            this.label_IdCu.TabIndex = 117;
            this.label_IdCu.Text = "ID Custmer ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(70, 92);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(130, 29);
            this.label.TabIndex = 118;
            this.label.Text = "ID Invoice ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(964, 33);
            this.label4.TabIndex = 119;
            this.label4.Text = "INVOICE ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFind
            // 
            this.textFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFind.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFind.Location = new System.Drawing.Point(6, -214);
            this.textFind.Margin = new System.Windows.Forms.Padding(4);
            this.textFind.Multiline = true;
            this.textFind.Name = "textFind";
            this.textFind.ReadOnly = true;
            this.textFind.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textFind.Size = new System.Drawing.Size(127, 310);
            this.textFind.TabIndex = 120;
            this.textFind.Visible = false;
            // 
            // label_VI_IN
            // 
            this.label_VI_IN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_VI_IN.AutoSize = true;
            this.label_VI_IN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_VI_IN.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VI_IN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_VI_IN.Location = new System.Drawing.Point(7, 2);
            this.label_VI_IN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_VI_IN.Name = "label_VI_IN";
            this.label_VI_IN.Size = new System.Drawing.Size(125, 1);
            this.label_VI_IN.TabIndex = 121;
            this.label_VI_IN.Text = "View Invoice ";
            this.label_VI_IN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDate.Location = new System.Drawing.Point(63, 162);
            this.labelDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(147, 29);
            this.labelDate.TabIndex = 122;
            this.labelDate.Text = "Date Invoice";
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.BackColor = System.Drawing.Color.Transparent;
            this.labelAct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAct.Location = new System.Drawing.Point(323, 572);
            this.labelAct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(104, 29);
            this.labelAct.TabIndex = 123;
            this.labelAct.Text = "Account ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(82, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 126;
            this.label1.Text = "Count ";
            // 
            // textCount
            // 
            this.textCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCount.Location = new System.Drawing.Point(117, 6);
            this.textCount.Margin = new System.Windows.Forms.Padding(4);
            this.textCount.Name = "textCount";
            this.textCount.ReadOnly = true;
            this.textCount.Size = new System.Drawing.Size(149, 24);
            this.textCount.TabIndex = 131;
            this.textCount.Visible = false;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCount.Location = new System.Drawing.Point(7, 2);
            this.labelCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(97, 32);
            this.labelCount.TabIndex = 132;
            this.labelCount.Text = "Count Product";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCount.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotal.Location = new System.Drawing.Point(331, 540);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(96, 29);
            this.labelTotal.TabIndex = 134;
            this.labelTotal.Text = "⬇Total ⬇";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Visible = false;
            // 
            // textTotal
            // 
            this.textTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTotal.BackColor = System.Drawing.Color.DarkMagenta;
            this.textTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.ForeColor = System.Drawing.Color.Goldenrod;
            this.textTotal.Location = new System.Drawing.Point(427, 538);
            this.textTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(131, 32);
            this.textTotal.TabIndex = 133;
            this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTotal.Visible = false;
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // labelRest
            // 
            this.labelRest.AutoSize = true;
            this.labelRest.BackColor = System.Drawing.Color.Transparent;
            this.labelRest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRest.Location = new System.Drawing.Point(113, 575);
            this.labelRest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRest.Name = "labelRest";
            this.labelRest.Size = new System.Drawing.Size(82, 29);
            this.labelRest.TabIndex = 136;
            this.labelRest.Text = "Rest :";
            this.labelRest.Visible = false;
            // 
            // textRest
            // 
            this.textRest.BackColor = System.Drawing.Color.LightGreen;
            this.textRest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRest.Location = new System.Drawing.Point(198, 572);
            this.textRest.Margin = new System.Windows.Forms.Padding(4);
            this.textRest.Name = "textRest";
            this.textRest.ReadOnly = true;
            this.textRest.Size = new System.Drawing.Size(124, 32);
            this.textRest.TabIndex = 135;
            this.textRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRest.UseWaitCursor = true;
            // 
            // btnRuturn
            // 
            this.btnRuturn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRuturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuturn.Enabled = false;
            this.btnRuturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRuturn.Location = new System.Drawing.Point(580, 636);
            this.btnRuturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRuturn.Name = "btnRuturn";
            this.btnRuturn.Size = new System.Drawing.Size(104, 42);
            this.btnRuturn.TabIndex = 137;
            this.btnRuturn.Text = "Return";
            this.btnRuturn.UseVisualStyleBackColor = false;
            this.btnRuturn.Click += new System.EventHandler(this.btnRuturn_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.SlateGray;
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.Crimson;
            this.labelA.Location = new System.Drawing.Point(64, 52);
            this.labelA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(84, 25);
            this.labelA.TabIndex = 138;
            this.labelA.Text = "Added !!";
            this.labelA.Visible = false;
            // 
            // labelNotA
            // 
            this.labelNotA.AutoSize = true;
            this.labelNotA.BackColor = System.Drawing.Color.Thistle;
            this.labelNotA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNotA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotA.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNotA.Location = new System.Drawing.Point(55, 48);
            this.labelNotA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNotA.Name = "labelNotA";
            this.labelNotA.Size = new System.Drawing.Size(93, 26);
            this.labelNotA.TabIndex = 139;
            this.labelNotA.Text = "Available";
            this.labelNotA.Visible = false;
            // 
            // btnSeveInv
            // 
            this.btnSeveInv.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSeveInv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeveInv.ForeColor = System.Drawing.Color.White;
            this.btnSeveInv.Location = new System.Drawing.Point(608, 555);
            this.btnSeveInv.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeveInv.Name = "btnSeveInv";
            this.btnSeveInv.Size = new System.Drawing.Size(105, 32);
            this.btnSeveInv.TabIndex = 140;
            this.btnSeveInv.Text = "Issue An Invoice";
            this.btnSeveInv.UseVisualStyleBackColor = false;
            this.btnSeveInv.Visible = false;
            this.btnSeveInv.Click += new System.EventHandler(this.btnSeveInv_Click);
            // 
            // textIdInvoice
            // 
            this.textIdInvoice.Location = new System.Drawing.Point(219, 97);
            this.textIdInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.textIdInvoice.Name = "textIdInvoice";
            this.textIdInvoice.Size = new System.Drawing.Size(405, 24);
            this.textIdInvoice.TabIndex = 104;
            this.textIdInvoice.TextChanged += new System.EventHandler(this.textIdInvoice_TextChanged);
            this.textIdInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdInvoice_KeyPress_1);
            this.textIdInvoice.Leave += new System.EventHandler(this.textIdInvoice_Leave);
            // 
            // textIdCU
            // 
            this.textIdCU.Location = new System.Drawing.Point(219, 135);
            this.textIdCU.Margin = new System.Windows.Forms.Padding(4);
            this.textIdCU.Name = "textIdCU";
            this.textIdCU.Size = new System.Drawing.Size(405, 24);
            this.textIdCU.TabIndex = 103;
            this.textIdCU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdCU_KeyPress);
            // 
            // textCountPro
            // 
            this.textCountPro.Location = new System.Drawing.Point(219, 250);
            this.textCountPro.Margin = new System.Windows.Forms.Padding(4);
            this.textCountPro.Name = "textCountPro";
            this.textCountPro.Size = new System.Drawing.Size(140, 24);
            this.textCountPro.TabIndex = 125;
            this.textCountPro.TextChanged += new System.EventHandler(this.textCountPro_TextChanged);
            this.textCountPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCountPro_KeyPress);
            // 
            // dateInvoice
            // 
            this.dateInvoice.Location = new System.Drawing.Point(219, 167);
            this.dateInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(405, 24);
            this.dateInvoice.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(70, 540);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 128;
            this.label2.Text = "Value Paid ";
            // 
            // textValuePro
            // 
            this.textValuePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.textValuePro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValuePro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textValuePro.Location = new System.Drawing.Point(198, 538);
            this.textValuePro.Margin = new System.Windows.Forms.Padding(4);
            this.textValuePro.Name = "textValuePro";
            this.textValuePro.Size = new System.Drawing.Size(124, 32);
            this.textValuePro.TabIndex = 127;
            this.textValuePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textValuePro.TextChanged += new System.EventHandler(this.textValuePro_TextChanged);
            this.textValuePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValuePro_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.Controls.Add(this.labelCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textCount, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(699, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(272, 36);
            this.tableLayoutPanel2.TabIndex = 142;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.09267F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.90734F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.Controls.Add(this.checkPaid, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkUnPaid, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(988, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(62, 42);
            this.tableLayoutPanel3.TabIndex = 143;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AllowDrop = true;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(978, 37);
            this.tableLayoutPanel5.TabIndex = 145;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.35165F));
            this.tableLayoutPanel7.Controls.Add(this.label_VI_IN, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textFind, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(830, 97);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(139, 102);
            this.tableLayoutPanel7.TabIndex = 147;
            // 
            // timerInv
            // 
            this.timerInv.Tick += new System.EventHandler(this.timerInv_Tick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(219, 46);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 24);
            this.textBox1.TabIndex = 151;
            // 
            // dataGridView_PDT_Add
            // 
            this.dataGridView_PDT_Add.AllowUserToAddRows = false;
            this.dataGridView_PDT_Add.AllowUserToOrderColumns = true;
            this.dataGridView_PDT_Add.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_PDT_Add.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_PDT_Add.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_PDT_Add.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_PDT_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PDT_Add.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Product,
            this.Count,
            this.price,
            this.Total_price,
            this.btn_Edit,
            this.btn_Delete});
            this.dataGridView_PDT_Add.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView_PDT_Add.Location = new System.Drawing.Point(76, 279);
            this.dataGridView_PDT_Add.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_PDT_Add.MultiSelect = false;
            this.dataGridView_PDT_Add.Name = "dataGridView_PDT_Add";
            this.dataGridView_PDT_Add.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_PDT_Add.RowHeadersWidth = 51;
            this.dataGridView_PDT_Add.Size = new System.Drawing.Size(868, 251);
            this.dataGridView_PDT_Add.TabIndex = 152;
            this.dataGridView_PDT_Add.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PDT_Add_CellContentClick);
            this.dataGridView_PDT_Add.SelectionChanged += new System.EventHandler(this.dataGridView_PDT_Add_SelectionChanged);
            // 
            // Name_Product
            // 
            this.Name_Product.FillWeight = 200F;
            this.Name_Product.HeaderText = "Name Product";
            this.Name_Product.MinimumWidth = 6;
            this.Name_Product.Name = "Name_Product";
            this.Name_Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name_Product.Width = 200;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // Total_price
            // 
            this.Total_price.HeaderText = "Total Price";
            this.Total_price.MinimumWidth = 6;
            this.Total_price.Name = "Total_price";
            this.Total_price.ReadOnly = true;
            this.Total_price.Width = 125;
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "";
            this.btn_Edit.MinimumWidth = 6;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_Edit.Width = 50;
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "";
            this.btn_Delete.MinimumWidth = 6;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ReadOnly = true;
            this.btn_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_Delete.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(400, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 154;
            this.label3.Text = "price";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textPrice.Enabled = false;
            this.textPrice.Location = new System.Drawing.Point(498, 250);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(126, 24);
            this.textPrice.TabIndex = 153;
            // 
            // textIdProd
            // 
            this.textIdProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textIdProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textIdProd.FormattingEnabled = true;
            this.textIdProd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textIdProd.Location = new System.Drawing.Point(219, 215);
            this.textIdProd.Margin = new System.Windows.Forms.Padding(4);
            this.textIdProd.Name = "textIdProd";
            this.textIdProd.Size = new System.Drawing.Size(405, 24);
            this.textIdProd.TabIndex = 155;
            this.textIdProd.SelectedIndexChanged += new System.EventHandler(this.textIdProd_SelectedIndexChanged);
            this.textIdProd.TextChanged += new System.EventHandler(this.textIdProd_TextChanged);
            // 
            // Add_G_V_D_PDT
            // 
            this.Add_G_V_D_PDT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Add_G_V_D_PDT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_G_V_D_PDT.Location = new System.Drawing.Point(632, 249);
            this.Add_G_V_D_PDT.Margin = new System.Windows.Forms.Padding(4);
            this.Add_G_V_D_PDT.Name = "Add_G_V_D_PDT";
            this.Add_G_V_D_PDT.Size = new System.Drawing.Size(105, 24);
            this.Add_G_V_D_PDT.TabIndex = 156;
            this.Add_G_V_D_PDT.Text = "➕Add Product";
            this.Add_G_V_D_PDT.UseVisualStyleBackColor = false;
            this.Add_G_V_D_PDT.Click += new System.EventHandler(this.Add_G_V_D_PDT_Click);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.ExitInv;
            this.ClientSize = new System.Drawing.Size(978, 693);
            this.Controls.Add(this.Add_G_V_D_PDT);
            this.Controls.Add(this.textIdProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCountPro);
            this.Controls.Add(this.label_IdPro);
            this.Controls.Add(this.dataGridView_PDT_Add);
            this.Controls.Add(this.btnSeveInv);
            this.Controls.Add(this.textRest);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textValuePro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.textIdInvoice);
            this.Controls.Add(comboBox1);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.textIdCU);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dateInvoice);
            this.Controls.Add(this.btnRuturn);
            this.Controls.Add(this.labelNotA);
            this.Controls.Add(this.label_IdCu);
            this.Controls.Add(this.btnAmendInv);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.btnDeleteInv);
            this.Controls.Add(this.btnFindInv);
            this.Controls.Add(this.btnAddInv);
            this.Controls.Add(this.ExitInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVOICE";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.Move += new System.EventHandler(this.FormInvoice_Move);
            this.Resize += new System.EventHandler(this.FormInvoice_Resize);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PDT_Add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAmendInv;
        private System.Windows.Forms.Button btnDeleteInv;
        private System.Windows.Forms.Button btnFindInv;
        private System.Windows.Forms.Button btnAddInv;
        private System.Windows.Forms.Button ExitInv;
        private System.Windows.Forms.Label label_IdPro;
        private System.Windows.Forms.Label label_IdCu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAct;
        public System.Windows.Forms.TextBox textFind;
        public System.Windows.Forms.CheckBox checkPaid;
        public System.Windows.Forms.CheckBox checkUnPaid;
        public System.Windows.Forms.Label label_VI_IN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelRest;
        private System.Windows.Forms.TextBox textRest;
        private System.Windows.Forms.Button btnRuturn;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelNotA;
        private System.Windows.Forms.Button btnSeveInv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textIdInvoice;
        public System.Windows.Forms.TextBox textIdCU;
        public System.Windows.Forms.TextBox textCountPro;
        public System.Windows.Forms.DateTimePicker dateInvoice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textValuePro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Timer timerInv;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView_PDT_Add;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.ComboBox textIdProd;
        private System.Windows.Forms.Button Add_G_V_D_PDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
    }
}
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
            this.picImgPro = new System.Windows.Forms.PictureBox();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textIdInvoice = new System.Windows.Forms.TextBox();
            this.textIdCU = new System.Windows.Forms.TextBox();
            this.textIdProd = new System.Windows.Forms.TextBox();
            this.textCountPro = new System.Windows.Forms.TextBox();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textValuePro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.timerInv = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImgPro)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkPaid
            // 
            this.checkPaid.AutoSize = true;
            this.checkPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPaid.Location = new System.Drawing.Point(141, 5);
            this.checkPaid.Name = "checkPaid";
            this.checkPaid.Size = new System.Drawing.Size(58, 23);
            this.checkPaid.TabIndex = 108;
            this.checkPaid.Text = "Paid";
            this.checkPaid.UseVisualStyleBackColor = true;
            this.checkPaid.CheckedChanged += new System.EventHandler(this.checkPaid_CheckedChanged);
            // 
            // checkUnPaid
            // 
            this.checkUnPaid.AutoSize = true;
            this.checkUnPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnPaid.Location = new System.Drawing.Point(222, 5);
            this.checkUnPaid.Name = "checkUnPaid";
            this.checkUnPaid.Size = new System.Drawing.Size(78, 23);
            this.checkUnPaid.TabIndex = 109;
            this.checkUnPaid.Text = "UnPaid";
            this.checkUnPaid.UseVisualStyleBackColor = true;
            this.checkUnPaid.CheckedChanged += new System.EventHandler(this.checkUnPaid_CheckedChanged);
            // 
            // btnAmendInv
            // 
            this.btnAmendInv.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAmendInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmendInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmendInv.Location = new System.Drawing.Point(122, 361);
            this.btnAmendInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAmendInv.Name = "btnAmendInv";
            this.btnAmendInv.Size = new System.Drawing.Size(89, 34);
            this.btnAmendInv.TabIndex = 115;
            this.btnAmendInv.Text = "Amend";
            this.btnAmendInv.UseVisualStyleBackColor = false;
            this.btnAmendInv.Click += new System.EventHandler(this.btnAmendInv_Click);
            // 
            // btnDeleteInv
            // 
            this.btnDeleteInv.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteInv.Location = new System.Drawing.Point(122, 361);
            this.btnDeleteInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteInv.Name = "btnDeleteInv";
            this.btnDeleteInv.Size = new System.Drawing.Size(89, 34);
            this.btnDeleteInv.TabIndex = 114;
            this.btnDeleteInv.Text = "Delete";
            this.btnDeleteInv.UseVisualStyleBackColor = false;
            this.btnDeleteInv.Click += new System.EventHandler(this.btnDeleteInv_Click);
            // 
            // btnFindInv
            // 
            this.btnFindInv.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindInv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindInv.Location = new System.Drawing.Point(244, 361);
            this.btnFindInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindInv.Name = "btnFindInv";
            this.btnFindInv.Size = new System.Drawing.Size(89, 34);
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
            this.btnAddInv.Location = new System.Drawing.Point(120, 361);
            this.btnAddInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(91, 34);
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
            this.ExitInv.Location = new System.Drawing.Point(355, 361);
            this.ExitInv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitInv.Name = "ExitInv";
            this.ExitInv.Size = new System.Drawing.Size(85, 34);
            this.ExitInv.TabIndex = 111;
            this.ExitInv.Text = "Exit";
            this.ExitInv.UseVisualStyleBackColor = false;
            this.ExitInv.Click += new System.EventHandler(this.ExitInv_Click);
            // 
            // label_IdPro
            // 
            this.label_IdPro.AutoSize = true;
            this.label_IdPro.BackColor = System.Drawing.Color.Transparent;
            this.label_IdPro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_IdPro.Location = new System.Drawing.Point(6, 69);
            this.label_IdPro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IdPro.Name = "label_IdPro";
            this.label_IdPro.Size = new System.Drawing.Size(126, 23);
            this.label_IdPro.TabIndex = 116;
            this.label_IdPro.Text = "ID Product :";
            // 
            // label_IdCu
            // 
            this.label_IdCu.AutoSize = true;
            this.label_IdCu.BackColor = System.Drawing.Color.Transparent;
            this.label_IdCu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdCu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_IdCu.Location = new System.Drawing.Point(6, 33);
            this.label_IdCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IdCu.Name = "label_IdCu";
            this.label_IdCu.Size = new System.Drawing.Size(132, 23);
            this.label_IdCu.TabIndex = 117;
            this.label_IdCu.Text = "ID Custmer :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(6, 2);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 23);
            this.label.TabIndex = 118;
            this.label.Text = "ID Invoice :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(826, 25);
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
            this.textFind.Location = new System.Drawing.Point(5, 5);
            this.textFind.Multiline = true;
            this.textFind.Name = "textFind";
            this.textFind.ReadOnly = true;
            this.textFind.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textFind.Size = new System.Drawing.Size(258, 252);
            this.textFind.TabIndex = 120;
            this.textFind.Visible = false;
            // 
            // label_VI_IN
            // 
            this.label_VI_IN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_VI_IN.AutoSize = true;
            this.label_VI_IN.BackColor = System.Drawing.Color.Transparent;
            this.label_VI_IN.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VI_IN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_VI_IN.Location = new System.Drawing.Point(7, 3);
            this.label_VI_IN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_VI_IN.Name = "label_VI_IN";
            this.label_VI_IN.Size = new System.Drawing.Size(352, 25);
            this.label_VI_IN.TabIndex = 121;
            this.label_VI_IN.Text = "View Invoice ";
            this.label_VI_IN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDate.Location = new System.Drawing.Point(6, 128);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(144, 23);
            this.labelDate.TabIndex = 122;
            this.labelDate.Text = "Date Invoice :";
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.BackColor = System.Drawing.Color.Transparent;
            this.labelAct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAct.Location = new System.Drawing.Point(6, 2);
            this.labelAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(100, 23);
            this.labelAct.TabIndex = 123;
            this.labelAct.Text = "Account :";
            // 
            // picImgPro
            // 
            this.picImgPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImgPro.Location = new System.Drawing.Point(271, 5);
            this.picImgPro.Name = "picImgPro";
            this.picImgPro.Size = new System.Drawing.Size(86, 111);
            this.picImgPro.TabIndex = 124;
            this.picImgPro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 126;
            this.label1.Text = "Count Product:";
            // 
            // textCount
            // 
            this.textCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCount.Location = new System.Drawing.Point(148, 5);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(48, 20);
            this.textCount.TabIndex = 131;
            this.textCount.Visible = false;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCount.Location = new System.Drawing.Point(6, 2);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(84, 29);
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
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotal.Location = new System.Drawing.Point(205, 2);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 29);
            this.labelTotal.TabIndex = 134;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Visible = false;
            // 
            // textTotal
            // 
            this.textTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTotal.Location = new System.Drawing.Point(276, 5);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(108, 20);
            this.textTotal.TabIndex = 133;
            this.textTotal.Visible = false;
            // 
            // labelRest
            // 
            this.labelRest.AutoSize = true;
            this.labelRest.BackColor = System.Drawing.Color.Transparent;
            this.labelRest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRest.Location = new System.Drawing.Point(6, 2);
            this.labelRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRest.Name = "labelRest";
            this.labelRest.Size = new System.Drawing.Size(66, 23);
            this.labelRest.TabIndex = 136;
            this.labelRest.Text = "Rest :";
            this.labelRest.Visible = false;
            // 
            // textRest
            // 
            this.textRest.Location = new System.Drawing.Point(135, 5);
            this.textRest.Name = "textRest";
            this.textRest.Size = new System.Drawing.Size(91, 20);
            this.textRest.TabIndex = 135;
            this.textRest.Visible = false;
            // 
            // btnRuturn
            // 
            this.btnRuturn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRuturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuturn.Enabled = false;
            this.btnRuturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRuturn.Location = new System.Drawing.Point(122, 361);
            this.btnRuturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRuturn.Name = "btnRuturn";
            this.btnRuturn.Size = new System.Drawing.Size(89, 34);
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
            this.labelA.Location = new System.Drawing.Point(41, 328);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(64, 20);
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
            this.labelNotA.Location = new System.Drawing.Point(34, 325);
            this.labelNotA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotA.Name = "labelNotA";
            this.labelNotA.Size = new System.Drawing.Size(75, 21);
            this.labelNotA.TabIndex = 139;
            this.labelNotA.Text = "Available";
            this.labelNotA.Visible = false;
            // 
            // btnSeveInv
            // 
            this.btnSeveInv.BackColor = System.Drawing.Color.Salmon;
            this.btnSeveInv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeveInv.ForeColor = System.Drawing.Color.White;
            this.btnSeveInv.Location = new System.Drawing.Point(234, 5);
            this.btnSeveInv.Name = "btnSeveInv";
            this.btnSeveInv.Size = new System.Drawing.Size(109, 25);
            this.btnSeveInv.TabIndex = 140;
            this.btnSeveInv.Text = "Issue An Invoice";
            this.btnSeveInv.UseVisualStyleBackColor = false;
            this.btnSeveInv.Visible = false;
            this.btnSeveInv.Click += new System.EventHandler(this.btnSeveInv_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.00518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.99482F));
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textIdInvoice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_IdCu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_IdPro, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textIdCU, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textIdProd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textCountPro, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateInvoice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textValuePro, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.77419F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.22581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 192);
            this.tableLayoutPanel1.TabIndex = 141;
            // 
            // textIdInvoice
            // 
            this.textIdInvoice.Location = new System.Drawing.Point(171, 5);
            this.textIdInvoice.Name = "textIdInvoice";
            this.textIdInvoice.Size = new System.Drawing.Size(193, 20);
            this.textIdInvoice.TabIndex = 104;
            this.textIdInvoice.TextChanged += new System.EventHandler(this.textIdInvoice_TextChanged);
            this.textIdInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdInvoice_KeyPress_1);
            this.textIdInvoice.Leave += new System.EventHandler(this.textIdInvoice_Leave);
            // 
            // textIdCU
            // 
            this.textIdCU.Location = new System.Drawing.Point(171, 36);
            this.textIdCU.Name = "textIdCU";
            this.textIdCU.Size = new System.Drawing.Size(193, 20);
            this.textIdCU.TabIndex = 103;
            this.textIdCU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdCU_KeyPress);
            // 
            // textIdProd
            // 
            this.textIdProd.Location = new System.Drawing.Point(171, 72);
            this.textIdProd.Name = "textIdProd";
            this.textIdProd.Size = new System.Drawing.Size(193, 20);
            this.textIdProd.TabIndex = 105;
            this.textIdProd.TextChanged += new System.EventHandler(this.textIdProd_TextChanged);
            this.textIdProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdProd_KeyPress);
            // 
            // textCountPro
            // 
            this.textCountPro.Location = new System.Drawing.Point(171, 101);
            this.textCountPro.Name = "textCountPro";
            this.textCountPro.Size = new System.Drawing.Size(193, 20);
            this.textCountPro.TabIndex = 125;
            this.textCountPro.TextChanged += new System.EventHandler(this.textCountPro_TextChanged);
            this.textCountPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCountPro_KeyPress);
            // 
            // dateInvoice
            // 
            this.dateInvoice.Location = new System.Drawing.Point(171, 131);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(193, 20);
            this.dateInvoice.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 128;
            this.label2.Text = "Value Paid :";
            // 
            // textValuePro
            // 
            this.textValuePro.Location = new System.Drawing.Point(171, 161);
            this.textValuePro.Name = "textValuePro";
            this.textValuePro.Size = new System.Drawing.Size(193, 20);
            this.textValuePro.TabIndex = 127;
            this.textValuePro.TextChanged += new System.EventHandler(this.textValuePro_TextChanged);
            this.textValuePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValuePro_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Controls.Add(this.textCount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTotal, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textTotal, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 33);
            this.tableLayoutPanel2.TabIndex = 142;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.78196F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.21804F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel3.Controls.Add(this.labelAct, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkPaid, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkUnPaid, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(33, 254);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(389, 34);
            this.tableLayoutPanel3.TabIndex = 143;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel4.Controls.Add(this.textRest, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelRest, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSeveInv, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(33, 288);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(389, 37);
            this.tableLayoutPanel4.TabIndex = 144;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AllowDrop = true;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LimeGreen;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(838, 29);
            this.tableLayoutPanel5.TabIndex = 145;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label_VI_IN, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(422, 32);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(366, 31);
            this.tableLayoutPanel6.TabIndex = 146;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.35165F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.64835F));
            this.tableLayoutPanel7.Controls.Add(this.picImgPro, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textFind, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(422, 63);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(366, 262);
            this.tableLayoutPanel7.TabIndex = 147;
            // 
            // timerInv
            // 
            this.timerInv.Tick += new System.EventHandler(this.timerInv_Tick);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.ExitInv;
            this.ClientSize = new System.Drawing.Size(838, 421);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRuturn);
            this.Controls.Add(this.labelNotA);
            this.Controls.Add(this.btnAmendInv);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.btnDeleteInv);
            this.Controls.Add(this.btnFindInv);
            this.Controls.Add(this.btnAddInv);
            this.Controls.Add(this.ExitInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVOICE";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.Move += new System.EventHandler(this.FormInvoice_Move);
            this.Resize += new System.EventHandler(this.FormInvoice_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImgPro)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
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
        public System.Windows.Forms.PictureBox picImgPro;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textIdInvoice;
        public System.Windows.Forms.TextBox textIdCU;
        public System.Windows.Forms.TextBox textIdProd;
        public System.Windows.Forms.TextBox textCountPro;
        public System.Windows.Forms.DateTimePicker dateInvoice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textValuePro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Timer timerInv;
    }
}
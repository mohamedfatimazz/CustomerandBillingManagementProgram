using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Threading;

namespace perssonId
{
    partial class FormShwo : Form
    {
        string cnProt = @"Server=.\JOWAD; Database=AlZain_Company_DATA; User Id=mohamad; Password=m12345; ";
        SqlConnection connectionPr;
        string fqur = "";
        bool n = false;
        public FormShwo()
        {
            InitializeComponent();
        }

        private void FormShwo_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);//
        }


        private void ShowPersson_Click_1(object sender, EventArgs e)
        {
            Form FrmShow = new Form();
            FrmShow.StartPosition = FormStartPosition.CenterScreen;
            // FrmShow.BackColor = Color.;
            FrmShow.Font = this.Font;
            FrmShow.Icon = this.Icon;
            FrmShow.Size = this.Size;
            FrmShow.BackColor = this.BackColor;
            FrmShow.Text = "Custmer All ";
            FrmShow.AutoScroll = true;
            FrmShow.MaximizeBox = FrmShow.MinimizeBox = false;
            FrmShow.Size = new Size(440, 604);
            FrmShow.MaximumSize = Size = new Size(440, 606);
            FrmShow.MinimumSize = Size = new Size(440, 606);
            //nn

            try
            {


                int mytop = 10;
                bool Fond = false;
                SqlConnection connectionPr = new SqlConnection(cnProt);
                string qur = @"select * from CUSTMER ";

                connectionPr.Close();
                SqlCommand connect = new SqlCommand(qur, connectionPr);
                connectionPr.Open();

                SqlDataReader sqlDataReader = connect.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    //
                    TextBox TxtShow = new TextBox();
                    TxtShow.ReadOnly = true;

                    TxtShow.Multiline = true;
                    TxtShow.Width = 200;
                    TxtShow.Height = 125;

                    TxtShow.Top = mytop;
                    //
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(100, 125);
                    pictureBox.Left = 250;

                    pictureBox.Top = mytop;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //
                    TxtShow.Text = "Id : " + sqlDataReader[1].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Name : " + sqlDataReader[2].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Phone : " + sqlDataReader[3].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Adres : " + sqlDataReader[4].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Date : " + sqlDataReader[5].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Type " + sqlDataReader[6].ToString();
                    byte[] svImg = (byte[])sqlDataReader[7];

                    MemoryStream svFondImg = new MemoryStream(svImg);
                    pictureBox.Image = Image.FromStream(svFondImg);
                    FrmShow.Controls.Add(TxtShow);
                    FrmShow.Controls.Add(pictureBox);

                    //////
                    mytop += 125;
                    Fond = true;

                }
                connectionPr.Close();
                if (!Fond)
                {
                    MessageBox.Show("عذرا ما من منتجات مضافة لعرضها ");
                    return;
                }

                FrmShow.ShowDialog();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void ExitPerssonShwo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NamePerssonShwo_Click(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();
            TheCustmerClass.newAd = true;
            TheCustmerClass.Fd = false;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            FormCustmer.ShowDialog();
        }

        private void FindPersson_Click(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            FormCustmer.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = true;
            FormCustmer.ShowDialog();

        }

        private void btnAmendMent_Click(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = true;
            TheCustmerClass.Dt = false;
            FormCustmer.ShowDialog();
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            FormProduct FormProduct = new FormProduct();

            TheCustmerClass.newAd = true;
            TheCustmerClass.Fd = false;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            FormProduct.ShowDialog();
        }

        private void btnFindpro_Click(object sender, EventArgs e)
        {

            FormProduct FormProduct = new FormProduct();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            FormProduct.ShowDialog();
        }

        private void btnAmendPro_Click(object sender, EventArgs e)
        {
            FormProduct FormProduct = new FormProduct();
            FormCustmer FormCustmer = new FormCustmer();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = true;
            TheCustmerClass.Dt = false;
            FormProduct.ShowDialog();
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            FormProduct FormProduct = new FormProduct();

            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = true;
            FormProduct.ShowDialog();

        }

        private void btnShowPro_Click(object sender, EventArgs e)
        {
            Form FrmShow = new Form();
            FrmShow.StartPosition = FormStartPosition.CenterScreen;
            // FrmShow.BackColor = Color.;
            FrmShow.Font = this.Font;
            FrmShow.Icon = this.Icon;
            FrmShow.Size = this.Size;
            FrmShow.BackColor = this.BackColor;
            FrmShow.Text = "Product All Data";
            FrmShow.AutoScroll = true;
            FrmShow.MaximizeBox = FrmShow.MinimizeBox = false;
            FrmShow.Size = new Size(440, 606);
            FrmShow.MaximumSize = Size = new Size(440, 606);
            FrmShow.MinimumSize = Size = new Size(440, 606);
            //nn

            try
            {


                int mytop = 10;
                bool Fond = false;
                SqlConnection connectionPr = new SqlConnection(cnProt);
                string qur = @"select * from PRODUCT ";

                connectionPr.Close();
                SqlCommand connect = new SqlCommand(qur, connectionPr);
                connectionPr.Open();

                SqlDataReader sqlDataReader = connect.ExecuteReader();




                while (sqlDataReader.Read())
                {
                    //
                    TextBox TxtShow = new TextBox();
                    TxtShow.ReadOnly = true; TxtShow.AcceptsTab = false;
                    TxtShow.Multiline = true;
                    //TxtShow.BackColor = this.BackColor;
                    TxtShow.Width = 250;
                    TxtShow.Height = 125;
                    TxtShow.Top = mytop;
                    //
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(100, 125);
                    pictureBox.Left = 305;
                    pictureBox.Top = mytop;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //
                    TxtShow.Text = "Id:" + sqlDataReader[1].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Type : " + sqlDataReader[2].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Name Pro : " + sqlDataReader[3].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Name Brand : " + sqlDataReader[4].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Count Product: : " + sqlDataReader[5].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Price Buying : " + sqlDataReader[6].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Price Baye : " + sqlDataReader[7].ToString();
                    byte[] svImg = (byte[])sqlDataReader[8];
                    MemoryStream svFondImg = new MemoryStream(svImg);
                    pictureBox.Image = Image.FromStream(svFondImg);
                    FrmShow.Controls.Add(TxtShow);
                    FrmShow.Controls.Add(pictureBox);
                    //////
                    mytop += 125;
                    Fond = true;
                }

                connectionPr.Close();
                if (!Fond)
                {
                    MessageBox.Show("عذرا ما من منتجات مضافة لعرضها ");
                    return;
                }
                FrmShow.ShowDialog();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheCustmerClass.newAd = true;
            TheCustmerClass.Fd = false;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            TheCustmerClass.Rut = false;
            formInvoice.ShowDialog();
        }

        private void btnFindInv_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            TheCustmerClass.Rut = false;
            formInvoice.ShowDialog();
        }

        private void btnAmendInv_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = true;
            TheCustmerClass.Dt = false;
            TheCustmerClass.Rut = false;
            formInvoice.ShowDialog();
        }

        private void btnDeleteInv_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = true;
            TheCustmerClass.Rut = false;
            formInvoice.ShowDialog();
        }
        private void btnReturnInv_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheCustmerClass.newAd = false;
            TheCustmerClass.Fd = true;
            TheCustmerClass.AdS = false;
            TheCustmerClass.Dt = false;
            TheCustmerClass.Rut = true;
            formInvoice.ShowDialog();
        }

        private void btnShowInv_Click(object sender, EventArgs e)
        {
            Form FrmShow = new Form();
            FrmShow.StartPosition = FormStartPosition.CenterScreen;
            FrmShow.Font = this.Font;
            FrmShow.Icon = this.Icon;
            FrmShow.Size = new Size(440, 606);
            FrmShow.BackColor = this.BackColor;
            FrmShow.Text = "Custmer Show Invoice";
            FrmShow.AutoScroll = true;
            FrmShow.MaximizeBox = FrmShow.MinimizeBox = false;
            FrmShow.MaximumSize= Size = new Size(440, 606);
            FrmShow.MinimumSize=Size = new Size(440, 606);
            try
            {


                int mytop = 10;
                bool Fond = false;
                connectionPr = new SqlConnection(cnProt);
                string qur = @"select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID,INV.REST_INV , INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV
                    INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO";
              
                connectionPr.Close();
                SqlCommand connect = new SqlCommand(qur, connectionPr);
                if (n)
                {
                    connect = new SqlCommand(fqur, connectionPr);
                }
                connectionPr.Open();

                SqlDataReader sqlDataReader = connect.ExecuteReader();




                while (sqlDataReader.Read())
                {
                  
                    //
                    TextBox TxtShow = new TextBox();
                    TxtShow.ReadOnly = true; TxtShow.AcceptsTab = false;
                    TxtShow.Multiline = true;
                    TxtShow.Width = 250;
                    TxtShow.Height = 190;
                    TxtShow.Top = mytop;
                    //
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(100, 125);
                    pictureBox.Left = 305;
                    pictureBox.Top = mytop;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    //
                    TxtShow.Text = "ID INVOICE: " + sqlDataReader[0].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "ID CUSTMER: " + sqlDataReader[1].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "NAME CUSTMER: " + sqlDataReader[2].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "PHONE :" + sqlDataReader[3].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "ID PRODUCT: " + sqlDataReader[4].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "TYPE PRODUCT: " + sqlDataReader[5].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "NAME PRODUCT: " + sqlDataReader[6].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "NAME BRAND: " + sqlDataReader[7].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "Piece price: " + sqlDataReader[8].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "COUNT PRODUCT: " + sqlDataReader[9].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "TOTAL: " + sqlDataReader[10].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "VALUE PAID: " + sqlDataReader[11].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "REST: " + sqlDataReader[12].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "DATA : " + sqlDataReader[13].ToString();
                    TxtShow.AppendText("\r\n");
                    TxtShow.Text += "ACCOUNT: " + sqlDataReader[14].ToString();
                    //




                    byte[] svImg = (byte[])sqlDataReader[15];
                    MemoryStream svFondImg = new MemoryStream(svImg);
                    pictureBox.Image = Image.FromStream(svFondImg);
                    FrmShow.Controls.Add(TxtShow);
                    FrmShow.Controls.Add(pictureBox);
                    //////
                    mytop += 200;
                    Fond = true;
                }

                connectionPr.Close();
                if (!Fond)
                {
                    MessageBox.Show("عذرا ما من فواتير مضافة لعرضها ");
                    return;
                }
              
                FrmShow.ShowDialog();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

       

        private void btn_Pro_Click(object sender, EventArgs e)
        {
            if (btnAddPro.Visible)
            {
                btnAddPro.Visible = false;
                btnFindpro.Visible = false;
                btnAmendPro.Visible = false;
                btnDeletePro.Visible = false;
                btnShowPro.Visible = false;
                return;
            }
            btnAddPro.Visible = true;
            btnFindpro.Visible = true;
            btnAmendPro.Visible = true;
            btnDeletePro.Visible = true;
            btnShowPro.Visible = true;
        }

        private void btn_Cu_Click(object sender, EventArgs e)
        {
            if (btmAddCu.Visible)
            {
                btmAddCu.Visible = false;
                FindPersson.Visible = false;
                btnAmendMent.Visible = false;
                btnDelete.Visible = false;
                ShowPersson.Visible = false;
                return;
            }
            btmAddCu.Visible = true;
            FindPersson.Visible = true;
            btnAmendMent.Visible = true;
            btnDelete.Visible = true;
            ShowPersson.Visible = true;
        }
      

        private void btn_Inv_Cu_Click(object sender, EventArgs e)
        {
            if (!btnFdCu.Visible)
            {
              
                btnFdCu.Visible = textIdFondCu.Visible = table_btn_text_Fond.Visible=labelIdProd.Visible = true;
               labelIdProd.Text="Id Custmer";
                textIdFondCu.Focus();
                n = false;
               
            }
            else
                btnFdCu.Visible = textIdFondCu.Visible = labelIdProd.Visible= table_btn_text_Fond.Visible = false;

           
        }

        private void btnFdCu_Click(object sender, EventArgs e)
        {
            if (textIdFondCu.Text!="")
            {    
                if (n)
                {
                    fqur = "select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO " +
                 ", PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID,INV.REST_INV , INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV " +
                 "INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU                 " +
                 "INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO  WHERE ID_PRODUCT = '" + textIdFondCu.Text + "'";
                }
                else
                {
                    fqur = "select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO " +
                 ", PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID,INV.REST_INV , INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV " +
                 "INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU                 " +
                 "INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO  WHERE ID_CUSTMER = '" + textIdFondCu.Text + "'";
                }

                n = false;


                n = true;
                btnShowInv_Click(sender, new EventArgs());
            }
            else
            {
                MessageBox.Show("عذرا لم تدخل الId");
                textIdFondCu.Focus();
            }
        
        }

        private void btnYield_Click(object sender, EventArgs e)
        {
            
            connectionPr = new SqlConnection(cnProt);
            string qur = @"select TOTAL_INV, VALUE_PAID,ACCONT from INVOICE ";

            connectionPr.Close();
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            connectionPr.Open();
            SqlDataReader sqlDataReader = connect.ExecuteReader();
            int sum = 0;bool find = false;
            textShow.Text = "";
            while (sqlDataReader.Read())
            {


                if (sqlDataReader[2].ToString() == "Paid")
                {

                    sum += int.Parse(sqlDataReader[1].ToString());
                    find = true;
                    textShow.Text += sqlDataReader[1].ToString();
                    textShow.AppendText("\r\n");
                }
               
                textShow.Visible = true;
                




            }
            if (!find)
            {
                MessageBox.Show("عذرا مامن مبيعات");
                connectionPr.Close();
                return;
            }
            textShow.Focus();
            textShow.AppendText("\r\n");
            textShow.Text += "___________________________________________";
            textShow.AppendText("\r\n");
            textShow.Text += "Total  : " + sum.ToString();
            connectionPr.Close();
        }

        private void btnprofitable_Click(object sender, EventArgs e)
        {
            connectionPr = new SqlConnection(cnProt);
            string qur = @"select  INV.VALUE_PAID,INV.TOTAL_INV,INV.ACCONT from INVOICE AS INV
            INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO ";
     
            connectionPr.Close();
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            connectionPr.Open();
            SqlDataReader sqlDataReader = connect.ExecuteReader();
            int sum = 0;bool find = false;
            textShow.Text = "";
            while (sqlDataReader.Read())
            {

                if (sqlDataReader[2].ToString() == "Paid")
                {

                    sum += int.Parse(sqlDataReader[1].ToString()) - int.Parse(sqlDataReader[0].ToString());
                    textShow.Text += sqlDataReader[1].ToString() + "-" + sqlDataReader[0].ToString();
                    textShow.AppendText("\r\n");
                    find = true;
                }
              

            }
            if (!find)
            {
                MessageBox.Show("عذرا مامن ارباح لعرضها");
                connectionPr.Close();
                return;
            }
            textShow.AppendText("\r\n");
            textShow.Text += "___________________________________________";
            textShow.AppendText("\r\n");
            textShow.Text += "Total Profitable : " + sum.ToString();
           
            textShow.Visible = true;
            textShow.Focus();
          

            connectionPr.Close();
        }

        private void btnDebts_Click(object sender, EventArgs e)
        {
           
            Form FrmShow = new Form();
            FrmShow.StartPosition = FormStartPosition.CenterScreen;
            FrmShow.Font = this.Font;
            FrmShow.Icon = this.Icon;
            FrmShow.Size = this.Size;
            FrmShow.BackColor = this.BackColor;
            FrmShow.Text = "Custmer Debts";
            FrmShow.AutoScroll = true;
            FrmShow.MaximizeBox = FrmShow.MinimizeBox = false;
            FrmShow.Size = new Size(440, 606);
            FrmShow.MaximumSize = Size = new Size(440, 606);
            FrmShow.MinimumSize = Size = new Size(440, 606);
            textShow.Text = "";
            try
            {


                int mytop = 10;
                bool Fond = false;
                connectionPr = new SqlConnection(cnProt);
                string qur = @"select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID ,INV.REST_INV, INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV
                    INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO";


                connectionPr.Close();
                connectionPr.Open();
                SqlCommand connect = new SqlCommand(qur, connectionPr);
                SqlDataReader sqlDataReader = connect.ExecuteReader();
                int sum = 0;
                while (sqlDataReader.Read())
                {

                    if (sqlDataReader[14].ToString() == "UnPaid")
                    {

                        //
                        TextBox TxtShow = new TextBox();
                        TxtShow.ReadOnly = true; TxtShow.AcceptsTab = false;
                        TxtShow.Multiline = true;
                        TxtShow.Width = 250;
                        TxtShow.Height = 190;
                        TxtShow.Top = mytop;
                        //
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(100, 125);
                        pictureBox.Left = 305;
                        pictureBox.Top = mytop;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        //
                        TxtShow.Text = "ID INVOICE: " + sqlDataReader[0].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "ID CUSTMER: " + sqlDataReader[1].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "NAME CUSTMER: " + sqlDataReader[2].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "PHONE :" + sqlDataReader[3].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "ID PRODUCT: " + sqlDataReader[4].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "TYPE PRODUCT: " + sqlDataReader[5].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "NAME PRODUCT: " + sqlDataReader[6].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "NAME BRAND: " + sqlDataReader[7].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "Piece price: " + sqlDataReader[8].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "COUNT PRODUCT: " + sqlDataReader[9].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "TOTAL: " + sqlDataReader[10].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "VALUE PAID: " + sqlDataReader[11].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "REST: " + sqlDataReader[12].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "DATA : " + sqlDataReader[13].ToString();
                        TxtShow.AppendText("\r\n");
                        TxtShow.Text += "ACCOUNT: " + sqlDataReader[14].ToString();
                        //
                        byte[] svImg = (byte[])sqlDataReader[15];
                        MemoryStream svFondImg = new MemoryStream(svImg);
                        pictureBox.Image = Image.FromStream(svFondImg);
                        FrmShow.Controls.Add(TxtShow);
                        FrmShow.Controls.Add(pictureBox);
                        //////
                        sum += int.Parse(sqlDataReader[12].ToString());
                        /////
                        mytop += 125;
                       
                    }
                    Fond = true;
                }
                connectionPr.Close();
                if (Fond&& sum==0)
                {
                    MessageBox.Show("عذرا ما من فواتير مدينة لعرضها ");
                    connectionPr.Close();
                    return;
                }
                else if(!Fond)
                {
                    MessageBox.Show("عذرا ما من فواتير مضافة لعرضها ");
                    connectionPr.Close();
                    return;
                }

                FrmShow.ShowDialog();
                textShow.Text = "Total Debt : " + sum.ToString();
                textShow.Visible = true;
                textShow.Focus();
               
              

                connectionPr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void FormShwo_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(876, 576);
        }

        private void FormShwo_Move(object sender, EventArgs e)
        {
            this.Size = new Size(876, 576);
            
        }

       

        private void btn_Pro_MouseHover(object sender, EventArgs e)
        {
            btnAddPro.Visible = true;
            btnFindpro.Visible = true;
            btnAmendPro.Visible = true;
            btnDeletePro.Visible = true;
            btnShowPro.Visible = true;
        }

       

        private void btn_Cu_MouseHover(object sender, EventArgs e)
        {
            btmAddCu.Visible = true;
            FindPersson.Visible = true;
            btnAmendMent.Visible = true;
            btnDelete.Visible = true;
            ShowPersson.Visible = true;
        }

        private void textShow_Leave(object sender, EventArgs e)
        {
            textShow.Visible = false;
        }

        private void btnNrPtSold_Click(object sender, EventArgs e)
        {
            string qur = @"select  PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,COUNT(INV.ID_PRODUCT)  from INVOICE AS INV
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO
                    GROUP BY PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR ";
            bool Fond = false;
            connectionPr = new SqlConnection(cnProt);
            connectionPr.Close();
            connectionPr.Open();
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            SqlDataReader sqlDataReader = connect.ExecuteReader();
            textShow.Text = "";
            while (sqlDataReader.Read())
            {
                textShow.Text += "ID PRODUCT: " + sqlDataReader[0].ToString();
                textShow.AppendText("\r\n");
                textShow.Text += "TYPE PRODUCT: " + sqlDataReader[1].ToString();
                textShow.AppendText("\r\n");
                textShow.Text += "NAME PRODUCT: " + sqlDataReader[2].ToString();
                textShow.AppendText("\r\n");
                textShow.Text += "NAME BRAND: " + sqlDataReader[3].ToString();
                textShow.AppendText("\r\n");
                textShow.Text += "Count: " + sqlDataReader[4].ToString();
                textShow.AppendText("\r\n");
                textShow.Text += "____________________________________________";
                textShow.AppendText("\r\n");
              
                Fond = true;
            }
            if (!Fond)
            {
                MessageBox.Show("عذرا مامن مبيغات لعرضها");
                return;
            }
            textShow.ScrollBars = ScrollBars.Horizontal;
            textShow.Visible = true;
            textShow.Focus();

        }

        private void btnSw_Inv_Prod_Click(object sender, EventArgs e)
        {
            if (!btnFdCu.Visible)
            {
                
                timerForm.Enabled = true;
                n = true;
                btnFdCu.Visible = textIdFondCu.Visible = labelIdProd.Visible=table_btn_text_Fond.Visible = true;
                labelIdProd.Text = "ID Product :";
                textIdFondCu.Focus();
                
            }
            else
                btnFdCu.Visible = textIdFondCu.Visible = labelIdProd.Visible = table_btn_text_Fond.Visible = false;
        }
        int i =0;
        private void timerForm_Tick(object sender, EventArgs e)
        {
          
            if (i == 100)
            {
                i = 0;
                timerForm.Enabled = false;
                btnFdCu.Visible = textIdFondCu.Visible = table_btn_text_Fond.Visible=labelIdProd.Visible = labelIdProd.Visible = false;
                return;
            }
          
            ++i;
            
        }

       

        private void textIdFondCu_Leave_1(object sender, EventArgs e)
        {
            timerForm_Tick(sender, e);
            btnFdCu.Visible = textIdFondCu.Visible = table_btn_text_Fond.Visible = labelIdProd.Visible = labelIdProd.Visible = false;
        }

        private void textIdFondCu_TextChanged(object sender, EventArgs e)
        {
            if (textIdFondCu.Text!="")
            {
              
                btnFdCu.Visible = textIdFondCu.Visible = labelIdProd.Visible = table_btn_text_Fond.Visible = labelIdProd.Visible = true;
            }
        }

        private void textIdFondCu_DragEnter(object sender, DragEventArgs e)
        {
            btnFdCu.Focus();
        }

        private void table_btn_text_Fond_MouseMove(object sender, MouseEventArgs e)
        {
            btnFdCu.Visible = textIdFondCu.Visible = table_btn_text_Fond.Visible = labelIdProd.Visible = true;
        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Black)
            {
              
                this.BackColor = Color.Black;


                pictureBox1.Image = Properties.Resources.imdinv;
               

            }
            else
            {
                this.BackColor = Color.White;
                pictureBox1.Image = Properties.Resources.imgon;

            }
        }
    }
}

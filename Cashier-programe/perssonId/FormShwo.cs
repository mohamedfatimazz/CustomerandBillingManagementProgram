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
using CustomerandBillingManagementProgram;
using perssonId;

namespace CustomerandBillingManagementProgram
{
    partial class FormShwo : Form
    {

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
        private void ExitPerssonShwo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormShwo_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1131, 581);
        }

        private void FormShwo_Move(object sender, EventArgs e)
        {
            this.Size = new Size(1131, 581);

        }
        private void textShow_Leave(object sender, EventArgs e)
        {
            textShow.Visible = false;
        }


        private void btnSw_Inv_Prod_Click(object sender, EventArgs e)
        {
            if (!btnFdCu.Visible)
            {

                timerForm.Enabled = true;
                n = true;
                btnFdCu.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = textShow.Visible = true;
                btnFondShow_PDT_CTR_IVC.Text = "ID Product :";
                textShow.Focus();

            }
            else
                btnFdCu.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = textShow.Visible = false;
        }
        int i = 0;
        private void timerForm_Tick(object sender, EventArgs e)
        {

            if (i == 100)
            {
                i = 0;
                timerForm.Enabled = false;
                btnFdCu.Visible = textShow.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
                return;
            }

            ++i;

        }


        private void textIdFondCu_Leave_1(object sender, EventArgs e)
        {
            timerForm_Tick(sender, e);
            btnFdCu.Visible = textShow.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
        }



        private void textIdFondCu_DragEnter(object sender, DragEventArgs e)
        {
            btnFdCu.Focus();
        }

        private void table_btn_text_Fond_MouseMove(object sender, MouseEventArgs e)
        {
            btnFdCu.Visible = textShow.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = true;
        }
        private void textIdFondCu_TextChanged_1(object sender, EventArgs e)
        {
            if (textShow.Text != "")
            {
                btnFdCu.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = true;
            }
        }
        private void btnAddCu_Click_1(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();
            TheBaseClass.addBaseClass(true, false, false, false, false);
            FormCustmer.ShowDialog();
        }

        private void btnAmendMent_Click_1(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();
            TheBaseClass.addBaseClass(false, true, true, false, false);
            FormCustmer.ShowDialog();
        }
        private void btnFdCu_Click_1(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();

            TheBaseClass.addBaseClass(false, true, false, false, false);
            FormCustmer.ShowDialog();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormCustmer FormCustmer = new FormCustmer();

            TheBaseClass.addBaseClass(false, true, false, true, false);
            FormCustmer.ShowDialog();
        }
        /////////////////////////
        private void btnAddPro_Click_1(object sender, EventArgs e)
        {
            FormProduct FormProduct = new FormProduct();

            TheBaseClass.addBaseClass(true, true, false, false, false);
            FormProduct.ShowDialog();
        }
        private void btnAmendPro_Click_1(object sender, EventArgs e)
        {
            FormProduct FormProduct = new FormProduct();

            TheBaseClass.addBaseClass(false, true, true, false, false);
            FormProduct.ShowDialog();
        }
        private void btnFindpro_Click_1(object sender, EventArgs e)
        {
            FormProduct FormProduct = new FormProduct();
            TheBaseClass.addBaseClass(false, true, false, false, false);
            FormProduct.ShowDialog();
        }
        private void btnDeletePro_Click_1(object sender, EventArgs e)
        {

            FormProduct FormProduct = new FormProduct();
            TheBaseClass.addBaseClass(false, true, false, true, false);
            FormProduct.ShowDialog();
        }

        private void btnAddInv_Click_1(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();

            TheBaseClass.addBaseClass(true, false, false, false, false);
            formInvoice.ShowDialog();
        }

        private void btnAmendInv_Click_1(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheBaseClass.addBaseClass(false, true, true, false, false);
            formInvoice.ShowDialog();
        }

        private void btnReturnInv_Click_1(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheBaseClass.addBaseClass(false, true, false, false, true);
            formInvoice.ShowDialog();
        }

        private void btnFindInv_Click_1(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheBaseClass.addBaseClass(false, true, false, false, false);
            formInvoice.ShowDialog();
        }

        private void btnDeleteInv_Click_1(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            TheBaseClass.addBaseClass(false, true, false, true, false);
            formInvoice.ShowDialog();
        }
        private void btnShowInv_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridViewInvoice.Rows.Clear();
                dataGridViewShwo_Add_Colums();

                bool Fond = false;
                Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice);
                if (n)
                {
                    Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice+"\t\n"+fqur);
                }

                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    dataGridViewInvoice.Rows.Add(sqlDataReader[0], sqlDataReader[1], sqlDataReader[2], sqlDataReader[3],
                        sqlDataReader[4], sqlDataReader[5], sqlDataReader[6],
                        sqlDataReader[7], sqlDataReader[8], sqlDataReader[9], sqlDataReader[10],
                        sqlDataReader[11], sqlDataReader[12], sqlDataReader[13], sqlDataReader[14]);

                    Fond = true;
                }
                if (!Fond)
                {
                    MessageBox.Show("عذرا ما من فواتير مضافة لعرضها ");
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnShowPro_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool Fond = false;

                Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Product);
                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                dataGridViewProduct.Rows.Clear();
                dataGridViewProduct.RowTemplate.Height = 70;
                while (sqlDataReader.Read())
                {
                    dataGridViewProduct.Rows.Add(sqlDataReader[1], sqlDataReader[2],
                                            sqlDataReader[3], sqlDataReader[4], sqlDataReader[5], sqlDataReader[6], sqlDataReader[7], sqlDataReader[8]);
                    Fond = true;
                }
                if (!Fond)
                {
                    MessageBox.Show("عذرا ما من منتجات مضافة لعرضها ");
                    return;
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void ShowPersson_Click(object sender, EventArgs e)
        {
            try
            {
                bool Fond = false;
                Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Custmer);
                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                dataGridViewCustmer.Rows.Clear();
                dataGridViewCustmer.RowTemplate.Height = 70;
                while (sqlDataReader.Read())
                {
                    dataGridViewCustmer.Rows.Add(sqlDataReader[1], sqlDataReader[2], sqlDataReader[3],
                       sqlDataReader[4], sqlDataReader[5], sqlDataReader[6], sqlDataReader[7]);

                    Fond = true;

                }
                if (!Fond)
                {
                    MessageBox.Show("عذرا ما من منتجات مضافة لعرضها ");
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnSw_Inv_Prod_Click_1(object sender, EventArgs e)
        {
            if (!btnFdCu.Visible)
            {
                timerForm.Enabled = true;
                n = true;
                btnFondShow_PDT_CTR_IVC.Visible = textIdFondCu.Visible = btnFondShow_PDT_CTR_IVC.Visible = true;
                btnFondShow_PDT_CTR_IVC.Text = "ID Product :";
                textIdFondCu.Focus();
            }
            else
            {
                btnFdCu.Visible = textIdFondCu.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
            }

            int i = 0;
        }

        private void btnYield_Click_1(object sender, EventArgs e)
        {
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Yild_Invoice);
            SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
            int sum = 0; bool find = false;
            textShow.Text = "";
            while (sqlDataReader.Read())
            {
                if (sqlDataReader[2].ToString() == "UnPaid")
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
                Conactn_Qure_Class.SqlConnection_Close();
                return;
            }
            textShow.Focus();
            textShow.AppendText("\r\n");
            textShow.Text += "___________________________________________";
            textShow.AppendText("\r\n");
            textShow.Text += "Total  : " + sum.ToString();
            Conactn_Qure_Class.SqlConnection_Close();
        }

        private void btnprofitable_Click(object sender, EventArgs e)
        {
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Yild_Invoice);
            SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
            int sum = 0; bool find = false;
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
                Conactn_Qure_Class.SqlConnection_Close();
                return;
            }
            textShow.AppendText("\r\n");
            textShow.Text += "___________________________________________";
            textShow.AppendText("\r\n");
            textShow.Text += "Total Profitable : " + sum.ToString();
            textShow.Visible = true;
            textShow.Focus();
            Conactn_Qure_Class.SqlConnection_Close();
        }
        private void btnDebts_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool Fond = false;
                Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice);
                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                int sum = 0;
                dataGridViewShwo_Add_Colums();
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader[2].ToString() == "UnPaid")
                    {
                        dataGridViewShwo.Rows.Add(sqlDataReader[0], sqlDataReader[1], sqlDataReader[2], sqlDataReader[3],
                    sqlDataReader[4], sqlDataReader[5], sqlDataReader[6],
                    sqlDataReader[7], sqlDataReader[8], sqlDataReader[9], sqlDataReader[10],
                    sqlDataReader[11], sqlDataReader[12], sqlDataReader[13], sqlDataReader[14]);

                        //////
                        sum += int.Parse(sqlDataReader[12].ToString());
                        /////

                    }
                    Fond = true;
                }
                Conactn_Qure_Class.SqlConnection_Close();
                if (Fond && sum == 0)
                {
                    MessageBox.Show("عذرا ما من فواتير مدينة لعرضها ");
                    Conactn_Qure_Class.SqlConnection_Close();
                    return;
                }
                else if (!Fond)
                {
                    MessageBox.Show("عذرا ما من فواتير مضافة لعرضها ");
                    Conactn_Qure_Class.SqlConnection_Close();
                    return;
                }

                //  FrmShow.ShowDialog();
                textShow.Text = "Total Debt : " + sum.ToString();
                textShow.Visible = true;
                textShow.Focus();
                Conactn_Qure_Class.SqlConnection_Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Inv_Cu_Click_1(object sender, EventArgs e)
        {
            if (!btnFdCu.Visible)
            {

                btnFdCu.Visible = textIdFondCu.Visible = btnFondShow_PDT_CTR_IVC.Visible = true;
                btnFondShow_PDT_CTR_IVC.Text = "Id Custmer";
                textIdFondCu.Focus();
                n = false;

            }
            else
                btnFdCu.Visible = textIdFondCu.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
        }


        public void dataGridViewShwo_Add_Colums()
        {
            dataGridViewShwo.Columns.Clear();
            dataGridViewShwo.Rows.Clear();
            dataGridViewShwo.Columns.Add("ID_INVOICE", "ID INVOICE");
            dataGridViewShwo.Columns.Add("ID_CUSTMER", "ID CUSTMER");
            dataGridViewShwo.Columns.Add("NAME_CUSTMER", "NAME CUSTMER");
            dataGridViewShwo.Columns.Add("PHONE", "PHONED");
            dataGridViewShwo.Columns.Add("ID_PRODUCT", "ID PRODUCT");
            dataGridViewShwo.Columns.Add("TYPE_PRODUCT", "TYPE PRODUCT");
            dataGridViewShwo.Columns.Add("NAME_PRODUCT", "NAME PRODUCT");
            dataGridViewShwo.Columns.Add("NAME_BRAND", "NAME BRANDT");
            dataGridViewShwo.Columns.Add("Piece_price", "Piece price");
            dataGridViewShwo.Columns.Add("COUNT_PRODUCT", "COUNT PRODUCT");
            dataGridViewShwo.Columns.Add("TOTAL", "TOTAL");
            dataGridViewShwo.Columns.Add("VALUE_PAID", "VALUE PAID");
            dataGridViewShwo.Columns.Add("REST", "REST");
            dataGridViewShwo.Columns.Add("DATA", "DATA");
            dataGridViewShwo.Columns.Add("ACCOUNT", "ACCOUNT");



        }
       
    private void btnNrPtSold_Click_1(object sender, EventArgs e)
            
        {
           
            dataGridViewShwo.Columns.Clear();
            dataGridViewShwo.Rows.Clear();
            dataGridViewShwo.Columns.Add("IdProduct", "ID PRODUCT");
            dataGridViewShwo.Columns.Add("TypeProduct", "TYPE PRODUCT");
            dataGridViewShwo.Columns.Add("NameProduct", "NAME PRODUCT");
            dataGridViewShwo.Columns.Add("NameBrand", "NAME BRAND");
            dataGridViewShwo.Columns.Add("Count", "Count");

             
            bool Fond = false;
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_btnNrPtSold);
            SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
            
            while (sqlDataReader.Read())
            {
                
                dataGridViewShwo.Rows.Add(sqlDataReader[0], sqlDataReader[1], sqlDataReader[2]
                    , sqlDataReader[3], sqlDataReader[4]);
                Fond = true;
            }
            Conactn_Qure_Class.SqlConnection_Close();
            if (!Fond)
            {
                Conactn_Qure_Class.SqlConnection_Close();
                MessageBox.Show("عذرا مامن مبيغات لعرضها");
                return;
            }
        }

        private void btnFondShow_PDT_CTR_IVC_Click(object sender, EventArgs e)
        {
            if (textShow.Text != "")
            {
                if (n)
                {
                    fqur = " WHERE ID_PRODUCT = '" + textShow.Text + "'";
                }
                else
                {
                    fqur = "WHERE ID_CUSTMER = '" + textShow.Text + "'";
                }
                n = true;
                btnShowInv_Click_1(sender, new EventArgs());
            }
            else
            {
                MessageBox.Show("عذرا لم تدخل الId");
                textShow.Focus();
            }
        }
    }
}

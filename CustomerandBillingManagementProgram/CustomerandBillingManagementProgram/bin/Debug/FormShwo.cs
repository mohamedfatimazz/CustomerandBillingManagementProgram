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
using CustomerandBillingManagementProgram;

namespace CustomerandBillingManagementProgram
{
    partial class FormShwo : Form
    {
        string fqur;
        bool Bool = false, Qure_Bool;
        int tirmnalTick = 0;
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
        private void timerForm_Tick(object sender, EventArgs e)
        {

            if (tirmnalTick == 50)
            {
                tirmnalTick = 0;
                timerForm.Enabled = false;
                 textShow.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
                return;
            }
            ++tirmnalTick;
        }
        private void textIdFond_CTR_PDT_IVC_DragEnter(object sender, DragEventArgs e)
        {
            btnFondShow_PDT_CTR_IVC.Focus();
        }
        private void textIdFond_CTR_PDT_IVC_Leave(object sender, EventArgs e)
        {
            timerForm_Tick(sender, e);
             textShow.Visible = textShow.Visible = btnFondShow_PDT_CTR_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
        }
        private void table_btn_text_Fond_MouseMove(object sender, MouseEventArgs e)
        {
            labelOCK_Id_CTR_PDT.Visible = textIdFond_CTR_PDT_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = true;
        }
        private void textIdFond_CTR_PDT_IVC_TextChanged_1(object sender, EventArgs e)
        {
            if (textIdFond_CTR_PDT_IVC.Text != "")
            {
                tirmnalTick = 0;
                labelOCK_Id_CTR_PDT.Visible = textIdFond_CTR_PDT_IVC.Visible  = btnFondShow_PDT_CTR_IVC.Visible = true;
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

            TheBaseClass.addBaseClass(true,false, false, false, false);
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
               
                if (Bool)
                {
                    Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice+"\t\n"+fqur);
                }
                else
                {
                    Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice);
                }

                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();//dataGridViewShwo
                while (sqlDataReader.Read())
                {
                    if (Bool)
                    {
                        dataGridViewShwo.Rows.Add(sqlDataReader[0], sqlDataReader[2],
                        sqlDataReader[5], sqlDataReader[6],
                       sqlDataReader[7], sqlDataReader[8], sqlDataReader[9], sqlDataReader[10],
                       sqlDataReader[11], sqlDataReader[12], sqlDataReader[13], sqlDataReader[14]);
                    }
                    else
                    {
                        dataGridViewInvoice.Rows.Add(sqlDataReader[0], sqlDataReader[2]
                            , sqlDataReader[5], sqlDataReader[6],
                            sqlDataReader[7], sqlDataReader[8], sqlDataReader[9], sqlDataReader[10],
                            sqlDataReader[11], sqlDataReader[12], sqlDataReader[13], sqlDataReader[14]);
                    }
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
                Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_PDT);
                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                dataGridViewProduct.Rows.Clear();
                dataGridViewProduct.RowTemplate.Height = 70;
                while (sqlDataReader.Read())
                {
                    byte[] imgsy = (byte[])sqlDataReader[8];
                    if (imgsy.Length!=0)
                    {
                        dataGridViewProduct.Rows.Add(sqlDataReader[1], sqlDataReader[2],
                                           sqlDataReader[3], sqlDataReader[4], sqlDataReader[5], sqlDataReader[6], sqlDataReader[7], sqlDataReader[8]);
                    }
                    else
                    dataGridViewProduct.Rows.Add(sqlDataReader[1], sqlDataReader[2],
                                          sqlDataReader[3], sqlDataReader[4], sqlDataReader[5], sqlDataReader[6], sqlDataReader[7]);

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
                Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_CTR);
                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                dataGridViewCustmer.Rows.Clear();
                dataGridViewCustmer.RowTemplate.Height = 70;
               
                while (sqlDataReader.Read())
                {
                    byte[] imgsv = (byte[])sqlDataReader[7];
                    if (imgsv.Length!=0)
                    {
                        dataGridViewCustmer.Rows.Add(sqlDataReader[1], sqlDataReader[2], sqlDataReader[3],
                      sqlDataReader[4], sqlDataReader[5], sqlDataReader[6], sqlDataReader[7]);
                    }
                   else
                        dataGridViewCustmer.Rows.Add(sqlDataReader[1], sqlDataReader[2], sqlDataReader[3],
                      sqlDataReader[4], sqlDataReader[5], sqlDataReader[6]);

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
                    sum += int.Parse(sqlDataReader[0].ToString())- int.Parse(sqlDataReader[1].ToString());
                    find = true;
                    textShow.Text += sqlDataReader[0].ToString()+"-"+ sqlDataReader[1].ToString();
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
            textShow.Text += "___________________";
            textShow.AppendText("\r\n");
            textShow.Text += "Total Rest : " + sum.ToString();
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
                    sum += int.Parse(sqlDataReader[0].ToString()) - int.Parse(sqlDataReader[1].ToString());
                    textShow.Text += sqlDataReader[0].ToString() + "-" + sqlDataReader[1].ToString();
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
            textShow.Text += "_______________";
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
                        dataGridViewShwo.Rows.Add(sqlDataReader[0], sqlDataReader[2]
                    , sqlDataReader[5], sqlDataReader[6],
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

                //FrmShow.ShowDialog();
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
            Bool = false;
            Add_Visible_Found("Add Id Custmer");
        }
        private void btnSw_Inv_Prod_Click_1(object sender, EventArgs e)
        {
            Bool = true;
           
            Add_Visible_Found("Add Id Product");
           
        }
        private void Add_Visible_Found(string Label_Value)
        {
            if (!labelOCK_Id_CTR_PDT.Visible || labelOCK_Id_CTR_PDT.Text == "Add Id Custmer"|| labelOCK_Id_CTR_PDT.Text== "Add Id Product")
            {

               table_btn_text_Fond.Visible= labelOCK_Id_CTR_PDT.Visible = textIdFond_CTR_PDT_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = true;
                labelOCK_Id_CTR_PDT.Text = Label_Value;
                textIdFond_CTR_PDT_IVC.Focus();
                //Bool = false;  
            }
            else
                table_btn_text_Fond.Visible= labelOCK_Id_CTR_PDT.Visible = textIdFond_CTR_PDT_IVC.Visible = btnFondShow_PDT_CTR_IVC.Visible = false;
            tirmnalTick = 0;
        }
        public void dataGridViewShwo_Add_Colums()
        {
            dataGridViewShwo.Columns.Clear();
            dataGridViewShwo.Rows.Clear();
            dataGridViewShwo.Columns.Add("ID_INVOICE", "ID INVOICE");
            //dataGridViewShwo.Columns.Add("ID_CUSTMER", "ID CUSTMER");
            dataGridViewShwo.Columns.Add("NAME_CUSTMER", "NAME CUSTMER");
            //dataGridViewShwo.Columns.Add("PHONE", "PHONED");
            //dataGridViewShwo.Columns.Add("ID_PRODUCT", "ID PRODUCT");
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
            if (textIdFond_CTR_PDT_IVC.Text != "")//
            {
               
                if (Bool)
                {
                    fqur = " WHERE ID_PRODUCT = '" + textIdFond_CTR_PDT_IVC.Text + "'";
                }
                else
                {
                    fqur = "WHERE ID_CUSTMER = '" + textIdFond_CTR_PDT_IVC.Text + "'";
                }
                Bool = true;
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

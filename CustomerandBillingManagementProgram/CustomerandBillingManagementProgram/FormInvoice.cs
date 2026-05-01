using CustomerandBillingManagementProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CustomerandBillingManagementProgram
{
    public partial class FormInvoice : Form
    {
        
        TheInvoiceClass InvoiceClass = new TheInvoiceClass();
       
       
        object Data_Inv;
        int total = 0;
        int rest = 0;
        string Account = "";
        string Amfnd = "";
        bool ren=false;
        public FormInvoice()
        {
           
            InitializeComponent();
            ItemsProduct_Add();
        }
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            textIdInvoice.Focus();

           
            btnAddInv.Visible = TheBaseClass.Add_bool;
            btnFindInv.Visible = TheBaseClass.Fond_bool;
            btnAmendInv.Visible = ren = TheBaseClass.Amend_bool;
            btnDeleteInv.Visible = TheBaseClass.Delete_bool;
            btnRuturn.Visible= TheBaseClass.Rutern_bool ;
            label_VI_IN.Visible = false;
            textFind.Visible = false;
            this.BackColor = FormShwo.DefaultBackColor;
            //textFind.Visible = TheCustmerClass.Fd;
            //

            //

            //
            btnAmendInv.Enabled = btnDeleteInv.Enabled = false;

            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);//
        }
       
       

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (textIdInvoice.Text != "" && textIdProd.Text != "" && textIdCU.Text != "" &&textCountPro.Text!=""&&textValuePro.Text!=""&& Account != "")
                {
                    if ((int.Parse(textCountPro.Text)) > 0)
                    {
                        if (total >= int.Parse(textValuePro.Text))
                        {
                          

                            if (InvoiceClass.Find_Id_Custmer(textIdCU.Text))
                            {
                                MessageBox.Show("عذرا id  الزبون غير موجود الرجاء التاكد منه والمحاولة مرة اخرة");
                                textIdCU.Focus();
                                textIdCU.SelectAll();
                                return;
                            }
                            else if (InvoiceClass.findInvoice(textIdInvoice.Text, textIdProd.Text, int.Parse(textCountPro.Text),false, false))
                            {
                                MessageBox.Show(" id  مستخدم من قبل");
                                textIdInvoice.Focus();
                                textIdInvoice.SelectAll();
                                return;
                            }
                            else if (InvoiceClass.Find_Id_Product(textIdProd.Text, (int.Parse(textCountPro.Text)), true))
                            {
                                MessageBox.Show("عذرا id  المنتج غير موجود الرجاء التاكد منه والمحاولة مرة اخرة");
                                textIdProd.Focus();
                                textIdProd.SelectAll();
                                return;
                            }
                            else if (!InvoiceClass.Find1)
                            {
                                MessageBox.Show("عذرا عدد المنتجات المطلوبة غير كافة ");
                                textCountPro.Focus();
                                textCountPro.SelectAll();
                                return;
                            }

                            else
                            {
                                InvoiceClass.addNewInvoice(textIdInvoice.Text
                               ,textIdCU.Text,
                                 textIdProd.Text,
                                textCountPro.Text,
                                 dateInvoice.Value.ToShortDateString(),
                                 total.ToString(),
                                textValuePro.Text,
                                 rest.ToString(),
                               Account);
                                    


                                MessageBox.Show("تم اضافة فاتورة جديد");
                                btnFindInv_Click(sender, e);
                                Null_text();
                            }
                        }
                        else
                        {

                            MessageBox.Show("عذرا القيمة المدخلة اكبر من قيمة الفاتورة");
                            textValuePro.Focus(); textValuePro.SelectAll();
                            textRest.Visible = labelRest.Visible = false;
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("( عذرا عدد المنتجات المطلوب يجب ان يكون اكبر من ( صفر ");
                    }

                }

                else
                {
                    MessageBox.Show("احد الحقول فارغ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "!!!");

            }
        }

        private void btnFindInv_Click(object sender, EventArgs e)
        {
            try
            {
                bool Fond = false;
                

                if (textIdInvoice.Text != "")
                {
                    Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice + "\r\n"+ "WHERE ID_INVOICE ='" + textIdInvoice.Text + "'");
                  
                    SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        textFind.Text = "ID INVOICE: " + sqlDataReader[0].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "ID CUSTMER : " + sqlDataReader[1].ToString();
                        textIdCU.Text = sqlDataReader[1].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "NAME CUSTMER: " + sqlDataReader[2].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "PHONE :" + sqlDataReader[3].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "ID PRODUCT: " + sqlDataReader[4].ToString();
                        textIdProd.Text = sqlDataReader[4].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "TYPE PRODUCT: " + sqlDataReader[5].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "NAME PRODUCT: " + sqlDataReader[6].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "NAME BRAND: " + sqlDataReader[7].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "Piece price: " + sqlDataReader[8].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "COUNT PRODUCT: " + sqlDataReader[9].ToString();
                        textCountPro.Text = sqlDataReader[9].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "TOTAL: " + sqlDataReader[10].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "VALUE PAID: " + sqlDataReader[11].ToString();
                        textValuePro.Text= sqlDataReader[11].ToString();
                        textFind.AppendText("\r\n");
                        textFind.Text += "REST: " + sqlDataReader[12].ToString();
                        textFind.AppendText("\r\n");
                        //dateInvoice.Text = sqlDataReader[13].ToString();
                        textFind.Text += "DATA: " + sqlDataReader[13].ToString();
                     //  
                        textFind.AppendText("\r\n");
                            textFind.Text += "ACCOUNT: " + sqlDataReader[14].ToString();
                    ////////
                    if (sqlDataReader[14].ToString() == "Paid")
                    {
                        checkPaid.Checked = true;
                    }
                    else
                    {
                        checkUnPaid.Checked = true;
                    }
                       
                        textFind.Visible = label_VI_IN.Visible = true;
                        Fond = true;
                    
                    }
                   if(!Fond)
                   {
                        MessageBox.Show("لايوجد بيانات لهاذا id");
                       
                        textIdInvoice.Focus();
                        return;
                   }
                        Amfnd = textIdInvoice.Text;
                        btnAmendInv.Enabled = btnDeleteInv.Enabled = btnSeveInv.Visible = btnRuturn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("الرجاء ادخال id");
                    textIdInvoice.Focus();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "!!");
            }
       
        }

        private void btnAmendInv_Click(object sender, EventArgs e)
        {
            
            try
            {

                  if (textIdInvoice.Text != "" && textIdProd.Text != "" && textIdCU.Text != "" && Account != "")
                  {
                        DialogResult dialogResult = MessageBox.Show("هل انت متاكد من هذه العملية", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (dialogResult == DialogResult.Yes)
                     {
                        ren = false;
                        if (Amfnd == textIdInvoice.Text)
                        {

                            if ((int.Parse(textCountPro.Text)) > 0)
                            {

                                if (total >= int.Parse(textValuePro.Text))
                                {
                                    if (InvoiceClass.Find_Id_Custmer(textIdCU.Text))
                                    {
                                        MessageBox.Show("عذرا id  الزبون غير موجود الرجاء التاكد منه والمحاولة مرة اخرة");
                                        textIdCU.Focus();
                                        textIdCU.SelectAll();
                                        return;
                                    }

                                    else if (InvoiceClass.Find_Id_Product(textIdProd.Text, (int.Parse(textCountPro.Text)), false))
                                    {
                                        MessageBox.Show("عذرا id  المنتج غير موجود الرجاء التاكد منه والمحاولة مرة اخرة");
                                        textIdProd.Focus();
                                        textIdProd.SelectAll();
                                        return;
                                    }
                                    else if (InvoiceClass.findInvoice(textIdInvoice.Text, textIdProd.Text, (int.Parse(textCountPro.Text)),true, false))
                                    {
                                        if (!InvoiceClass.Find1)
                                        {

                                            MessageBox.Show("عذرا عدد المنتجات المطلوبة غير كافة ");
                                            textCountPro.Focus();
                                            textCountPro.SelectAll();
                                            return;
                                        }

                                    }
                                    InvoiceClass.amendInvoice(textIdInvoice.Text
                               , textIdCU.Text,"",
                                 //textIdProd1.Text,
                                textCountPro.Text,
                                 dateInvoice.Value.ToShortDateString(),
                                 total.ToString(),
                                textValuePro.Text,
                                 rest.ToString(),
                               Account);

                                    MessageBox.Show("تمت المعلية بنجاح");
                                    btnFindInv_Click(sender, e);
                                    Null_text();
                                }
                                else//;
                                {

                                    MessageBox.Show("عذرا القيمة المدخلة اكبر من قيمة الفاتورة");
                                    textValuePro.Focus(); textValuePro.SelectAll();
                                    textRest.Visible = labelRest.Visible = false;
                                }

                            }
                            else
                            {
                                MessageBox.Show("( عذرا عدد المنتجات المطلوب يجب ان يكون اكبر من ( صفر ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("عذرا لا يمكنك تغير الId Invoice");
                        }

                     }
                     else
                     { 
                         MessageBox.Show("تم الغاء المعلية بنجاح"); 
                         return;

                     }
                  }
                  else
                  {
                        MessageBox.Show("احد الحقول فارغ");
                  }

               

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                throw;
            }
        }

        private void btnDeleteInv_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متاكد من هذه العملية", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (textIdInvoice.Text == Amfnd)
                    {
                        if (ren)
                        {
                            //InvoiceClass.findInvoice(textIdInvoice.Text, textIdProd1.Text, (int.Parse(textCountPro.Text)),true, true);
                        }
                        InvoiceClass.deleteInvoice(textIdInvoice.Text);
                      
                        Null_text();
                        checkPaid.Checked = checkUnPaid.Checked = false;
                        btnDeleteInv.Enabled = false;
                        textIdInvoice.Focus();
                        MessageBox.Show("تمت المعلية بنجاح");
                        ren = false;
                    }
                    else
                    {
                        MessageBox.Show("عذرا تم الغاء المعلية لقد قمت بتغير الId Invoice");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("تم الغاء المعلية بنجاح");
                    return;
                }
            
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                throw;
            }
        }
        private void btnRuturn_Click(object sender, EventArgs e)
        {
            if (textIdInvoice.Text==Amfnd)
            {
                ren = true;
                btnDeleteInv_Click(sender,e);
                btnRuturn.Enabled = false;
            }
            else
            {
                MessageBox.Show("عذرا لقد قمت بتغير الId Invoice");
                return;
            }
        }

        private void ExitInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPaid.Checked)
            {
                Account = "Paid";
                checkUnPaid.Checked = false;
            }
        }

        private void checkUnPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUnPaid.Checked)
            {
                Account = "UnPaid";
                checkPaid.Checked = false;
            }
        }

      private void Null_text()
        {
            textIdInvoice.Clear() ;
            textIdCU.Clear();
            textCountPro.Clear();
            textIdProd.Text=string.Empty;
            textValuePro.Clear();
            textRest.Clear();
            textPrice.Clear();
            Account = "";
            btnAmendInv.Enabled = false;
            checkPaid.Checked = checkUnPaid.Checked = false;
            textIdInvoice.Focus();
        }

       

        private void textIdInvoice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textIdCU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCountPro_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textValuePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textIdProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCountPro_TextChanged(object sender, EventArgs e)
        {
          

                //if (textCountPro.Text != "")
                //{
                //    if (InvoiceClass.findProduct(textIdProd1.Text))
                //    {
                //        total = (int.Parse(textCountPro.Text)) * int.Parse(TheBaseClass.Model[6].ToString());//
                //        textTotal.Text = total.ToString();
                //        textValuePro_TextChanged(sender, e);


                //        textTotal.Visible = labelTotal.Visible = true;
                //    }

                //}
                //else
                //{
                //    textTotal.Visible = labelTotal.Visible = false;
                //}
        }

       

        private void textValuePro_TextChanged(object sender, EventArgs e)
        {
            if (textCountPro.Text!=""&& textCount.Text!="")
            {
                if (textValuePro.Text != "" & int.Parse(textCountPro.Text) > 0 )
                {
                    //
                    rest = total - int.Parse(textValuePro.Text);
                    textRest.Text = rest.ToString();
                    textRest.Visible = labelRest.Visible = true;

                }
                else
                {
                    textRest.Visible = labelRest.Visible = false;
                }
            }
        }

        private void FormInvoice_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(858, 606);
        }

        private void FormInvoice_Move(object sender, EventArgs e)
        {
            this.Size = new Size(858, 606);
        }

        private void textIdInvoice_TextChanged(object sender, EventArgs e)
        {
         
            if (textIdInvoice.Text != ""&&btnAddInv.Visible)
            {
                labelNotA.Visible = false;
                labelA.Visible = false;
                string qur = @"select * from INVOICE 
                WHERE ID_INVOICE ='" + textIdInvoice.Text + "'";
                Conactn_Qure_Class.SqlCommand_Fn(qur);
                SqlDataReader sqlDataReader = Conactn_Qure_Class.connect.ExecuteReader();
                ren = false;
                while (sqlDataReader.Read())
                {
                    ren = true;
                    break;
                }
               
                if (ren)
                {
                    labelA.Visible = true;
                    labelNotA.Visible = false;
                }
                else { 
                    labelA.Visible = false;
                    labelNotA.Visible = true;
                }
                timerInv.Enabled = true;
               
                ren = false;
            }
            
        }
        private void textIdInvoice_Leave(object sender, EventArgs e)
        {
            labelNotA.Visible = false;
            labelA.Visible = false;
            ren = false;
        }
        private void btnSeveInv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "قم باختيار مكان حفظ الملف";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "txt&File|*.Text*.Txt|AllFile|*.*";
            saveFileDialog.FilterIndex = 2;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string NameFile = saveFileDialog.FileName;


                if (Path.GetExtension(saveFileDialog.FileName).ToLower() == "")
                {
                    NameFile += ".txt";
                }

                StreamWriter newFile = new StreamWriter(NameFile);
                    newFile.WriteLine("Al Zain Company \nView Invoice \n" + textFind.Text);
                    newFile.Close();
                    MessageBox.Show("تم حفظ الملف بنجاح ");
                
            }
        }

        //private void textFind_TextChanged(object sender, EventArgs e)
        //{
        //    //if (textFind.Text=="")
        //    //{
        //    //    textFind.Visible = false;
        //    //    btnSeveInv.Visible = false;
        //    //}
        //}
        int i = 0;
        private void timerInv_Tick(object sender, EventArgs e)
        {
            
            if ( i== 15)
            {
                timerInv.Enabled = false;
                labelA.Visible = false;
                labelNotA.Visible = false;
                i = 0;
                return;
            }
            i++;
        }
        public void ItemsProduct_Add()
        {
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_PDT);
            SqlDataReader dataReader = Conactn_Qure_Class.connect.ExecuteReader();
            while (dataReader.Read())
            {
                textIdProd.Items.Add(dataReader.GetValue(1).ToString()  +"_"+ dataReader.GetValue(2).ToString() +"_"+ dataReader.GetValue(3).ToString() );
            }
            
        }
     

      
        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_G_V_D_PDT_Click(object sender, EventArgs e)
        {
            if (textCountPro.Text==string.Empty &&textIdProd.Text==string.Empty)
            {
             
                MessageBox.Show("Add Count Count Null", "erorr");
                return;
            }
            int total = int.Parse(textCountPro.Text) * int.Parse(textPrice.Text);
            dataGridView_PDT_Add.Rows.Add(textIdProd.Text, textCountPro.Text, textPrice.Text, total, "Edit", "delet❎");
            Null_text();

        }

        private void dataGridView_PDT_Add_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_PDT_Add.Columns["btn_Edit"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متاكد  من امر التعديل", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult==DialogResult.Yes)
                {
                    textIdProd.Text = dataGridView_PDT_Add.CurrentRow.Cells["Name_Product"].Value.ToString();
                    textCountPro.Text = dataGridView_PDT_Add.CurrentRow.Cells["Count"].Value.ToString();
                    dataGridView_PDT_Add.Rows.Remove(dataGridView_PDT_Add.CurrentRow);
                }
                 
            }
            if (e.ColumnIndex == dataGridView_PDT_Add.Columns["btn_Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogResul_Delet= MessageBox.Show("هل انت متاكد من امر ازالت هذا النتج من الفاتورة", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResul_Delet == DialogResult.Yes)
                {
                    dataGridView_PDT_Add.Rows.Remove(dataGridView_PDT_Add.CurrentRow);
                MessageBox.Show("تم ازالت المنتج بنجاح", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            }
            
        }

        private void textIdProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textIdProd_TextChanged(object sender, EventArgs e)
        {
            if (textIdProd.Text != "" && textIdProd.Focus())
            {
                string[] mxm = textIdProd.Text.Split('_');
                if (InvoiceClass.findProduct(mxm[0]))
                {

                    textCount.Text = TheBaseClass.Model[5].ToString();
                    textPrice.Text = TheBaseClass.Model[7].ToString();
                    textCount.Visible = labelCount.Visible = true;
                }
            }
            else
            {
                textCount.Visible = labelCount.Visible = false;
            }
        }

      

        private void dataGridView_PDT_Add_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}

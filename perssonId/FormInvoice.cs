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

namespace perssonId
{
    public partial class FormInvoice : Form
    {
        TheInvoiceClass InvoiceClass = new TheInvoiceClass();
        string cnProt = @"Server=.\JOWAD; Database=AlZain_Company_DATA; User Id=mohamad; Password=m12345; ";
        SqlConnection connectionPr;
        object Data_Inv;
        int total = 0;
        int rest = 0;
        string Account = "";
        string Amfnd = "";
        bool ren=false;
        public FormInvoice()
        {
            InitializeComponent();
        }
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            textIdInvoice.Focus();

            picImgPro.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddInv.Visible = TheCustmerClass.newAd;
            btnFindInv.Visible = TheCustmerClass.Fd;
            btnAmendInv.Visible = ren = TheCustmerClass.AdS;
            btnDeleteInv.Visible = TheCustmerClass.Dt;
            btnRuturn.Visible= TheCustmerClass.Rut ;
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
                            Data_Inv = new {
                                ID_Inv = textIdInvoice.Text,
                                ID_Cu = textIdCU.Text,
                                ID_Pro = textIdProd.Text,
                                Count = textCountPro.Text,
                                Date_Time = dateInvoice.Value.ToShortDateString(),
                                Total = total.ToString(),
                                VALUE_PAID = textValuePro.Text,
                                Rest = rest.ToString(),
                                Accounto = Account
                            };

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
                                InvoiceClass.addNewInvoice(ref Data_Inv);
                                    


                                MessageBox.Show("تم اضافة فاتورة جديد");
                                btnFindInv_Click(sender, e);
                                textIdInvoice.Text = "";
                                textIdCU.Text = "";
                                checkPaid.Checked = checkUnPaid.Checked = false;
                                textCountPro.Text = "";
                                textIdProd.Text = "";
                                textValuePro.Text = "";
                                textRest.Text = "";
                                Account = "";
                                textIdInvoice.Focus();

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
                    
                    connectionPr = new SqlConnection(cnProt);
                    string qur = @"select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID,REST_INV , INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV
                    INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO
                    WHERE ID_INVOICE ='" + textIdInvoice.Text + "'";
                    connectionPr.Close();
                    SqlCommand connect = new SqlCommand(qur, connectionPr);
                    connectionPr.Open();
                    SqlDataReader sqlDataReader = connect.ExecuteReader();

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
                        byte[] svImg = (byte[])sqlDataReader[15];
                        MemoryStream MemoreImgPro = new MemoryStream(svImg);
                        picImgPro.Image = Image.FromStream(MemoreImgPro);
                        textFind.Visible = label_VI_IN.Visible = true;
                        Fond = true;
                    
                    }
                   if(!Fond)
                   {
                        MessageBox.Show("لايوجد بيانات لهاذا id");
                        textIdInvoice.Focus();
                        return;
                   }
   
                        connectionPr.Close();
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
                        Data_Inv = new
                        {
                            ID_Inv = textIdInvoice.Text,
                            ID_Cu = textIdCU.Text,
                            ID_Pro = textIdProd.Text,
                            Count = textCountPro.Text,
                            Date_Time = dateInvoice.Value.ToShortDateString(),
                            Total = total.ToString(),
                            VALUE_PAID = textValuePro.Text,
                            Rest = rest.ToString(),
                            Accounto = Account,
                            Amend = true
                        };
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
                                    InvoiceClass.amendInvoice(ref Data_Inv);

                                    MessageBox.Show("تمت المعلية بنجاح");
                                    btnFindInv_Click(sender, e);
                                    textIdInvoice.Text = "";
                                    textIdCU.Text = "";
                                    textCountPro.Text = "";
                                    textIdProd.Text = "";
                                    textValuePro.Text = "";
                                    textRest.Text = "";

                                    //Account = "";
                                    btnAmendInv.Enabled = false;
                                    checkPaid.Checked = checkUnPaid.Checked = false;
                                    textIdInvoice.Focus();
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
                            InvoiceClass.findInvoice(textIdInvoice.Text, textIdProd.Text, (int.Parse(textCountPro.Text)),true, true);
                        }
                        InvoiceClass.deleteInvoice(textIdInvoice.Text);
                        picImgPro.Image = null;
                        textFind.Text = "";
                        textIdInvoice.Text = "";
                        textIdCU.Text = "";
                        textCountPro.Text = "";
                        textIdProd.Text = "";
                        textValuePro.Text = "";
                        textRest.Text = "";
                        Account = "";
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
          

                if (textCountPro.Text != "")
                {
                    if (InvoiceClass.findProduct(textIdProd.Text, out object Data_Pro))
                    {
                        total = (int.Parse(textCountPro.Text)) * int.Parse(((dynamic)Data_Pro).PriceBay);
                        textTotal.Text = total.ToString();
                        textValuePro_TextChanged(sender, e);


                        textTotal.Visible = labelTotal.Visible = true;
                    }

                }
                else
                {
                    textTotal.Visible = labelTotal.Visible = false;
                }

           
        
            
        }

        private void textIdProd_TextChanged(object sender, EventArgs e)
        {
            if (textIdProd.Text != "" && textIdProd.Focus())
            {
                if (InvoiceClass.findProduct(textIdProd.Text, out object Data_Product))
                {

                    textCount.Text = ((dynamic)Data_Product).Cont;


                    textCount.Visible = labelCount.Visible = true;
                }
            }
            else
            {
                textCount.Visible = labelCount.Visible = false;
            }
                   
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
            this.Size = new Size(766, 459);
        }

        private void FormInvoice_Move(object sender, EventArgs e)
        {
            this.Size = new Size(766, 459);
        }

        private void textIdInvoice_TextChanged(object sender, EventArgs e)
        {
         
            if (textIdInvoice.Text != ""&&btnAddInv.Visible)
            {
                labelNotA.Visible = false;
                labelA.Visible = false;
                connectionPr = new SqlConnection(cnProt);
                string qur = @"select * from INVOICE 
                WHERE ID_INVOICE ='" + textIdInvoice.Text + "'";
                connectionPr.Close();
                connectionPr.Open();
                SqlCommand connect = new SqlCommand(qur, connectionPr);
                SqlDataReader sqlDataReader = connect.ExecuteReader();
                ren = false;
                while (sqlDataReader.Read())
                {
                    ren = true;
                    break;
                }
                connectionPr.Close();
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

      
    }
}

using CustomerandBillingManagementProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerandBillingManagementProgram
{
     partial class FormProduct : Form
     {
        TheProductClass productClass = new TheProductClass();
        MemoryStream memory = new MemoryStream();
        string Afind = "";
        int Timer = 0;

        public FormProduct()
        {
            InitializeComponent();
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            textIdPro.Focus();
            picImgPro.BorderStyle = BorderStyle.FixedSingle;
            picImgPro.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddPro.Visible = TheBaseClass.Add_bool;
            btnFindPro.Visible =  TheBaseClass.Fond_bool;
            btnDeletePro.Visible = TheBaseClass.Delete_bool;
            btnAmendPro.Visible = TheBaseClass.Amend_bool;
            btnAddImgPro.Visible = TheBaseClass.Add_bool;
           
            //
            btnAmendPro.Enabled = btnDeletePro.Enabled = false;
            //
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (textIdPro.Text != "" && textTyprPro.Text != "" && textNamePro.Text != "" && textNamePro.Text != "" && textNameBra.Text != "" && textCountPro.Text != "" && textPriceBuy.Text != "" && textPriceBay.Text != "" )
                {

                    if (picImgPro.Image!=null)
                    {
                        memory = new MemoryStream();
                        picImgPro.Image.Save(memory, picImgPro.Image.RawFormat);
                    }
                    if (productClass.addNewProduct(textIdPro.Text, textTyprPro.Text, textNamePro.Text, textNameBra.Text, textCountPro.Text, textPriceBuy.Text, textPriceBay.Text, memory.ToArray()))
                    {
                        MessageBox.Show("ال id مستخدم من قبل");
                        textIdPro.Focus();
                         textIdPro.SelectAll();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("تم اضافة منتج جديد");
                        Null_Text();
                        textTyprPro.Items.Add("m");
                        textIdPro.Focus();
                       
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

        private void btnFindPro_Click(object sender, EventArgs e)
        {
          
            try
            {


                if (textIdPro.Text != "")
                {
                    if (!productClass.findProduct(textIdPro.Text))
                    {
                        MessageBox.Show("لايوجد بيانات لهاذا id");
                        textIdPro.Focus();
                        return;
                    }
                    textTyprPro.Text = TheBaseClass.Model[2].ToString();
                    textNamePro.Text = TheBaseClass.Model[3].ToString();
                    textNameBra.Text = TheBaseClass.Model[4].ToString();
                    textCountPro.Text = TheBaseClass.Model[5].ToString();
                    textPriceBuy.Text = TheBaseClass.Model[6].ToString();
                    textPriceBay.Text = TheBaseClass.Model[7].ToString();
                    byte[] svImg = (byte[])TheBaseClass.Model[8];
                    if (svImg.Length!=0)
                    {
                        memory = new MemoryStream(svImg);
                        picImgPro.Image = Image.FromStream(memory);
                    }
                   
                    Afind = textIdPro.Text;
                    btnAddImgPro.Visible = btnAmendPro.Visible;
                    if (picImgPro.Image!=null)
                    {
                        btnRemoval.Visible= btnAmendPro.Visible;
                    }
                    btnAmendPro.Enabled = btnDeletePro.Enabled = true;
                
                }
                else
                {
                    MessageBox.Show("الرجاء ادخال id");
                    textIdPro.Focus();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "!!");
            }
        }

        private void btnAmendPro_Click(object sender, EventArgs e)
        {
             memory = new MemoryStream();
            try
            {

                if (textIdPro.Text != "" && textTyprPro.Text != "" && textNamePro.Text != "" && textNameBra.Text != "" && textCountPro.Text != "" && textPriceBuy.Text != "" && textPriceBay.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("هل انت متاكد من هذه العملية", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Afind == textIdPro.Text)
                        {
                            if (picImgPro.Image != null)
                            {
                                memory = new MemoryStream();
                                picImgPro.Image.Save(memory, picImgPro.Image.RawFormat);
                            }
                            productClass.amendProduct(textIdPro.Text, textTyprPro.Text, textNamePro.Text, textNameBra.Text, textCountPro.Text, textPriceBuy.Text, textPriceBay.Text, memory.ToArray());
                            Null_Text();
                            textIdPro.Focus();
                            btnAddImgPro.Visible = false;
                            btnAmendPro.Enabled = false;
                            MessageBox.Show("تمت المعلية بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("عذرا تم الغاء المعلية لقد قمت بتغير الId ");
                            return;
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

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            TheProductClass productClass = new TheProductClass();
            try
            {

                DialogResult dialogResult = MessageBox.Show("سوف يتم حذف الفاتورة المتعلقة بهاذا المنتج هل انت متاكد من هذه العملية!!", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Afind == textIdPro.Text)
                    {
                        productClass.deletProduct(textIdPro.Text);
                        Null_Text();
                        btnDeletePro.Enabled = false;
                        MessageBox.Show("تمت المعلية بنجاح");

                    }
                    else
                    {
                        MessageBox.Show("عذرا لقد قمت بتغير الId ");
                        return;
                    } 
                }
                else
                {
                    MessageBox.Show("تمت الغاء المعلية بنجاح");
                    return;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                throw;
            }
        }
        private void Null_Text()
        {
            textIdPro.Text = "";
            textTyprPro.Text = "";
            textNamePro.Text = "";
            textNameBra.Text = "";
            textCountPro.Text = "";
            textPriceBuy.Text = "";
            textPriceBay.Text = "";
            picImgPro.Image = null;
        }

        private void ExitPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImgPro_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "imges|*.jpg;*png;*.jpeg;*.gif;*bmp;";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picImgPro.Image = Image.FromFile(fileDialog.FileName);
                
            }
            if (picImgPro.Image!=null)
            {
                btnRemoval.Visible = true;
            }
        }
        private void textIdPro_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textPriceBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPriceBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormProduct_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(750, 445);
        }

        private void FormProduct_Move(object sender, EventArgs e)
        {
            this.Size = new Size(750, 445);
        }

        private void textIdPro_TextChanged(object sender, EventArgs e)
        {
            if (textIdPro.Text != ""&&btnAddPro.Visible)
            {
               
                labelNotA.Visible = false;
                labelA.Visible = false;
 
               
                if (productClass.findProduct(textIdPro.Text))
                {
                    labelA.Visible = true;
                    labelNotA.Visible = false;
                }
                else
                {
                    labelA.Visible = false;
                    labelNotA.Visible = true;
                }
              
                timerIdPro.Enabled = true;
                
            }
        }

        private void textIdPro_Leave(object sender, EventArgs e)
        {
            labelA.Visible = false;
            labelNotA.Visible = false;
            
        }
       
        private void timerIdPro_Tick(object sender, EventArgs e)
        {
            
            if (Timer==25)
            {
                Timer = 0;
                timerIdPro.Enabled = false;
                labelA.Visible = false;
                labelNotA.Visible = false;
                return;
            }
            ++Timer;
        }

        private void btnRemoval_Click(object sender, EventArgs e)
        {
            picImgPro.Image = null;
            btnRemoval.Visible = false;
        }
    }
}

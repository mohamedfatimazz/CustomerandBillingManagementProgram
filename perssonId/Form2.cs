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

namespace perssonId
{
     partial class FormProduct : Form
     {
        TheProductClass productClass = new TheProductClass();
        MemoryStream memory = new MemoryStream();
        bool imga = false;
        string Afind = "";
        object Data_Pro;
       
        public FormProduct()
        {
           
            InitializeComponent();
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            textIdPro.Focus();
            picImgPro.BorderStyle = BorderStyle.FixedSingle;
            picImgPro.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddPro.Visible = TheCustmerClass.newAd;
            btnFindPro.Visible = TheCustmerClass.Fd;
            btnDeletePro.Visible = TheCustmerClass.Dt;
            btnAmendPro.Visible = TheCustmerClass.AdS;
            btnAddImgPro.Visible = TheCustmerClass.newAd;
            this.BackColor=FormShwo.DefaultBackColor;
            //
            btnAmendPro.Enabled = btnDeletePro.Enabled = false;
            //
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (textIdPro.Text != "" && textTyprPro.Text != "" && textNamePro.Text != "" && textNamePro.Text != "" && textNameBra.Text != "" && textCountPro.Text != "" && textPriceBuy.Text != "" && textPriceBay.Text != "" && imga)
                {

                    if (imga)
                    {
                        picImgPro.Image.Save(memory, picImgPro.Image.RawFormat);
                    }
                    Data_Pro = new 
                    {
                        ID = textIdPro.Text,
                        Typepro = textTyprPro.Text,
                        Name = textNamePro.Text,
                        NameBr = textNameBra.Text,
                        Cont = textCountPro.Text,
                        PriceBuy = textPriceBuy.Text,
                        PriceBay = textPriceBay.Text,
                        Pic = memory 
                    };
                    if (productClass.addNewProduct(ref Data_Pro))
                    {
                        MessageBox.Show("ال id مستخدم من قبل");

                        textIdPro.Focus();
                         textIdPro.SelectAll();
                        return;
                    }
                    else
                    {
                       

                        MessageBox.Show("تم اضافة منتج جديد");
                        textIdPro.Text = "";
                        textTyprPro.Text = "";
                        textNamePro.Text = "";
                        textNameBra.Text = "";
                        textCountPro.Text = "";
                        textPriceBuy.Text = "";
                        textPriceBay.Text = "";
                        textTyprPro.Items.Add("m");
                        textIdPro.Focus();
                        picImgPro.Image = null;
                        imga = false;
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
                    if (!productClass.findProduct(textIdPro.Text, out Data_Pro))
                    {
                        MessageBox.Show("لايوجد بيانات لهاذا id");
                        textIdPro.Focus();
                        return;
                    }

                    textTyprPro.Text = ((dynamic)Data_Pro).Typepro;
                    textNamePro.Text = ((dynamic)Data_Pro).Name;
                    textNameBra.Text = ((dynamic)Data_Pro).NameBr;
                    textCountPro.Text = ((dynamic)Data_Pro).Cont;
                    textPriceBuy.Text = ((dynamic)Data_Pro).PriceBuy;
                    textPriceBay.Text = ((dynamic)Data_Pro).PriceBay;
                    byte[] svImg = (byte[])((dynamic)Data_Pro).Pic;
                    memory = new MemoryStream(svImg);
                    picImgPro.Image = Image.FromStream(memory);
                    Afind = textIdPro.Text;
                    btnAddImgPro.Visible = btnAmendPro.Visible;
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
                            picImgPro.Image.Save(memory, picImgPro.Image.RawFormat);
                            Data_Pro = new
                            {

                                ID = textIdPro.Text,
                                Typepro = textTyprPro.Text,
                                Name = textNamePro.Text,
                                NameBr = textNameBra.Text,
                                Cont = textCountPro.Text,
                                PriceBuy = textPriceBuy.Text,
                                PriceBay = textPriceBay.Text,
                                Pic = memory
                            };
                            productClass.amendProduct(ref Data_Pro);
                            textIdPro.Text = "";
                            textTyprPro.Text = "";
                            textNamePro.Text = "";
                            textNameBra.Text = "";
                            textCountPro.Text = "";
                            textPriceBuy.Text = "";
                            textPriceBay.Text = "";
                            textIdPro.Focus();
                            picImgPro.Image = null;
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

                DialogResult dialogResult = MessageBox.Show("سوف يتم حذف الفاتورة المتعلقة بهاذا المنتج هل انت متاكد من هذه العملية!!", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Afind == textIdPro.Text)
                    {
                        productClass.deletProduct(textIdPro.Text);
                        picImgPro.Image = null;
                        textTyprPro.Text = "";
                        textNamePro.Text = "";
                        textNameBra.Text = "";
                        textPriceBuy.Text = "";
                        textPriceBay.Text = "";
                        textCountPro.Text = "";
                        btnDeletePro.Enabled = false;
                        textIdPro.Text = "";
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
                imga = true;
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
 
               
                if (productClass.findProduct(textIdPro.Text,out Data_Pro))
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
        int i = 0;
        private void timerIdPro_Tick(object sender, EventArgs e)
        {
            if (i==25)
            {
                timerIdPro.Enabled = false;
                labelA.Visible = false;
                labelNotA.Visible = false;
            }
            ++i;
        }

      
    }
}

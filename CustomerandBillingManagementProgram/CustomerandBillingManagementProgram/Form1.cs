using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace CustomerandBillingManagementProgram
{

    public partial class FormCustmer : Form
    {
        TheCustmerClass Class_Cu = new TheCustmerClass();
        MemoryStream memory = new MemoryStream();
        string typeVa = "",Afind="";
        public FormCustmer()
        { 
            InitializeComponent();
        }
        private void FormCustmer_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(750, 445);
        }
        private void textId_Cu_Leave(object sender, EventArgs e)
        {
            labelA.Visible = false;
            labelNotA.Visible = false;
        }
        private void FormCustmer_Move(object sender, EventArgs e)
        {
            this.Size = new Size(750, 445);
        }
        private void FromCustmer_Load(object sender, EventArgs e)
        {
            textId_Cu.Focus();
            picAddImg.BorderStyle = BorderStyle.FixedSingle;
            picAddImg.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddCustmer.Visible = TheBaseClass.Add_bool;
            btnFindCustmer.Visible = TheBaseClass.Fond_bool;
            btnDeleteCustmer.Visible = TheBaseClass.Delete_bool;
            btnAmendCustmer.Visible = TheBaseClass.Amend_bool;
            btnAddImgCustmer.Visible = TheBaseClass.Add_bool; 
            btnAmendCustmer.Enabled = btnDeleteCustmer.Enabled = false;

            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);//
        }
        private void ExitPersson_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        public  void btnAddCustmer_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (textId_Cu.Text != "" && textNamePersson.Text != "" && textPhone.Text != "" && textAddres.Text != "" &&  typeVa != "")
                {
                    if (picAddImg.Image!=null)
                    {
                        memory = new MemoryStream();
                        picAddImg.Image.Save(memory, picAddImg.Image.RawFormat);
                    }
                    if (Class_Cu.addNewCustmer(textId_Cu.Text, textNamePersson.Text, textPhone.Text,textAddres.Text
                        , datePr.Value.ToLongDateString(), typeVa, memory.ToArray()))
                    {

                        MessageBox.Show("ال id مستخدم من قبل");

                        textId_Cu.Focus();
                        textId_Cu.SelectAll();
                        return;
                    }
                    else
                    {
           
                        MessageBox.Show("تم اضافةاسم جديد");
                        Text_Value_Null();
                        
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

        private void btnFindCustmer_Click(object sender, EventArgs e)
        {
           
            try
            {   
                if (textId_Cu.Text != "")
                {
                    if (Class_Cu.FondCustmer(textId_Cu.Text))
                    {
                        Afind = textId_Cu.Text;
                        textNamePersson.Text = TheBaseClass.Model[2].ToString();
                        textPhone.Text = TheBaseClass.Model[3].ToString();
                        textAddres.Text = TheBaseClass.Model[4].ToString();
                        datePr.Text = TheBaseClass.Model[5].ToString();
                        typeVa = TheBaseClass.Model[6].ToString();
                        byte[] img = (byte[]) TheBaseClass.Model[7];
                        if (img.Length!=0)
                        {
                            memory = new MemoryStream(img);
                            picAddImg.Image = Image.FromStream(memory);
                        }
                        if (typeVa == "Male")
                        {
                            checkBoxMale.Checked = true;
                        }
                        else if (typeVa == "Female")
                        {
                            checkBoxFemale.Checked = true;
                        }
                        btnAddImgCustmer.Visible = btnAmendCustmer.Visible;
                        if (picAddImg.Image!=null)
                        {
                            btnRemoval.Visible= btnAmendCustmer.Visible;
                        }
                        btnAmendCustmer.Enabled = btnDeleteCustmer.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("لايوجد بيانات لهاذا id");
                        textId_Cu.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء ادخال id");
                    textId_Cu.Focus();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "!!");
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked)
            {
                typeVa = "Male";
                checkBoxFemale.Checked = false;
            }
           
        }
        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked)
            {
                typeVa = "Female";
                checkBoxMale.Checked = false;
            } 
        }

        private void btnDeleteCustmer_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("هل انت متاكد من هذه العملية", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    if (Afind == textId_Cu.Text)
                    {

                        Class_Cu.deletCustmer(textId_Cu.Text);
                        Text_Value_Null();
                        MessageBox.Show("تمت المعلية بنجاح");
                        btnDeleteCustmer.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("عذرا  تم الغاء المعلية  لقد قمت بتغير الId ");
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

        private void btnAmendCustmer_Click(object sender, EventArgs e)
        {

            try
            {
                btnAddImgCustmer.Visible = true;
                if (textId_Cu.Text != "" && textNamePersson.Text != "" && textPhone.Text != "" && textAddres.Text != "" && checkBoxMale.Checked != false || checkBoxFemale.Checked != false)
                {
                    DialogResult dialogResult = MessageBox.Show("هل انت متاكد من هذه العملية", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Afind == textId_Cu.Text)
                        {
                            if (picAddImg.Image!=null)
                            {
                                memory = new MemoryStream();
                                picAddImg.Image.Save(memory, picAddImg.Image.RawFormat);
                            }
                            
                            Class_Cu.amendCustmer(textId_Cu.Text, textNamePersson.Text, textPhone.Text, textAddres.Text
                        , datePr.Value.ToLongDateString(), typeVa, memory.ToArray());
                            Text_Value_Null();
                            MessageBox.Show("تمت المعلية بنجاح");
                            btnAmendCustmer.Enabled = btnAddImgCustmer.Visible = false;
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
        private void btnAddImgCustmer_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "imges|*.jpg;*png;*.jpeg;*.gif;*bmp;";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                picAddImg.Image = Image.FromFile(fileDialog.FileName);
               
            }
            if (picAddImg.Image!=null)
            {
                btnRemoval.Visible = true;
            }
        }
        private void textId_Cu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textId_Cu_TextChanged(object sender, EventArgs e)
        {
            if (textId_Cu.Text != ""&&btnAddCustmer.Visible)
            {
                labelNotA.Visible = false;
                labelA.Visible = false;
                if (Class_Cu.FondCustmer(textId_Cu.Text))
                {
                    labelA.Visible = true;
                    labelNotA.Visible = false;
                    timer1.Enabled = true;
                }
                else
                {
                    labelA.Visible = false;
                    labelNotA.Visible = true;
                    timer1.Enabled = true;
                }
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i==25)
            {
                i = 0;
                labelA.Visible = false;
                labelNotA.Visible = false;
                return;
            }
            i++;
        }

        private void btnRemoval_Click(object sender, EventArgs e)
        {
            picAddImg.Image = null;
            btnRemoval.Visible = false;
        }

        private void Text_Value_Null()
        {
            textId_Cu.Text = "";
            textNamePersson.Text = "";
            textAddres.Text = "";
            datePr.Text = "";
            checkBoxMale.Checked = checkBoxFemale.Checked = false;
            textPhone.Text = "";
            picAddImg.Image = null;
        }
      
    }
}

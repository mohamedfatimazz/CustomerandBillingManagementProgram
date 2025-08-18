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
        object Data_Cu;
        bool imga = false;
        MemoryStream memory = new MemoryStream();
        string typeVa = "",Afind="";
     
        public FormCustmer()
        {
            
            InitializeComponent();
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

                if (textId_Cu.Text != "" && textNamePersson.Text != "" && textPhone.Text != "" && textPhone.Text != "" && textAddres.Text != "" &&  typeVa != "")
                {

                    memory = new MemoryStream();
                    if (imga)
                    {
                        picAddImg.Image.Save(memory, picAddImg.Image.RawFormat);
                    }
                    Data_Cu=new{ID=textId_Cu.Text,
                        Name=textNamePersson.Text,
                    PHONE=textPhone.Text,
                    ADRES=textAddres.Text,
                    DATAPERTH=datePr.Value.ToLongDateString(),
                    TYPE=typeVa,
                    PIC=memory};
                   
                    if (Class_Cu.addNewCustmer(ref Data_Cu))
                    {

                        MessageBox.Show("ال id مستخدم من قبل");

                        textId_Cu.Focus();
                        textId_Cu.SelectAll();
                        return;
                    }
                    else
                    {
           
                        MessageBox.Show("تم اضافةاسم جديد");
                        textId_Cu.Text = "";
                        textNamePersson.Text = "";
                        textAddres.Text = "";
                        datePr.Text = "";
                        checkBoxMale.Checked = checkBoxFemale.Checked = false;
                        textPhone.Text = "";
                        textId_Cu.Focus();
                        picAddImg.Image = null;
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

        private void btnFindCustmer_Click(object sender, EventArgs e)
        {
           
            try
            {
                
               
                
                if (textId_Cu.Text != "")
                {
                    if (Class_Cu.findCustmer(textId_Cu.Text, out object find))
                    {   
                        Afind = textId_Cu.Text;
                        textNamePersson.Text = ((dynamic)find).name;
                        textPhone.Text = ((dynamic)find).phone;
                        textAddres.Text = ((dynamic)find).adres;
                        datePr.Text = ((dynamic)find).Date;
                        typeVa = ((dynamic)find).type;
                        byte[] img = (byte[])((dynamic)find).pic;
                        memory = new MemoryStream(img);
                        picAddImg.Image = Image.FromStream(memory);
                        if (typeVa == "male")
                        {
                            checkBoxMale.Checked = true;
                        }
                        else if (typeVa == "female")
                        {
                            checkBoxFemale.Checked = true;
                        }
                        btnAddImgCustmer.Visible = btnAmendCustmer.Visible;
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
                        picAddImg.Image = null;
                        textNamePersson.Text = "";
                        textAddres.Text = "";
                        datePr.Text = "";
                        checkBoxMale.Checked = checkBoxFemale.Checked = false;
                        textPhone.Text = "";
                        textId_Cu.Text = "";
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

                    if (textId_Cu.Text != "" &&textNamePersson.Text!=""&& textPhone.Text != "" && textAddres.Text!="" && checkBoxMale.Checked !=false|| checkBoxFemale.Checked != false)
                    { 
                        DialogResult dialogResult = MessageBox.Show("هل انت متاكد من هذه العملية", "رسالة تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Afind == textId_Cu.Text)
                        {
                            memory = new MemoryStream();
                            picAddImg.Image.Save(memory, picAddImg.Image.RawFormat);
                            Data_Cu = new
                            {
                                ID = textId_Cu.Text,
                                Name = textNamePersson.Text,
                                PHONE = textPhone.Text,
                                ADRES = textAddres.Text,
                                DATAPERTH = datePr.Value.ToLongDateString(),
                                TYPE = typeVa,
                                PIC = memory
                            };
                            Class_Cu.amendCustmer(ref Data_Cu);
                            textId_Cu.Text = "";
                            textNamePersson.Text = "";
                            textAddres.Text = "";
                            datePr.Text = "";
                            checkBoxMale.Checked = checkBoxFemale.Checked = false;
                            textPhone.Text = "";
                            picAddImg.Image = null;
                            MessageBox.Show("تمت المعلية بنجاح");
                            btnAmendCustmer.Enabled=btnAddImgCustmer.Visible = false;
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
                imga = true;
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

        private void FormCustmer_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(750, 445);
        }

        private void textId_Cu_TextChanged(object sender, EventArgs e)
        {
            if (textId_Cu.Text != ""&&btnAddCustmer.Visible)
            {
                labelNotA.Visible = false;
                labelA.Visible = false;
                if (Class_Cu.findCustmer(textId_Cu.Text,out Data_Cu))
                {
                    labelA.Visible = true;
                    labelNotA.Visible = false;
                }
                else
                {
                    labelA.Visible = false;
                    labelNotA.Visible = true;
                }


             
            }
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
    }
}

using CustomerandBillingManagementProgram;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CustomerandBillingManagementProgram
{
    sealed class TheInvoiceClass : TheProductClass
    {

        public bool Find1 = false;
        int CONUT = 0;

        SqlDataReader sqlDataReader;
        SqlConnection connectionPr;
        public bool addNewInvoice(string Id_IVC, string Id_CTR, string Id_PDT, string Count, string Pirc,string total, string Value_Paid, string Rest, string Account)
        {
            TheBaseClass.Add_Value_List(Id_IVC, Id_CTR, Id_PDT, Count, Pirc,total, Value_Paid, Rest, Account);
            return Conactn_Qure_Class.Add_New_Value_Database_IVC( Conactn_Qure_Class.Qure_Insert_IVC, true);
        }
        public bool Find_Id_Custmer(string ID_Cu)
        {

            if (FondCustmer(ID_Cu))
            {
                return false;
            }

            return true;
        }
        public bool Find_Id_Product(string ID_Product, int CONUTPr, bool A_Metod)
        {

            if (findProduct(ID_Product))
            {

                if (A_Metod)
                {

                    if (int.Parse(TheBaseClass.Model[5].ToString()) >= CONUTPr)
                    {
                        CONUT = int.Parse(TheBaseClass.Model[5].ToString()) - CONUTPr;
                        setProduct(CONUT, ID_Product);
                        Find1 = true;
                    }



                }
                Conactn_Qure_Class.SqlConnection_Close();
                return false;
            }


            connectionPr.Close();
            return true;
        }
        public bool findInvoice(string Id_Invoic, string Id_Product, int Count_New, bool invOk, bool Ren)
        {
            //;
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Select_Invoice + "\t\n WHERE ID_INVOICE ='" + Id_Invoic + "'");
            //SqlCommand connect = new SqlCommand(, connectionPr);

            SqlDataReader sqlDataReader =Conactn_Qure_Class.connect.ExecuteReader();
            Find1 = false;
            while (sqlDataReader.Read())
            {

                if (Id_Product == sqlDataReader[0].ToString() && invOk)
                {
                    if (Count_New > int.Parse(sqlDataReader[1].ToString()))
                    {

                        if (CONUT <= int.Parse(sqlDataReader[2].ToString()))
                        {
                            CONUT = (Count_New - int.Parse(sqlDataReader[1].ToString())) - int.Parse(sqlDataReader[2].ToString());
                            setProduct(CONUT, sqlDataReader[0].ToString());
                            Find1 = true;
                        }

                    }
                    else if (Count_New < int.Parse(sqlDataReader[1].ToString()))
                    {


                        CONUT = (int.Parse(sqlDataReader[1].ToString()) - Count_New) + int.Parse(sqlDataReader[2].ToString());

                        setProduct(CONUT, sqlDataReader[0].ToString());
                        Find1 = true;


                    }
                    if (Ren)
                    {
                        CONUT = (int.Parse(sqlDataReader[1].ToString())) + (int.Parse(sqlDataReader[2].ToString()));
                        setProduct(CONUT, sqlDataReader[0].ToString());
                    }
                }
                else if (invOk)
                {


                    CONUT = int.Parse(sqlDataReader[1].ToString()) + int.Parse(sqlDataReader[2].ToString());
                    setProduct(CONUT, sqlDataReader[0].ToString());
                    Find_Id_Product(Id_Product.ToString(), Count_New, true);
                }

                Conactn_Qure_Class.SqlConnection_Close();
                return true;
            }

            Conactn_Qure_Class.SqlConnection_Close();
            return false;

        }
        public void setProduct(int Count, string idProduct)
        {//
           
            string qur1 = @"UPDATE PRODUCT
                            SET COUNT_PRO = @COUNT_PRO
                            WHERE ID_PRO = '" + idProduct + "'";

            SqlCommand connect = new SqlCommand(qur1, connectionPr);
            connect.Parameters.AddWithValue("@COUNT_PRO", Count);
            connect.ExecuteNonQuery();
            connectionPr.Close();

        }
        public void amendInvoice(string Id_IVC, string Id_CTR, string Id_PDT, string Count, string Pirc,string total, string Value_Paid, string Rest, string Account)
        {
            TheBaseClass.Add_Value_List(Id_IVC, Id_CTR, Id_PDT, Count, Pirc,total, Value_Paid, Rest, Account);
            Conactn_Qure_Class.Add_New_Value_Database_IVC(Conactn_Qure_Class.Quer_UpDate_IVC + "\t\n WHERE ID_INVOICE = '" + Id_IVC + "';", false);
        }
        public void deleteInvoice(string id)
        {
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Delete_IVC + " WHERE ID_INVOICE ='" + id + "';");
        }
    }
}

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

namespace perssonId
{
    sealed class TheInvoiceClass:TheProductClass
    {

        public bool Find1 = false;
        int CONUT = 0;
         
        //SqlDataReader sqlDataReader;
       
        public bool addNewInvoice(ref object Data_Inv)
        {

            //connectionPr = new SqlConnection(cnProt);
            

            string qure = @"INSERT INTO INVOICE VALUES (@GUID_INV, @ID_INVOICE , @ID_CUSTMER ,@ID_PRODUCT,@COUNT_PRO , @DATA_INV,@PIRC_INV,@VALUE_PAID ,@REST_INV, @ACCOUNT )";
            openServar(out SqlConnection connectionPr);
            SqlCommand connect = new SqlCommand(qure, connectionPr);
            connect.Parameters.AddWithValue("@GUID_INV", Guid.NewGuid());
            connect.Parameters.AddWithValue("@ID_INVOICE", ((dynamic)Data_Inv).ID_Inv);
            connect.Parameters.AddWithValue("@ID_CUSTMER", ((dynamic)Data_Inv).ID_Cu);
            connect.Parameters.AddWithValue("@ID_PRODUCT", ((dynamic)Data_Inv).ID_Pro);
            connect.Parameters.AddWithValue("@COUNT_PRO", ((dynamic)Data_Inv).Count);
            connect.Parameters.AddWithValue("@DATA_INV", ((dynamic)Data_Inv).Date_Time);
            connect.Parameters.AddWithValue("@PIRC_INV", ((dynamic)Data_Inv).Total);
            connect.Parameters.AddWithValue("@VALUE_PAID", ((dynamic)Data_Inv).VALUE_PAID);
            connect.Parameters.AddWithValue("@REST_INV", ((dynamic)Data_Inv).Rest);
            connect.Parameters.AddWithValue("@ACCOUNT", ((dynamic)Data_Inv).Accounto);


            connect.ExecuteNonQuery();
            connectionPr.Close();
            return false;
        }
        public bool Find_Id_Custmer(string ID_Cu)
        {

            if (findCustmer(ID_Cu, out object Data_Inv))
            {
                return false;
            }
            
            return true;
        }
        public bool Find_Id_Product(string ID_Product, int CONUTPr, bool A_Metod)
        {
           
            if (findProduct(ID_Product,out object Data_inv))
            {

                if (A_Metod)
                {

                    if (int.Parse(((dynamic)Data_inv).Cont) >= CONUTPr)
                    {
                        CONUT = int.Parse(((dynamic)Data_inv).Cont) - CONUTPr;
                        setProduct(CONUT, ID_Product);
                        Find1 = true;
                    }



                }
                connectionPr.Close();
                return false;
            }


            connectionPr.Close();
            return true;
        } 
        public bool findInvoice(string Id_Invoic,string Id_Product,int Count_New,bool invOk,bool Ren)
        {

           
            string qur = @"select INV.ID_PRODUCT ,INV.COUNT_PRO ,PO.COUNT_PRO ,PO.PRICEBAY_PRO  from INVOICE AS INV
            INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU
            INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO
            WHERE ID_INVOICE ='" + Id_Invoic + "'";
            openServar(out SqlConnection connectionPr);
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            SqlDataReader sqlDataReader = connect.ExecuteReader();
            Find1 = false;
            while (sqlDataReader.Read())
            {
               
                if (Id_Product == sqlDataReader[0].ToString()&&invOk)
                {
                    if (Count_New  > int.Parse(sqlDataReader[1].ToString()))
                    {
                       
                        if (CONUT<=int.Parse(sqlDataReader[2].ToString()))
                        {
                            CONUT = (Count_New - int.Parse(sqlDataReader[1].ToString())) - int.Parse(sqlDataReader[2].ToString());
                            setProduct(CONUT, sqlDataReader[0].ToString());
                            Find1 = true;
                        }
 
                    }
                    else if (Count_New < int.Parse(sqlDataReader[1].ToString()))
                    {                    
                       
                      
                        CONUT = (int.Parse(sqlDataReader[1].ToString())- Count_New)+ int.Parse(sqlDataReader[2].ToString());
                        
                        setProduct(CONUT, sqlDataReader[0].ToString());
                        Find1 = true;
                       
                       
                    }
                    if (Ren)
                    {
                        CONUT = (int.Parse(sqlDataReader[1].ToString())) + (int.Parse(sqlDataReader[2].ToString()));
                        setProduct(CONUT, sqlDataReader[0].ToString());
                    }
                }
                else if(invOk)
                {
                   

                    CONUT = int.Parse(sqlDataReader[1].ToString())+ int.Parse(sqlDataReader[2].ToString());
                    setProduct(CONUT, sqlDataReader[0].ToString());
                    Find_Id_Product(Id_Product.ToString(), Count_New, true);
                }
               
                connectionPr.Close();
                return true;
                }

            connectionPr.Close();
            return false;

        }
        public void setProduct(int Count,string idProduct)
        {
            openServar(out SqlConnection connectionPr);
            string qur1 = @"UPDATE PRODUCT
                        SET COUNT_PRO = @COUNT_PRO
                        WHERE ID_PRO = '" + idProduct + "'";

            SqlCommand connect = new SqlCommand(qur1, connectionPr);
            connect.Parameters.AddWithValue("@COUNT_PRO", Count);
            connect.ExecuteNonQuery();
            connectionPr.Close();
            
        }
        public void amendInvoice(ref object Data_Inv)
        {
            
            openServar(out SqlConnection connectionPr);
            string qur = @"UPDATE INVOICE
             SET ID_CUSTMER = @ID_CUSTMER,ID_PRODUCT=@ID_PRODUCT,COUNT_PRO=@COUNT_PRO, DATA_INV = @DATA_INV,TOTAL_INV=@TOTAL_INV,VALUE_PAID=@VALUE_PAID,REST_INV=@REST_INV, ACCONT = @ACCONT
             WHERE ID_INVOICE = '" + ((dynamic)Data_Inv).ID_Inv + "'";

            SqlCommand connect = new SqlCommand(qur, connectionPr);

            connect.Parameters.AddWithValue("@ID_CUSTMER", ((dynamic)Data_Inv).ID_Cu);
            connect.Parameters.AddWithValue("@ID_PRODUCT",((dynamic)Data_Inv).ID_Pro);
            connect.Parameters.AddWithValue("@COUNT_PRO", ((dynamic)Data_Inv).Count);
            connect.Parameters.AddWithValue("@DATA_INV", ((dynamic)Data_Inv).Date_Time);
            connect.Parameters.AddWithValue("@TOTAL_INV", ((dynamic)Data_Inv).Total);
            connect.Parameters.AddWithValue("@VALUE_PAID",((dynamic)Data_Inv).VALUE_PAID);
            connect.Parameters.AddWithValue("@REST_INV",((dynamic)Data_Inv).Rest);
            connect.Parameters.AddWithValue("@ACCONT", ((dynamic)Data_Inv).Accounto);

            connect.ExecuteNonQuery();
            connectionPr.Close();
        }
        public void deleteInvoice(string id)
        {


            openServar(out SqlConnection connectionPr);
            string qur = @"DELETE FROM INVOICE 
                          WHERE ID_INVOICE ='" + id + "'";
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            connect.ExecuteNonQuery();

            connectionPr.Close();

        }
    }
}

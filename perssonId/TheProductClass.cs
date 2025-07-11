using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perssonId
{
    public class TheProductClass:TheCustmerClass
    {
       

        public MemoryStream MemoreImgPro = new MemoryStream();

         
        
       
        public bool addNewProduct(ref object Data_pro)
        {

            ///
            if (findProduct(((dynamic)Data_pro).ID, out object Data_product ))
            {
                return true;
            }
            string qure = @"INSERT INTO PRODUCT VALUES (@GUID_PRO , @ID_PRO ,@TYPE_PRO, @NAME_PRO ,@NAME_BR ,@COUNT_PRO, @PRICEBUY_PRO , @PRICEBAY_PRO ,@IMGE_PRO)";
            openServar(out SqlConnection connectionPr);
            SqlCommand connect = new SqlCommand(qure, connectionPr);
            connect.Parameters.AddWithValue("@GUID_PRO", Guid.NewGuid());
            connect.Parameters.AddWithValue("@ID_PRO", ((dynamic)Data_pro).ID);
            connect.Parameters.AddWithValue("@TYPE_PRO", ((dynamic)Data_pro).Typepro);
            connect.Parameters.AddWithValue("@NAME_PRO", ((dynamic)Data_pro).Name);
            connect.Parameters.AddWithValue("@NAME_BR", ((dynamic)Data_pro).NameBr);
            connect.Parameters.AddWithValue("@COUNT_PRO", ((dynamic)Data_pro).Cont);
            connect.Parameters.AddWithValue("@PRICEBUY_PRO", ((dynamic)Data_pro).PriceBuy);
            connect.Parameters.AddWithValue("@PRICEBAY_PRO", ((dynamic)Data_pro).PriceBay);
            connect.Parameters.AddWithValue("@IMGE_PRO", ((dynamic)Data_pro).Pic.ToArray());

            connect.ExecuteNonQuery();

            connectionPr.Close();
            return false;
        }
        public bool findProduct(string textIdPro, out object Data_Pro)
        {
            string qur = @"select * from PRODUCT 
                         WHERE ID_PRO ='" + textIdPro + "'";
            openServar(out SqlConnection connectionPr);
            SqlCommand connectProduct = new SqlCommand(qur, connectionPr);
            //openServar();
            SqlDataReader sqlDataReader=connectProduct.ExecuteReader();
           
           
            while (sqlDataReader.Read())
            {

                Data_Pro = new
                {

                    Typepro = sqlDataReader[2].ToString(),
                    Name = sqlDataReader[3].ToString(),
                    NameBr = sqlDataReader[4].ToString(),
                    Cont = sqlDataReader[5].ToString(),
                    PriceBuy = sqlDataReader[6].ToString(),
                    PriceBay = sqlDataReader[7].ToString(),
                    Pic = sqlDataReader[8]
                };
                connectionPr.Close();
                return true;
            }
            Data_Pro = null;
            return false;
        }
        public void amendProduct(ref object Data_pro)
        {
            openServar(out SqlConnection connectionPr);
            string qur = @"UPDATE PRODUCT
             SET TYPE_PRO = @TYPE_PRO,NAME_PRO = @NAME_PRO,NAME_BR=@NAME_BR,COUNT_PRO = @COUNT_PRO, PRICEBUY_PRO = @PRICEBUY_PRO, PRICEBAY_PRO = @PRICEBAY_PRO, IMGE_PRO = @IMGE_PRO
             WHERE ID_PRO = '" + ((dynamic)Data_pro).ID + "'";

            SqlCommand connect = new SqlCommand(qur, connectionPr);

            connect.Parameters.AddWithValue("@TYPE_PRO", ((dynamic)Data_pro).Typepro);
            connect.Parameters.AddWithValue("@NAME_PRO", ((dynamic)Data_pro).Name);
            connect.Parameters.AddWithValue("@NAME_BR", ((dynamic)Data_pro).NameBr);
            connect.Parameters.AddWithValue("@COUNT_PRO", ((dynamic)Data_pro).Cont);
            connect.Parameters.AddWithValue("@PRICEBUY_PRO", ((dynamic)Data_pro).PriceBuy);
            connect.Parameters.AddWithValue("@PRICEBAY_PRO", ((dynamic)Data_pro).PriceBay);
            connect.Parameters.AddWithValue("@IMGE_PRO", ((dynamic)Data_pro).Pic.ToArray());
            connect.ExecuteNonQuery();
            connectionPr.Close();
        } 
        public void deletProduct(string id)
        {

            openServar(out SqlConnection connectionPr);
            string qur = @"DELETE FROM INVOICE 
                         WHERE ID_PRODUCT ='" + id + "'" +
                        @"DELETE FROM PRODUCT 
                          WHERE ID_PRO ='" + id + "'";
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            connect.ExecuteNonQuery();

            connectionPr.Close();

        }
      



    }
}


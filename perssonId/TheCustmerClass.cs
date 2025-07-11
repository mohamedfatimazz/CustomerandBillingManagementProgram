using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using perssonId;

namespace perssonId
{
   public class TheCustmerClass
   {

        public static bool newAd = false, Fd = false,Dt = false, AdS = false,Rut=false;
        public  MemoryStream MemoryImgCu =new MemoryStream();
     
        protected string cnProt = @"Server=.\JOWAD; Database=AlZain_Company_DATA; User Id=mohamad; Password=m12345; ";
       protected SqlConnection connectionPr = new SqlConnection();
        SqlDataReader sqlDataReader;
       protected void openServar(out SqlConnection connectionPr ) {
        connectionPr = new SqlConnection(cnProt);
        connectionPr.Close();
        connectionPr.Open();
        }
        ///
        public bool addNewCustmer(ref object Date_Cu)
        {
            if (findCustmer(((dynamic)Date_Cu).ID, out object Date_Cu1))
            {
                return true;
            }
            string qur1 = @"INSERT INTO  CUSTMER VALUES (@GUID_CU ,@ID_CU , @NAME_CU ,@PHONE ,  @ADRIS  ,  @DATAPERTH  ,  @TYPEPR  ,@IMGS_CU)";
            openServar(out SqlConnection connectionPr);
            SqlCommand connect = new SqlCommand(qur1, connectionPr);
            connect.Parameters.AddWithValue("@GUID_CU", Guid.NewGuid());
            connect.Parameters.AddWithValue("@ID_CU",((dynamic)Date_Cu).ID);
            connect.Parameters.AddWithValue("@NAME_CU", ((dynamic)Date_Cu).Name);
            connect.Parameters.AddWithValue("@PHONE", ((dynamic)Date_Cu).PHONE);
            connect.Parameters.AddWithValue("@ADRIS", ((dynamic)Date_Cu).ADRES);
            connect.Parameters.AddWithValue("@DATAPERTH", ((dynamic)Date_Cu).DATAPERTH);
            connect.Parameters.AddWithValue("@TYPEPR", ((dynamic)Date_Cu).TYPE);
            connect.Parameters.AddWithValue("@IMGS_CU", ((dynamic)Date_Cu).PIC.ToArray());
           
            connect.ExecuteNonQuery();

            connectionPr.Close();

            return false;
        }
        public bool findCustmer(string textId_Cu1,out object Data_Cu)
        {
           
            string qur = @"select * from CUSTMER 
                    WHERE ID_CU ='" + textId_Cu1 + "'";
            openServar(out SqlConnection connectionPr);
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            sqlDataReader = connect.ExecuteReader();

            while (sqlDataReader.Read())
            {

                Data_Cu =new{name=sqlDataReader[2].ToString()
                    ,phone=sqlDataReader[3].ToString()
                    ,adres=sqlDataReader[4].ToString()
                    ,Date=sqlDataReader[5].ToString()
                    , type=sqlDataReader[6].ToString()
                    ,pic= sqlDataReader[7]};
              
                return true;

            }

            Data_Cu = null;
            return false;
        }
        public void amendCustmer(ref object Date_Cu)
        {
            openServar(out SqlConnection connectionPr);
            string qur = @"UPDATE CUSTMER
             SET NAME_CU = @NAME_CU,PHONE=@PHONE, ADRIS = @ADRIS, DATAPERTH = @DATAPERTH, TYPEPR = @TYPEPR, IMGS_CU = @IMGS_CU
             WHERE ID_CU = '" + ((dynamic)Date_Cu).ID + "'";

            SqlCommand connect = new SqlCommand(qur, connectionPr);


            connect.Parameters.AddWithValue("@NAME_CU",((dynamic)Date_Cu).Name);
            connect.Parameters.AddWithValue("@PHONE",((dynamic)Date_Cu).PHONE);
            connect.Parameters.AddWithValue("@ADRIS", ((dynamic)Date_Cu).ADRES);
            connect.Parameters.AddWithValue("@DATAPERTH",((dynamic)Date_Cu).DATAPERTH);
            connect.Parameters.AddWithValue("@TYPEPR",((dynamic)Date_Cu).TYPE);
            connect.Parameters.AddWithValue("@IMGS_CU",((dynamic)Date_Cu).PIC.ToArray());

            connect.ExecuteNonQuery();
            connectionPr.Close();
        }
        public void deletCustmer(string id)
        {


            openServar(out SqlConnection connectionPr);
            string qur = @"DELETE FROM INVOICE
                         WHERE ID_CUSTMER ='"+id+"'"  
						 +"DELETE FROM CUSTMER WHERE ID_CU ='"+id+"';";
                          
            SqlCommand connect = new SqlCommand(qur, connectionPr);
            connect.ExecuteNonQuery();

            connectionPr.Close();
           
        }
       
        
       
       
    }
}

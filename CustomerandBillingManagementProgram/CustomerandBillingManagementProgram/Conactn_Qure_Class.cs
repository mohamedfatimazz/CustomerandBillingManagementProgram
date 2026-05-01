using CustomerandBillingManagementProgram;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomerandBillingManagementProgram
{
    internal class Conactn_Qure_Class
    {
      
       public static SqlCommand connect; public static SqlConnection connectionPr;
        public static string Connection_DataBase { get; } = CreateDatabase.connection;
        /// <summary>
        /// Invoice Qure
        /// </summary>
        public static string Qure_Select_Invoice { get; } = @"select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID,INV.REST_INV , INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV
                    INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO";
        public static string Qure_Select_Yild_Invoice { get; } = @"select TOTAL_INV, VALUE_PAID,ACCONT from INVOICE";
        public static string Qure_Select_btnNrPtSold { get; } = @"select  PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,COUNT(INV.ID_PRODUCT)  from INVOICE AS INV
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO
                    GROUP BY PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR ";
        /// <summary>
        /// Custmer Qure
        /// </summary>
        public static string Qure_Select_CTR { get; } = @"select * from CUSTMER ";
        public static string Qure_Insert_CTR { get; } = @"INSERT INTO  CUSTMER VALUES (@GUID_CU ,@ID_CU , @NAME_CU ,@PHONE ,  @ADRIS  ,  @DATAPERTH  ,  @TYPEPR  ,@IMGS_CU)";
        public static string Qure_UpDate_CTR { get; } = @"UPDATE CUSTMER
             SET NAME_CU = @NAME_CU,PHONE=@PHONE, ADRIS = @ADRIS, DATAPERTH = @DATAPERTH, TYPEPR = @TYPEPR, IMGS_CU = @IMGS_CU";
        public static string Qure_Delete_IVC { get; } = @"DELETE FROM INVOICE";
                                                   
        public static string Qure_Delete_CTR { get; } = "DELETE FROM CUSTMER WHERE ID_CU ='";
        /// <summary>
        /// Product Qure
        /// </summary>
        public static string Qure_Select_PDT { get; } = @"select * from PRODUCT ";
        public static string Qure_Insert_PDT { get; } = @"INSERT INTO PRODUCT VALUES (@GUID_PRO,@ID_PRO,@TYPE_PRO, @NAME_PRO ,@NAME_BR ,@COUNT_PRO, @PRICEBUY_PRO , @PRICEBAY_PRO ,@IMGE_PRO)";
        public static string Qure_UpDate_PDT { get; } = @"UPDATE PRODUCT
             SET TYPE_PRO = @TYPE_PRO,NAME_PRO = @NAME_PRO,NAME_BR=@NAME_BR,COUNT_PRO = @COUNT_PRO, PRICEBUY_PRO = @PRICEBUY_PRO, PRICEBAY_PRO = @PRICEBAY_PRO, IMGE_PRO = @IMGE_PRO)";
        public static string Qure_Delete_PDT { get; } = @"DELETE FROM PRODUCT WHERE ID_PRO ='";
        /// <summary>
        ///Invoice Qure
        /// </summary>
        public static string Qure_Insert_IVC { get; } = @"INSERT INTO INVOICE VALUES (@GUID_INV, @ID_INVOICE , @ID_CUSTMER ,@ID_PRODUCT,@COUNT_PRO , @DATA_INV,@PIRC_INV,@VALUE_PAID ,@REST_INV, @ACCOUNT )";
        public static string Quer_UpDate_IVC = @"UPDATE INVOICE
                 SET ID_CUSTMER = @ID_CUSTMER,ID_PRODUCT=@ID_PRODUCT,COUNT_PRO=@COUNT_PRO, DATA_INV = @DATA_INV,TOTAL_INV=@TOTAL_INV,VALUE_PAID=@VALUE_PAID,REST_INV=@REST_INV, ACCONT = @ACCONT";

        /// <summary>
        /// 
        /// </summary>
        public static void SqlConnection_Open()
        {
            SqlConnection_Close();
        }
        public static void SqlCommand_Fn(string qur)
        {
           
            {
                try
                {
                    
                    connectionPr = new SqlConnection(Connection_DataBase);
                    SqlConnection_Close();
                    connectionPr.Open();
                    connect = new SqlCommand(qur, connectionPr);
                   
                        connect.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
           
        }
        public static void SqlCommand_Fn(string qur,string NameDatabase)
        {

            {
                try
                {

                    connectionPr = new SqlConnection(NameDatabase);
                    SqlConnection_Close();
                    connectionPr.Open();
                    connect = new SqlCommand(qur, connectionPr);

                    connect.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
        public static void SqlConnection_Close()
        {
            connectionPr.Close();
        }
        /// <summary>
        /// CTR 
        /// </summary>
        public static bool Add_New_Value_Databese_CTR(string qure,bool AddNew)
        {
            SqlCommand_Fn(qure);
            if (AddNew)
            {               
                connect.Parameters.AddWithValue("@GUID_CU",Guid.NewGuid());
                connect.Parameters.AddWithValue("@ID_CU", TheBaseClass.Model[0]);
            }
            connect.Parameters.AddWithValue("@NAME_CU", TheBaseClass.Model[1]);
            connect.Parameters.AddWithValue("@PHONE", TheBaseClass.Model[2]);
            connect.Parameters.AddWithValue("@ADRIS", TheBaseClass.Model[3]);
            connect.Parameters.AddWithValue("@DATAPERTH", TheBaseClass.Model[4]);
            connect.Parameters.AddWithValue("@TYPEPR", TheBaseClass.Model[5]);
            connect.Parameters.AddWithValue("@IMGS_CU", TheBaseClass.Model[6]);
            connect.ExecuteNonQuery();
            return false;
        }
        /// <summary>
        /// PDT
        /// </summary>
        public static bool Add_New_Value_Database_PDT(string qure,bool AddNew )
        {
            SqlCommand_Fn(qure);

            if (AddNew)
            {
                connect.Parameters.AddWithValue("@GUID_PRO", Guid.NewGuid());
                connect.Parameters.AddWithValue("@ID_PRO",TheBaseClass.Model[0]);
            }
            connect.Parameters.AddWithValue("@TYPE_PRO", TheBaseClass.Model[1]);
            connect.Parameters.AddWithValue("@NAME_PRO", TheBaseClass.Model[2]);
            connect.Parameters.AddWithValue("@NAME_BR", TheBaseClass.Model[3]);
            connect.Parameters.AddWithValue("@COUNT_PRO", TheBaseClass.Model[4]);
            connect.Parameters.AddWithValue("@PRICEBUY_PRO", TheBaseClass.Model[5]);
            connect.Parameters.AddWithValue("@PRICEBAY_PRO", TheBaseClass.Model[6]);
            connect.Parameters.AddWithValue("@IMGE_PRO", TheBaseClass.Model[7]);
            connect.ExecuteNonQuery();
            return false;
        }
        public static  bool Add_New_Value_Database_IVC(string qure ,bool AddNew )
        {
            SqlCommand_Fn(qure);
            
            if (AddNew)
            {
                connect.Parameters.AddWithValue("@GUID_INV", Guid.NewGuid());
                connect.Parameters.AddWithValue("@ID_INVOICE", TheBaseClass.Model[0]);
            }
            connect.Parameters.AddWithValue("@ID_CUSTMER", TheBaseClass.Model[1]);
            connect.Parameters.AddWithValue("@ID_PRODUCT", TheBaseClass.Model[2]);
            connect.Parameters.AddWithValue("@COUNT_PRO", TheBaseClass.Model[3]);
            connect.Parameters.AddWithValue("@DATA_INV", TheBaseClass.Model[4]);
            connect.Parameters.AddWithValue("@PIRC_INV", TheBaseClass.Model[5]);
            connect.Parameters.AddWithValue("@VALUE_PAID", TheBaseClass.Model[6]);
            connect.Parameters.AddWithValue("@REST_INV", TheBaseClass.Model[7]);
            connect.Parameters.AddWithValue("@ACCOUNT", TheBaseClass.Model[8]);
            connect.ExecuteNonQuery();
            return false;
        }
        public static bool Red_Value_Databese(string qure ,bool m)
        {
            SqlCommand_Fn(qure);

            SqlDataReader sqlDataReader = connect.ExecuteReader();
            
                try
                {
                TheBaseClass.Delet_List();
                while (sqlDataReader.Read())
                    {
                    
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        if (m)
                        {
                            if (i == sqlDataReader.FieldCount - 1)
                            {
                                TheBaseClass.Model.Add(sqlDataReader[i]);
                                break;
                            }
                        }
                        TheBaseClass.Model.Add(sqlDataReader[i].ToString());
                        
                    }

                    return true;

                }
               
            }
                catch (Exception)
                {

                    throw;
                }
              
                return false;
            

        }
        /// <summary>
        /// PDT
        /// </summary>
        

    }
}

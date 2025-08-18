using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perssonId
{
    internal class Conactn_Qure_Class
    {
        public static string Connection_DataBase { get; } = @"Server=.\JOWAD; Database=AlZain_Company_DATA; User Id=mohamad; Password=m12345; ";

        public static string Qure_Select_Invoice { get; } = @"select INV.ID_INVOICE, CU.ID_CU , CU.NAME_CU , CU.PHONE , PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,PO.PRICEBAY_PRO ,INV.COUNT_PRO,INV.TOTAL_INV, INV.VALUE_PAID,INV.REST_INV , INV.DATA_INV , INV.ACCONT, PO.IMGE_PRO  from INVOICE AS INV
                    INNER JOIN CUSTMER AS CU  ON INV.ID_CUSTMER  = CU.ID_CU
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO";

        public static string Qure_Select_Product { get; }=  @"select * from PRODUCT ";
        public static string Qure_Select_Custmer { get; } =@"select * from CUSTMER ";
        public static string Qure_Select_Yild_Invoice { get; } = @"select TOTAL_INV, VALUE_PAID,ACCONT from INVOICE";
        public static string Qure_Select_btnNrPtSold { get; } = @"select  PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR,COUNT(INV.ID_PRODUCT)  from INVOICE AS INV
                    INNER JOIN PRODUCT AS PO  ON INV.ID_PRODUCT = PO.ID_PRO
                    GROUP BY PO.ID_PRO ,PO.TYPE_PRO, PO.NAME_PRO ,
                    PO.NAME_BR ";
        static SqlConnection connectionPr = new SqlConnection(Connection_DataBase);
        public  static SqlCommand connect;
        public static void SqlConnection_Open()
        {
            connectionPr.Close();
            connectionPr.Open();
        }
        public static void SqlCommand_Fn(string qur)
        {
            SqlConnection_Open();
             connect = new SqlCommand(qur, connectionPr);
        } 
        public static void SqlConnection_Close()
        {
            connectionPr.Close();
        }
    }
}

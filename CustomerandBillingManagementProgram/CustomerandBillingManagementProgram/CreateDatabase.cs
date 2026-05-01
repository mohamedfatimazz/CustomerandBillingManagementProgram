using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CustomerandBillingManagementProgram
{
    internal class CreateDatabase
    {
       // public static string NAMEDATABASE = "AlZain_Company_DATA";
        public static string NAME_SERVER = "MOHAMAD";
        public static string User_Name;
        public static string User_Password;
        public static string NAME_DATABASE = "CUSTOMER_BILING_MANAGEMENT_PROGRAMM";
        public static string QueueSelectDatabase = $"IF NOT EXISTS(SELECT NAME FROM SYS.DATABASE WHERE NAME={NAME_DATABASE})\t\nBEGIN\t\nSELECT 0 \t\nEND\t\nBEGIN\t\nSELECT 1 \t\nEND";
        string connection_Master = @"Server=.\"+NAME_SERVER+ ";Database=master;Integrated Security=True;\t\nCREATEDATABASE "+ NAME_DATABASE + ";";
        public static string  connection = @"Server=.\" + NAME_SERVER + ";Database=" + NAME_DATABASE + ";Integrated Security=True;";
        public static string connection_User_N_P = @"Server=.\" + NAME_SERVER + ";Database=" + NAME_DATABASE + ";UserName="+User_Name+ ";Password="+User_Password+";";
        public int CreatconnectioneData()
        {
            Conactn_Qure_Class.SqlCommand_Fn(QueueSelectDatabase);
            if (Conactn_Qure_Class.connect.ExecuteScalar().ToString()=="0")
            {
                return 0;
            }
            else if(Conactn_Qure_Class.connect.ExecuteScalar().ToString() == "1")
            {
                CreateNewDataBase();
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public int CreateNewDataBase()
        {
            Conactn_Qure_Class.SqlCommand_Fn(connection_Master);
            Conactn_Qure_Class.SqlCommand_Fn(connection);
            Conactn_Qure_Class.SqlCommand_Fn(CreteTableProc);
            Conactn_Qure_Class.SqlCommand_Fn("EXEC CREATE_TABLE");
            if (Conactn_Qure_Class.connect.ExecuteScalar().ToString() == "0")
            {
                return 0;
            }
            else
            {
                CreateNewDataBase();
                return 1;
            }
        }
        private string CreteTableProc=@"CREATE PROC CREATE_TABLE
AS
BEGIN
CREATE TABLE CUSTMER
(
GUID_CU UNIQUEIDENTIFIER,
ID_CU INT PRIMARY KEY,
NAME_CU NVARCHAR(MAX) NOT NULL,
PHONE NVARCHAR(255) NOT NULL,
ADRIS NVARCHAR(255) NOT NULL,
DATAPERTH NVARCHAR(200),
TYPEPR NVARCHAR(50),
IMGS_CU IMAGE
);
CREATE TABLE PRODUCT(
GUID_PRO UNIQUEIDENTIFIER,
ID_PRO INT PRIMARY KEY,
TYPE_PRO NVARCHAR (255),
NAME_PRO NVARCHAR(MAX)NOT NULL,
NAME_BR NVARCHAR(MAX) NOT NULL,
COUNT_PRO INT ,
PRICEBUY_PRO INT NOT NULL,
PRICEBAY_PRO INT NOT NULL,
IMGE_PRO IMAGE,

);

CREATE TABLE INVOICE (
GUID_INV UNIQUEIDENTIFIER,
ID_INVOICE INT PRIMARY KEY,
ID_CUSTMER INT FOREIGN KEY REFERENCES CUSTMER (ID_CU),
ID_PRODUCT INT FOREIGN KEY REFERENCES PRODUCT (ID_PRO),
COUNT_PRO INT ,
DATA_INV NVARCHAR(200),
TOTAL_INV INT ,
VALUE_PAID INT,
REST_INV INT,
ACCONT NVARCHAR(200)
);
CREATE TABLE InvoiceDetails (
    InvoiceDetailID INT PRIMARY KEY IDENTITY(1,1), -- معرف فريد لسطر التفاصيل
    InvoiceID INT NOT NULL FOREIGN KEY (InvoiceID) REFERENCES INVOICE(ID_INVOICE) ON DELETE CASCADE,                        -- معرف الفاتورة (يرتبط بجدول الفواتير)
    ProductID INT NOT NULL FOREIGN KEY (ProductID) REFERENCES PRODUCT(ID_PRO) ,                        -- معرف المنتج (يرتبط بجدول المنتجات)
    Quantity INT NOT NULL DEFAULT 1,               -- الكمية المباعة (افتراضي 1)
    UnitPrice DECIMAL(10,2) NOT NULL,              -- سعر الوحدة وقت البيع
    Subtotal AS(Quantity * UnitPrice), -- حساب المجموع الفرعي تلقائياً
);
END";
    }
}

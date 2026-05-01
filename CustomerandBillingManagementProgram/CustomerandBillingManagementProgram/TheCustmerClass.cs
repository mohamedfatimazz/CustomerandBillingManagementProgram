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
using CustomerandBillingManagementProgram;
using CustomerandBillingManagementProgram;

namespace CustomerandBillingManagementProgram
{
   public class TheCustmerClass
   {
        public  MemoryStream MemoryImgCu =new MemoryStream();
        public bool addNewCustmer(string Id_Pr, string Name,string Phone, string Adres, string DataBerth, string Type, object Pic)
        {
            
            if (FondCustmer(Id_Pr))
            {
                return true;
            }
            TheBaseClass.Add_Value_List(Id_Pr, Name, Phone, Adres, DataBerth, Type, Pic);
            return Conactn_Qure_Class.Add_New_Value_Databese_CTR(Conactn_Qure_Class.Qure_Insert_CTR, true);
        }
        public bool FondCustmer(string textId_Cu)
        {
           return Conactn_Qure_Class.Red_Value_Databese(Conactn_Qure_Class.Qure_Select_CTR + "\t\n WHERE ID_CU ='" + textId_Cu + "'",true);
        }
        public void amendCustmer(string Id_Pr, string Name, string Phone, string Adres, string DataBerth, string Type, object Pic)
        {
            TheBaseClass.Add_Value_List(Id_Pr, Name, Phone, Adres, DataBerth, Type, Pic);
            Conactn_Qure_Class.Add_New_Value_Databese_CTR(Conactn_Qure_Class.Qure_UpDate_CTR + "\t\n WHERE ID_CU = '" + Id_Pr + "'", false);
        }
        public void deletCustmer(string id)
        {
            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Delete_IVC+ " WHERE ID_CUSTMER ='" + id+"'\t\n"+Conactn_Qure_Class.Qure_Delete_CTR+"'"+id+"';");            
        }
    }
}

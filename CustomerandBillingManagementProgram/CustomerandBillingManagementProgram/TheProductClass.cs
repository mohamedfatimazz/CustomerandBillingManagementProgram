using CustomerandBillingManagementProgram;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerandBillingManagementProgram
{
    public class TheProductClass:TheCustmerClass
    {
       

        public MemoryStream MemoreImgPro = new MemoryStream();
        
        public bool addNewProduct(string Id, string Type, string Name_Pro, string Name_Br, string Count, string PriceBuy, string PriceBae, byte[] pic)
        {

            ///
            if (findProduct(Id))
            {
                return true;
            }
            TheBaseClass.Add_Value_List(Id, Type, Name_Pro, Name_Br, Count, PriceBuy, PriceBae, pic);
            return Conactn_Qure_Class.Add_New_Value_Database_PDT(Conactn_Qure_Class.Qure_Insert_PDT,true);
        }
        public bool findProduct(string textIdPro)
        {

            return Conactn_Qure_Class.Red_Value_Databese(Conactn_Qure_Class.Qure_Select_PDT + "  WHERE ID_PRO = '" + textIdPro + "'", true );
        }
        public void amendProduct(string Id, string Type, string Name_Pro, string Name_Br, string Count, string PriceBuy, string PriceBae, byte[] pic )
        {

            TheBaseClass.Add_Value_List(Id, Type, Name_Pro, Name_Br, Count, PriceBuy, PriceBae, pic);
            Conactn_Qure_Class.Add_New_Value_Database_PDT(Conactn_Qure_Class.Qure_UpDate_PDT + "\t\n WHERE ID_PRO = '" + Id + "'",false);
        } 
        public void deletProduct(string id)
        {

            Conactn_Qure_Class.SqlCommand_Fn(Conactn_Qure_Class.Qure_Delete_IVC + " WHERE ID_PRODUCT ='" + id + "'" + Conactn_Qure_Class.Qure_Delete_PDT + "'" + id + "';");

        }
      



    }
}


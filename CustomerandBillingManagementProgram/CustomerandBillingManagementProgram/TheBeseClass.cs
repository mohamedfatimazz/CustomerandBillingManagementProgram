using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomerandBillingManagementProgram
{
    class TheBaseClass
    {
        public static List<object> Model = new List<object>();

        public static bool Add_bool, Fond_bool, Delete_bool, Amend_bool, Rutern_bool;
        public TheBaseClass()
        {

        }
        public static void addBaseClass(bool Add_bool_Pr, bool Fond_bool_Pr, bool Amend_bool_Pr, bool Delete_bool_Pr, bool Rutern_bool_Pr) {
            Add_bool = Add_bool_Pr;
            Fond_bool = Fond_bool_Pr;
            Delete_bool = Delete_bool_Pr;
            Amend_bool = Amend_bool_Pr;
            Rutern_bool = Rutern_bool_Pr;

        }
        public static void Add_Value_List(string Id_Pr, string Name, string Phone, string Adres, string DataBerth, string Type, object Pic)
        {
            Delet_List();
            Model.Add(Id_Pr);
            Model.Add(Name);
            Model.Add(Phone);
            Model.Add(Adres);
            Model.Add(DataBerth);
            Model.Add(Type);
            Model.Add(Pic);
        }
        public static void Add_Value_List(string Id ,string Type ,string Name_Pro,string Name_Br,string Count,string PriceBuy,string PriceBae,byte[]pic)
        {
            Model.Add(Id);
            Model.Add(Type);
            Model.Add(Name_Pro);
            Model.Add(Name_Br);
            Model.Add(Count);
            Model.Add(PriceBuy);
            Model.Add(PriceBae);
            Model.Add( pic.ToArray());
        }
        public static void Add_Value_List(string Id_IVC,string Id_CTR ,string Id_PDT,string Count,string Pirc,string total,string Value_Paid ,string Rest,string Account)
        {
            Model.Add(Id_IVC);
            Model.Add(Id_CTR);
            Model.Add(Id_PDT); 
            Model.Add(Count);
            Model.Add(Pirc);
            Model.Add(total);
            Model.Add(Value_Paid);
            Model.Add(Rest);
            Model.Add(Account);
        }
        //public static void Add_Value_List(SqlDataReader Red ,bool M)
        //{
           
        //    int i = 1;
        //    while (Red.Read())
        //    {
               
        //    }
        //}
        public static void Delet_List()
        {
           
                Model.Clear();
              
        } 

       
    }
}

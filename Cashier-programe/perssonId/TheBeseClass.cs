using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomerandBillingManagementProgram
{

    class TheBaseClass
    {
        public static string[,] Custmre_Add = new string[2,7];
        public static bool Add_bool , Fond_bool , Delete_bool, Amend_bool , Rutern_bool;
        public TheBaseClass()
        {
           
        }

        public static void addBaseClass(bool Add_bool_Pr, bool Fond_bool_Pr, bool Amend_bool_Pr , bool Delete_bool_Pr, bool Rutern_bool_Pr) {
            Add_bool = Add_bool_Pr;
            Fond_bool = Fond_bool_Pr;
           Delete_bool = Delete_bool_Pr;
            Amend_bool = Amend_bool_Pr;
            Rutern_bool = Rutern_bool_Pr;
            
        }
        public static void Add_Colmuns( string[,] Custmre_Add_pr)
        {
            for (int i = 0; i < Custmre_Add_pr.GetLongLength(0); i++)
            {
                for (int z = 0; z < Custmre_Add_pr.GetLongLength(1); z++)
                {
                    Custmre_Add[i, z] = Custmre_Add_pr[i,z];
                }
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Connectiontochinook
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-MQP0JF7//SQLEXPRESS;Initial Catalog=Chinook;Integrated Security=SSPI");
          

            SqlCommand cmd = new SqlCommand("Select * from Genre",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable x = new DataTable();
               
            con.Close();
            }
            catch(Exception ei)
            {
                Console.WriteLine(ei.StackTrace);
            }
        }
       
    }
    
}

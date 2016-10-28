using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectiontochinook
{
    class Connectionless
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MQP0JF7\SQLEXPRESS;Initial Catalog=Chinook;Integrated Security=True");


            string cmd = "Select * from Genre";
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand(cmd, con);

                SqlDataAdapter sda = new SqlDataAdapter(sc);
               
                sda.Fill(dt);
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.ToString());
            }
            finally
            {
                con.Close();
            }


            Console.WriteLine(dt.Rows.Count);

            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item+"  ");
                    
                }
                Console.WriteLine(" ");
            }

            Console.Read();


        }
        
    }
}

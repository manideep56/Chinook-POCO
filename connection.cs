using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Connectiontochinook
{
    class connection
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

                SqlDataReader reader = sc.ExecuteReader();

               
   while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetValue(i)+"  ");
                    }
                    Console.WriteLine();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.ToString());
            }
            finally
            {
                con.Close();
            }



            Console.Read();
    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NetConnected
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                SqlConnection Cn = new SqlConnection("server=.;integrated security=true;database=TSQL");
                SqlCommand Cm = new SqlCommand();

                Console.WriteLine("Unesite id kupca: ");

                Cm.Connection = Cn;
                Cm.CommandType = CommandType.Text;
                string SQLupit = "EXEC Sales.custDelete " + Console.ReadLine() + ";";
                Cm.CommandText = SQLupit;                    

                if (Cn.State == ConnectionState.Closed)
                {
                   Cn.Open();
                }

                int rowsAffected = Cm.ExecuteNonQuery();

                Cn.Close();

                if(rowsAffected != 0)
                {
                    Console.WriteLine("Kupac je obrisan.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

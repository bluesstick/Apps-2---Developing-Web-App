using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RestaurantOsystem.Conection
{
    class MasterConnectio
    {
        public static string Connection = Convert.ToString (Libraries.Decrypt.checkServer());
        public static SqlConnection connect = new SqlConnection(Connection);


        internal void open()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        internal void close()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }

    }
}

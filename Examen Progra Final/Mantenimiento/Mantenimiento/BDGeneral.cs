using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PruebaCRUD
{
    public class BDGeneral
    {
        public static SqlConnection BDConectar()
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-EEIL3D5; DataBase= Base1; Integrated Security= true");
            conn.Open();
            return conn;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBServices
{
    public abstract class ConnectionToSql
    {
        
        private readonly string connectionString;

        public ConnectionToSql()
        {
            
            connectionString = "Server=DESKTOP-EEIL3D5; DataBase= ProyectoSAIE; Integrated Security= true";
        }
        protected SqlConnection GetConnection()
        {
          
            return new SqlConnection(connectionString);
        }
    }
}

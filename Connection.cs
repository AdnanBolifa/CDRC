using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRC
{
    internal class Connection
    {
        public SqlConnection getConnection()
        {
            string connetionString;
            SqlConnection cnn = new SqlConnection();
            connetionString = "Data Source= localhost;Initial Catalog=CDRC; Integrated Security=true; TrustServerCertificate=True";
            cnn.ConnectionString = connetionString;
            return cnn;
        }
    }
}

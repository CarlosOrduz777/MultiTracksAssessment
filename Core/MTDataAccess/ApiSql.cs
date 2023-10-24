using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDataAccess
{
    public class ApiSql:SQL
    {
        public ApiSql(string _connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException("the connection string cannot be null");
            connectionString = _connectionString;
        }
    }
}

using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDataAccess
{
    public class SqlWebForm:SQL
    {
        public SqlWebForm():this("admin")
        { }

        public SqlWebForm(string connectionStringName)
        {
            if (ConfigurationManager.ConnectionStrings[connectionStringName] == null)
                throw new Exception("\"" + connectionStringName + "\" connection string not found in config file.");
            else
                connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ToString();
        }
        public SqlWebForm(int timeout):this("admin")
        {
            Timeout = timeout;
        }
        public SqlWebForm(string connectionStringName, int timeout) : this(connectionStringName) { Timeout = timeout; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect
{
     interface itConnect
    {
        string DataSource { get; set; }
        string Database { get; set; }
        string UserName { get; set; }
        string PassWord { get; set; }
        SqlConnection SqlconnectionSQLSeverAuthentication();
        SqlConnection SqlConnectionWindowsAuthentication();
    }
}

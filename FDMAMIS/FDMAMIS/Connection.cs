using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FDMAMIS
{
    class Connection
    {
        public SqlConnection kon = new SqlConnection("Data Source=FDMA-PC;Initial Catalog=NWAMIS;User ID=sa;Password=fdma123");
    }
}

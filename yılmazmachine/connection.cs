using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yılmazmachine
{
    internal class connection
    {
       SqlConnection conn=new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=yilmazmachine;Integrated Security=True");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        protected SqlConnection conn = new SqlConnection("Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;");
    }


}

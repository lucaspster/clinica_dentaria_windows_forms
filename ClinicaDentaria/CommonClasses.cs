using System.Data;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    class CommonClasses
    {
       public SqlDataReader rdr = null;
       public DataTable dtable = new DataTable();
       public SqlConnection con = null;
       public SqlCommand cmd = null;
       public DataSet ds;
       public SqlDataAdapter da;
    }
}

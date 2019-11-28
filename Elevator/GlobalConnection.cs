using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.OleDb;
using System.Windows.Forms;

namespace ControlAnElevator
{
    class GlobalConnection
    {
        public static OleDbConnection cn;
        public static void DbConnection()
        {
            try
            {
                cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ElevatorLog.mdb");
                cn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

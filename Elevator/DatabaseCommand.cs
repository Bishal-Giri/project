using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace ControlAnElevator
{
    class DatabaseCommand
    {
         public void insertdata(string action) //command to insert data in database in each tables
        {
            string sql = "insert into [ElevatorRecord] ([Date],[Time],[Actions]) values (@date, @time, @action)";
            OleDbCommand cmd = new OleDbCommand(sql, GlobalConnection.cn);
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@action", action);
            cmd.ExecuteNonQuery();
        }

        public DataTable ViewData() //method to view the database record
        {
            string sql = "SELECT date, time, actions FROM ElevatorRecord";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, GlobalConnection.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "ElevatorRecord");
            return ds.Tables[0];
        }

        public void  remove() //method to delete the record to the database
        {
            string remove = "DELETE * FROM ElevatorRecord";
             OleDbCommand cmd = new OleDbCommand(remove, GlobalConnection.cn);
            cmd.ExecuteNonQuery();
        }


    }
}

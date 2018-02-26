using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Aikalaskuri
{
    class DatabaseConnection
    {
        
        //private string strCon;
        
        SQLiteConnection sqlite_conn;
        SQLiteDataAdapter da_1;
        private string sql_string;
        
        public string Sql
        {
            set
            {
                sql_string = value;
            }
        }

        // To select data
        public System.Data.DataSet GetConnection
        {
            get { return MyDataSet(); }    
        }
        
        private System.Data.DataSet MyDataSet()
        {
            // create a new database connection string
            sqlite_conn = new SQLiteConnection("Data Source=Databases/Lumikot.s3db;Version=3;New=True;Compress=True;");
            da_1 = new SQLiteDataAdapter(sql_string, sqlite_conn);
            DataSet myDataSet = new DataSet();
            System.Data.DataSet dat_set = new System.Data.DataSet();
            da_1.Fill(dat_set, "Table"); // Get data
            return dat_set;
        }
            
    }
}

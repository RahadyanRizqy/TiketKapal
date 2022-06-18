using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace TiketKapal
{
    internal class Database
    {
        public SQLiteConnection conn;
        private string dbname = "appdb.sqlite3";
        private string sqlfile = "appdb.sql";
        public string query;
        public string value;


        public Database(string query)
        {

            conn = new SQLiteConnection($"Data Source={dbname}");
            if (!File.Exists($"./{dbname}"))
            {
                SQLiteConnection.CreateFile(dbname);
                constructDb();
            }
            this.query = query;
        }
        private void constructDb()
        {
            openConn();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = File.ReadAllText($"./{sqlfile}");            
            cmd.ExecuteNonQuery();
            closeConn();
            cmd.Dispose();
        }
        internal void ExecNonQuery()
        {
            openConn();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            closeConn();
            cmd.Dispose();
        }
        internal void FetchValue()
        {
            openConn();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    value = reader.GetString(0);
                }
                catch (Exception)
                {
                    value = Convert.ToString(reader.GetInt32(0));
                }
            }
            closeConn();
            cmd.Dispose();
        }
        internal void TableReader(DataGridView dgv, DataTable dt)
        {
            openConn();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
            closeConn();
            cmd.Dispose();
        }
        public void openConn()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void closeConn()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

    }
}

using GestionBibFormGhoudan.Db;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2.Services
{
    class HomeService
    {

        public  List<home> afficher()
        {
            List<home> homeList = new List<home>();
           MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT id,name,zone,place,status,x,y from home  where name != 'fridge'";
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=home; UID=root; PASSWORD=";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
                homeList.Add(new home(int.Parse(reader["id"].ToString()), reader["name"].ToString(), reader["zone"].ToString(), reader["status"].ToString(), int.Parse(reader["place"].ToString()), int.Parse(reader["x"].ToString()), int.Parse(reader["y"].ToString())));
            return homeList;
        }

        public  bool AfficherParIndex(int index)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from home where place="+index;

            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = sqlSelectAll;
            MyDA.SelectCommand = cmd;

            DataTable table = new DataTable();
            MyDA.Fill(table);

            if (table.Rows.Count == 1) return true;
            return false;
        }
        public int checkZoneAllu(String  Zone)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT count(*) as cc from home where zone= '" + Zone+"' and status like 'A' ";
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=home; UID=root; PASSWORD=";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read()) 
                if(checkzonevid(Zone)) return 0;
                else if(int.Parse(reader["cc"].ToString()) ==0) return -1;
            return 1;
        }
        public bool checkzonevid(String Zone)
        {

            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT count(*) as cc from home where zone= '" + Zone + "'";
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=home; UID=root; PASSWORD=";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
                if (int.Parse(reader["cc"].ToString()) == 0) return true;
            return false;
        }
        public String AfficherStatus(int index)
        {

            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT status from home where place=" + index;
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=home; UID=root; PASSWORD=";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            /*
            string sqlSelectAll = "SELECT status from home where place="+index;

            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = sqlSelectAll;
            MySqlDataReader reader = cmd.ExecuteReader();*/
            if ((reader.Read())) return reader["status"].ToString();
            return null;
        }

        public  bool Ajouter(home o)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "INSERT INTO home (name, zone,place,status,x,y)" +
                "VALUES(@name, @zone,@place,@status,@x,@y)";
            cmd.Parameters.AddWithValue("@name", o.Name);
            cmd.Parameters.AddWithValue("@zone", o.Zone);
            cmd.Parameters.AddWithValue("@place", o.Place);
            cmd.Parameters.AddWithValue("@status", o.Status);
            cmd.Parameters.AddWithValue("@x", o.X);
            cmd.Parameters.AddWithValue("@y", o.Y);
            cmd.ExecuteNonQuery();
            return true;
        }

        public  bool delete(int o)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "DELETE FROM home WHERE place=" + o;
            cmd.ExecuteNonQuery();
            return true;
        }

        public  bool Modifier(int id,String status)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "UPDATE home SET status=@status" +
                    " WHERE place=" + id;
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            return true;
        }
        public  bool ModifierAll(String Zone,String status)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "UPDATE home SET status=@status" +
                    " WHERE zone LIKE '" + Zone+"'";
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            return true;
        }
        public  bool killSwitch()
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "delete  from home where name != 'fridge'";
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}

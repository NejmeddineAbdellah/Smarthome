using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace p2.Services
{
    class ZoneService
    {
        public static List<Zone> afficher()
        {
            List<Zone> zoneList = new List<Zone>();
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT id,nom_zone,x_zone,y_zone,location_x,location_y from zone order by id";
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=home; UID=root; PASSWORD=";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {

                zoneList.Add(new Zone(int.Parse(reader["id"].ToString()), reader["nom_zone"].ToString(), Convert.ToInt32(reader["x_zone"].ToString()), Convert.ToInt32(reader["y_zone"].ToString()), Convert.ToInt32(reader["location_x"].ToString()), Convert.ToInt32(reader["location_y"].ToString()))) ;
            }
         
            return zoneList;
        }
    }
}

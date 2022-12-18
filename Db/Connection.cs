
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibFormGhoudan.Db
{
    class Connection
    {
        string parametres = "SERVER=localhost; DATABASE=home; UID=root; PASSWORD=";
        private static MySqlConnection maconnexion;

        public Connection()
        {
           maconnexion = new MySqlConnection(parametres);
           maconnexion.Open();
        }
        public static MySqlConnection getSqlConnection()
        {
            if (maconnexion != null)
                return maconnexion;
            else
                new Connection();
            return maconnexion;
        }
        public static MySqlCommand getMySqlCommand()
        {
             return maconnexion.CreateCommand();
        }
    }
}

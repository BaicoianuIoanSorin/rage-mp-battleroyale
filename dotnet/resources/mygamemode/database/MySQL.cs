using System; 
using System.IO;
using System.Reflection; 
using GTANetworkAPI;
using MySql.Data.MySqlClient;

namespace mygamemode.database
{
    public class MySQL
    {
        public bool IsConnectionSetup { get; set; }
        public MySqlConnection conn { get; set; }
        public String Host { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public String Database { get; set; }
        
        public MySQL()
        {
            this.Host = "127.0.0.1";
            this.Username = "root";
            this.Password = "";
            this.Database = "database";

            this.IsConnectionSetup = false;
            this.conn = null;

            InitConnection();
        }

        public void InitConnection() {
           if(!IsConnectionSetup)  {
                String SQLConnection = $"server={this.Host};password={this.Password};user={this.Username};database={this.Database};";
 
                using (conn = new MySqlConnection(SQLConnection))
                
                {
                conn.Open();
                Logs.INFO("Connection to MySQL established");
                }
            }
        }
    }
}
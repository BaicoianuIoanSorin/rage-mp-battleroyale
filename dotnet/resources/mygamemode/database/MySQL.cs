using System; 
using System.IO;
using System.Reflection; 
using GTANetworkAPI;
using MySql.Data.MySqlClient;

namespace mygamemode.database
{
    public class MySQL : Script
    {
        public static bool IsConnectionSetup = false;
        public static MySqlConnection conn = null;
        public String Host { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public String Database { get; set; }
        
        public MySQL()
        {
            this.Host = "localhost";
            this.Username = "root";
            this.Password = "";
            this.Database = "database";

            Logs.INFO("MySQL Started");
        }

        public static void InitConnection() {
            String filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SQLInfo.json");

            MySQL sql = new MySQL();

            if(File.Exists(filePath)) // file is found
            {
                    //TODO connection
            }
        }
    }
}
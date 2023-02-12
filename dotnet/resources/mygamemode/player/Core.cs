using GTANetworkAPI;
using MySql.Data.MySqlClient;
using System;
using mygamemode.database;

namespace mygamemode.player
{
    class Core : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void  OnResourceStart() {
            MySQL mySQL = new MySQL();
            string SQLString = $"CREATE TABLE IF NOT EXISTS `accounts` (" + 
                               $"`SQLID` INT(11) NOT NULL AUTO_INCREMENET," +
                               $"`Playername` VARCHAR(64) NOT NULL DEFAULT \"\", " + 
                               $"`Cash` INT(11) NOT  NULL DEFAULT '0'," + 
                               $"`Level` INT(11) NOT NULL DEFAULT '0'" + 
                               $"`Age` INT(11) NOT NULL DEFAULT '1'," +
                               $"`Health` INT(6) NOT NULL DEFAULT '1'" + 
                               $"PRIMARY KEY (SQLID));";
            if(mySQL.IsConnectionSetup) {
                try {
                    using (MySqlCommand command = new MySqlCommand(SQLString, mySQL.conn)) {
                    command.ExecuteNonQuery();
                    Logs.INFO("Creating Accounts database with success!");
                    }
                }
                catch (Exception e) {
                    Logs.ERROR(e.ToString());
                }
            }
        }
    }
}
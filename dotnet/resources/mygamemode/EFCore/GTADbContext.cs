using System; 
using System.Collections.Generic; 
using System.Reflection; 
using System.Text; 
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Design;
using mygamemode.EFCore.model;

namespace mygamemode.EFCore
{
    public class GTADbContext : DbContext
    {
        // Connection string, more details below 
        private const string connectionString = "Server=localhost;Database=efcoretutorial;Uid=root;Pwd=";

        // Initialize a new MySQL connection with the given connection parameters 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString);
        }

        // Account model class created somewhere else 
        public DbSet<Account> Accounts { get; set; }
        
    }
}

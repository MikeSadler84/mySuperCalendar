using Microsoft.EntityFrameworkCore;

namespace myCalendar.Models{
    public class DataContext : DbContext{

        /*

        Class sets up the connection to DB,you specify (dbSets) which of your models will be tables on the DB
        Important:
        If you modify anything on your models, you need to run migrations:
        - dotnet ef migrations add <someName>
        - dotnet ef database update
        
        */

        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }
        //specify which models will become tables in the database
        public DbSet<Task> TasksTable {get; set;}
        //examples below
        // public DbSet<User> UsersTable {get; set;}
        // public DbSet<Product> ProductsTable {get; set;}
    }
}
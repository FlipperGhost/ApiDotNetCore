using Microsoft.EntityFrameworkCore;
using apiRestFul.Models;

namespace apiRestFul.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        public DbSet<Funcionario> funcionario {get; set; }
        
        public DbSet<Departamento> departamento {get; set; }


    
    }










}
using Microsoft.EntityFrameworkCore;
using Dio_bootcamp_Pottencial_dotnet.Models;

namespace Dio_bootcamp_Pottencial_dotnet.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext> options) : base(options)
        {

        }

        public DbSet<Venda> Vendas {get; set;}
    }

    
}
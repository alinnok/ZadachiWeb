using Microsoft.EntityFrameworkCore;
using ZadachiData.Entities;


namespace ZadachiData
{
    public class ZadachiContext : DbContext
    {
        public DbSet<Zadacha> Zadachi {get; set; }
        public ZadachiContext(DbContextOptions options) : base(options)
        {
            
        }
    }

}
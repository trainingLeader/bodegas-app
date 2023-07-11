using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class BodegasContext : DbContext
{
     public BodegasContext(DbContextOptions<BodegasContext> options) : base(options)
    {
    }       
}

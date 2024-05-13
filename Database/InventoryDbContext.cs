using Microsoft.EntityFrameworkCore; 

public class InventoryDbContext : DbContext
{
    public DbSet<InventoryItems> Items {get; set; }
}
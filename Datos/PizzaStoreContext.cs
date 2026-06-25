using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

// se conecta a la base de datos y me devuelve la tabla specials.
// El contexto es el objeto que te permite hacer operaciones sobre la base de datos sin escribir SQL manualmente.
public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}
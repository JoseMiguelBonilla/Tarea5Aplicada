using Microsoft.EntityFrameworkCore;
using Tarea5Aplicada.Shared;

namespace Tarea5Aplicada.Server.DAL;

public class TicketContext : DbContext
{
    public TicketContext(DbContextOptions<TicketContext> options) :
     base(options){}
 
    public DbSet<Tickets> Tickets { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
}
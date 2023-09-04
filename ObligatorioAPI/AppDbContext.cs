using Microsoft.EntityFrameworkCore;
using Domain;
using obligatorio.Domain;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Color> Colores { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ProductoColor> ProductoColores { get; set; }
    public DbSet<Carrito> Carrito { get; set; }
    public DbSet<Promocion> Promociones { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<DetalleCompra> DetalleCompras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración para la tabla Usuarios
        modelBuilder.Entity<Usuario>()
            .HasIndex(u => u.CorreoElectronico)
            .IsUnique();

        // Configuración para la tabla DetalleCompras (clave primaria compuesta)
        modelBuilder.Entity<DetalleCompra>()
            .HasKey(dc => new { dc.IDCompra, dc.IDProducto });

        modelBuilder.Entity<ProductoColor>()
            .HasKey(pc => new { pc.ProductoID, pc.ColorID });

        modelBuilder.Entity<ProductoColor>()
            .HasOne(pc => pc.Producto)
            .WithMany(p => p.ProductoColores)
            .HasForeignKey(pc => pc.ProductoID);

        modelBuilder.Entity<ProductoColor>()
            .HasOne(pc => pc.Color)
            .WithMany(c => c.ProductoColores)
            .HasForeignKey(pc => pc.ColorID);
    }
}

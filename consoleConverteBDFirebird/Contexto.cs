namespace consoleConverteBDFirebird
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=bancoLW")
        {
        }

        public virtual DbSet<Produto> produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.Id_produto);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Id_fiscal)
                .HasColumnType("varchar")
                .HasMaxLength(10);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(60);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Barras)
                .HasColumnType("varchar")
                .HasMaxLength(48);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Aplicacao)
                .HasColumnType("varchar")
                .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Localizacao)
                .HasColumnType("varchar")
                .HasMaxLength(6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.NOriginal)
                .HasColumnType("varchar")
                .HasMaxLength(15);

            modelBuilder.Entity<Produto>()
                .Property(e => e.NFabrica)
                .HasColumnType("varchar")
                .HasMaxLength(15);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Grupo)
                .HasColumnType("varchar")
                .HasMaxLength(30);

            modelBuilder.Entity<Produto>()
                .Property(e => e.SubGrupo)
                .HasColumnType("varchar")
                .HasMaxLength(30);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Unidade)
                .HasColumnType("varchar")
                .HasMaxLength(3);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Quantidade)
                .HasColumnType("varchar")
                .HasMaxLength(7);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Minimo)
                .HasColumnType("varchar")
                .HasMaxLength(7);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Custo)
                .HasColumnType("varchar")
                .HasMaxLength(7);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Margem)
                .HasColumnType("varchar")
                .HasMaxLength(7);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Suplente1)
                .HasColumnType("varchar")
                .HasMaxLength(25);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Suplente2)
                .HasColumnType("varchar")
                .HasMaxLength(25);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Suplente3)
                .HasColumnType("varchar")
                .HasMaxLength(25);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Suplente4)
                .HasColumnType("varchar")
                .HasMaxLength(25);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Suplente5)
                .HasColumnType("varchar")
                .HasMaxLength(25);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Suplente6)
                .HasColumnType("varchar")
                .HasMaxLength(25);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Fornecedor)
                .HasColumnType("varchar")
                .HasMaxLength(60);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Adicional)
                .HasColumnType("varchar")
                .HasMaxLength(200);

            modelBuilder.Entity<Produto>()
                .ToTable("produtos");
        }
    }
}

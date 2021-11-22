using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DesperdicioZero.Model
{
    public partial class DesperdicioZeroContext : DbContext
    {
        public DesperdicioZeroContext()
        {
        }

        public DesperdicioZeroContext(DbContextOptions<DesperdicioZeroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoPedido> ProdutoPedido { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=DESKTOP-27I7PJN\\SQLEXPRESS; Database=DESPERDICIOZERO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasKey(e => e.Idestoque)
                    .HasName("PK__ESTOQUE__473A7FC6D96FE68C");

                entity.ToTable("ESTOQUE");

                entity.Property(e => e.Idestoque).HasColumnName("IDESTOQUE");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Estoque)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_ID_USUARIO");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.Idpedido)
                    .HasName("PK__PEDIDO__769F9E4E5D17EB40");

                entity.ToTable("PEDIDO");

                entity.Property(e => e.Idpedido).HasColumnName("IDPEDIDO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_ID_USUARIO_PEDIDO");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Idproduto)
                    .HasName("PK__PRODUTO__ED0C59338AB1BA0D");

                entity.ToTable("PRODUTO");

                entity.Property(e => e.Idproduto).HasColumnName("IDPRODUTO");

                entity.Property(e => e.DataDeValidade)
                    .HasColumnName("DATA_DE_VALIDADE")
                    .HasColumnType("date");

                entity.Property(e => e.Desconto)
                    .HasColumnName("DESCONTO")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasColumnType("text");

                entity.Property(e => e.IdEstoque).HasColumnName("ID_ESTOQUE");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasColumnType("text");

                entity.Property(e => e.Prazo).HasColumnName("PRAZO");

                entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                entity.Property(e => e.ValorCompra)
                    .HasColumnName("VALOR_COMPRA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorVenda)
                    .HasColumnName("VALOR_VENDA")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdEstoqueNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdEstoque)
                    .HasConstraintName("FK_ID_ESTOQUE");
            });

            modelBuilder.Entity<ProdutoPedido>(entity =>
            {
                entity.HasKey(e => e.IdprodutoPedido)
                    .HasName("PK__PRODUTO___75D45879A7C934AB");

                entity.ToTable("PRODUTO_PEDIDO");

                entity.Property(e => e.IdprodutoPedido).HasColumnName("IDPRODUTO_PEDIDO");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdProduto).HasColumnName("ID_PRODUTO");

                entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.ProdutoPedido)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_ID_PRODUTO_PEDIDO");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.ProdutoPedido)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_ID_PROUTO_PRODUTO");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.Idtipo)
                    .HasName("PK__TIPO__E57FEC1019209027");

                entity.ToTable("TIPO");

                entity.Property(e => e.Idtipo).HasColumnName("IDTIPO");

                entity.Property(e => e.Tipo1)
                    .HasColumnName("TIPO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__USUARIO__98242AA9E693B472");

                entity.ToTable("USUARIO");

                entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");

                entity.Property(e => e.Documento)
                    .HasColumnName("DOCUMENTO")
                    .HasColumnType("text");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasColumnName("ENDERECO")
                    .HasColumnType("text");

                entity.Property(e => e.IdTipo).HasColumnName("ID_TIPO");

                entity.Property(e => e.Senha)
                    .HasColumnName("SENHA")
                    .HasColumnType("text");

                entity.Property(e => e.Telefone)
                    .HasColumnName("TELEFONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_ID_TIPO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

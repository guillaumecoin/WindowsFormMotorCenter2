using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WindowsFormMotorCenter2.Models
{
    public partial class motorcenterContext : DbContext
    {
        public motorcenterContext()
        {
        }

        public motorcenterContext(DbContextOptions<motorcenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achat> Achats { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Voiture> Voitures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=motorcenter;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Achat>(entity =>
            {
                entity.HasKey(e => e.IdAchat)
                    .HasName("PRIMARY");

                entity.ToTable("achat");

                entity.HasIndex(e => e.IdClient, "Achat_Client_FK");

                entity.HasIndex(e => e.IdVoiture, "Achat_Voiture0_FK");

                entity.Property(e => e.IdAchat)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("idAchat");

                entity.Property(e => e.DateAchat)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAchat");

                entity.Property(e => e.IdClient)
                    .HasColumnType("int(11)")
                    .HasColumnName("idClient");

                entity.Property(e => e.IdVoiture)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_Voiture");

                entity.Property(e => e.PrixCatalogue)
                    .HasColumnType("int(11)")
                    .HasColumnName("prix_Catalogue");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Achats)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Achat_Client_FK");

                entity.HasOne(d => d.IdVoitureNavigation)
                    .WithMany(p => p.Achats)
                    .HasForeignKey(d => d.IdVoiture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Achat_Voiture0_FK");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PRIMARY");

                entity.ToTable("client");

                entity.Property(e => e.IdClient)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("idClient");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("adresse");

                entity.Property(e => e.CodePostal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("codePostal");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prenom");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("tel");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ville");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.HasKey(e => e.IdEmploye)
                    .HasName("PRIMARY");

                entity.ToTable("employe");

                entity.Property(e => e.IdEmploye)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id_Employe");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomEmploye)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom_Employe");
            });

            modelBuilder.Entity<Voiture>(entity =>
            {
                entity.HasKey(e => e.IdVoiture)
                    .HasName("PRIMARY");

                entity.ToTable("voiture");

                entity.Property(e => e.IdVoiture)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_Voiture");

                entity.Property(e => e.Carburant)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("carburant");

                entity.Property(e => e.CriterePolution)
                    .HasColumnType("int(11)")
                    .HasColumnName("criterePolution");

                entity.Property(e => e.Finition)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("finition");

                entity.Property(e => e.Marque)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("marque");

                entity.Property(e => e.Modele)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("modele");

                entity.Property(e => e.NbPortes)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPortes");

                entity.Property(e => e.Peinture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("peinture");

                entity.Property(e => e.PrixAchat)
                    .HasColumnType("int(11)")
                    .HasColumnName("prixAchat");

                entity.Property(e => e.PuissanceFiscale)
                    .HasColumnType("int(11)")
                    .HasColumnName("puissanceFiscale");

                entity.Property(e => e.TypeTransmission)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("typeTransmission");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

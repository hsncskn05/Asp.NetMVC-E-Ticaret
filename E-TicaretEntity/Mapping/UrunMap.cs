using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.Mapping
{
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .IsRequired()
                .HasMaxLength(1500);

            // Table & Column Mappings
            this.ToTable("Urun");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.AlisFiyat).HasColumnName("AlisFiyat");
            this.Property(t => t.SatisFiyat).HasColumnName("SatisFiyat");
            this.Property(t => t.EklenmeTarih).HasColumnName("EklenmeTarih");
            this.Property(t => t.SonKullanmaTarih).HasColumnName("SonKullanmaTarih");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.MarkaID).HasColumnName("MarkaID");

            // Relationships
            this.HasOptional(t => t.Kategori)
                .WithMany(t => t.Uruns)
                .HasForeignKey(d => d.KategoriID);
            this.HasOptional(t => t.Marka)
                .WithMany(t => t.Uruns)
                .HasForeignKey(d => d.MarkaID);

        }
    }
}

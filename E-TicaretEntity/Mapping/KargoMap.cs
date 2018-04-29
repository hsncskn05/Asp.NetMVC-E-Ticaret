using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.Mapping
{
    public class KargoMap : EntityTypeConfiguration<Kargo>
    {
        public KargoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SirketAdi)
                .HasMaxLength(550);

            this.Property(t => t.Adres)
                .HasMaxLength(505);

            this.Property(t => t.Telefon)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.WebSite)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kargo");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.WebSite).HasColumnName("WebSite");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}

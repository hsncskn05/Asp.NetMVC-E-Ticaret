using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.Mapping
{
    public class MusteriAdreMap : EntityTypeConfiguration<MusteriAdre>
    {
        public MusteriAdreMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Adres)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MusteriAdres");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Adi).HasColumnName("Adi");

            // Relationships
            this.HasRequired(t => t.Musteri)
                .WithMany(t => t.MusteriAdres)
                .HasForeignKey(d => d.MusteriID);

        }
    }
}

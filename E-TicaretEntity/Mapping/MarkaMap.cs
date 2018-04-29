using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.Mapping
{
    public class MarkaMap : EntityTypeConfiguration<Marka>
    {
        public MarkaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Marka");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.ResimID).HasColumnName("ResimID");

            // Relationships
            this.HasOptional(t => t.Resim)
                .WithMany(t => t.Markas)
                .HasForeignKey(d => d.ResimID);

        }
    }
}

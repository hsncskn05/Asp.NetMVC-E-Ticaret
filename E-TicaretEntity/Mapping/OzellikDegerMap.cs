using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.Mapping
{
    public class OzellikDegerMap : EntityTypeConfiguration<OzellikDeger>
    {
        public OzellikDegerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Adi)
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OzellikDeger");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.OzellikTipID).HasColumnName("OzellikTipID");

            // Relationships
            this.HasOptional(t => t.OzellikTip)
                .WithMany(t => t.OzellikDegers)
                .HasForeignKey(d => d.OzellikTipID);

        }
    }
}

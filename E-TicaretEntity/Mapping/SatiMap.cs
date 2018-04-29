using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.Mapping
{
    public class SatiMap : EntityTypeConfiguration<Sati>
    {
        public SatiMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.KargoTakipNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Satis");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");
            this.Property(t => t.SatisTarihi).HasColumnName("SatisTarihi");
            this.Property(t => t.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(t => t.Sepettemi).HasColumnName("Sepettemi");
            this.Property(t => t.KargoID).HasColumnName("KargoID");
            this.Property(t => t.SiparisDurumID).HasColumnName("SiparisDurumID");
            this.Property(t => t.KargoTakipNo).HasColumnName("KargoTakipNo");

            // Relationships
            this.HasRequired(t => t.Kargo)
                .WithMany(t => t.Satis)
                .HasForeignKey(d => d.KargoID);
            this.HasOptional(t => t.Musteri)
                .WithMany(t => t.Satis)
                .HasForeignKey(d => d.MusteriID);
            this.HasRequired(t => t.SiparisDurum)
                .WithMany(t => t.Satis)
                .HasForeignKey(d => d.SiparisDurumID);

        }
    }
}

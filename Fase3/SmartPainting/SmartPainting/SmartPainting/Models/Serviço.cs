namespace SmartPainting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public partial class Serviço
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serviço()
        {
            Materials = new HashSet<Material>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string email_cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string email_pintor { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int estado { get; set; }

        public double preço { get; set; }

        public int local { get; set; }

        [Required]
        [StringLength(50)]
        public string superfície { get; set; }

        public double área { get; set; }

        public int? numeração { get; set; }

        [StringLength(50)]
        public string comentário { get; set; }

        [Column(TypeName = "image")]
        public byte[] fotografia { get; set; }

        public int tipo_de_pagamento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal referência_multibanco { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Pintor Pintor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materials { get; set; }
    }

    public class ServicosContext : DbContext
    {
        public DbSet<Serviço> Serviço { get; set; }
    }
}

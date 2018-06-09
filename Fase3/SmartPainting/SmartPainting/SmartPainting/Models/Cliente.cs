namespace SmartPainting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Serviço = new HashSet<Serviço>();
            Pintors = new HashSet<Pintor>();
        }

        [Key]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string morada { get; set; }

        [Column(TypeName = "numeric")]
        public decimal telefone { get; set; }

        [Column(TypeName = "image")]
        public byte[] fotografia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Serviço> Serviço { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pintor> Pintors { get; set; }
    }
}

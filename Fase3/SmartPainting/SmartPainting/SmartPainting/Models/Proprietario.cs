namespace SmartPainting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using SmartPainting.Models;

    [Table("Proprietario")]
    public partial class Proprietario
    {
        [Key]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }


    }

    public class ProprietarioContext : DbContext
    {

        public DbSet<Proprietario> proprietarios { get; set; }

    }
}

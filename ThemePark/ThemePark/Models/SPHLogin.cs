namespace ThemePark
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThemePark.SPHLogin")]
    public partial class SPHLogin
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string LoginEmail { get; set; }

        [StringLength(20)]
        public string Pswd { get; set; }

        public long? SPH_ID { get; set; }

        public virtual SeasonPassHolder SeasonPassHolder { get; set; }
    }
}

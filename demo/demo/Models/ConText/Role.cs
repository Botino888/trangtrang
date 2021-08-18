namespace demo.Models.ConText
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDRole { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }
    }
}

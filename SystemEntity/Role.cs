using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity4.SystemEntity
{
    class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string Name { get; set; }

        public virtual List<User> Users { get; set; } = new List<User>();

        public virtual List<RoleIntermediate> RoleIntermediates { get; set; } = new List<RoleIntermediate>();
    }
}

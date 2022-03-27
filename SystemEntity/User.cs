using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity4.SystemEntity
{
    class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public Profile Profile { get; set; }

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        [ForeignKey("RoleId")]
        public int RoleId { get; set; }

        public virtual List<Role> Role { get; set; } = new List<Role>();

        public virtual List<RoleIntermediate> RoleIntermediates { get; set; } = new List<RoleIntermediate>();

        [ForeignKey("GroupsId")]
        public int GroupsId { get; set; }

        public virtual List<Groups> Groups { get; set; } = new List<Groups>();

        public virtual List<GroupsIntermediate> GroupsIntermediates { get; set; } = new List<GroupsIntermediate>();
    }
}

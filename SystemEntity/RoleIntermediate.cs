using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.SystemEntity
{
    class RoleIntermediate
    {
        public int RoleId { get; set; }

        public Role Role { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}

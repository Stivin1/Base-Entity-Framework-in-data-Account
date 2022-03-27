using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.SystemEntity
{
    class GroupsIntermediate
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int GroupsId { get; set; }

        public Groups Groups { get; set; }
    }
}

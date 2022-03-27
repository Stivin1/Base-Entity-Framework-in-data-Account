using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity4.SystemEntity
{
    class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("UserId")]
        public int ThemeId { get; set; }

        public Theme Theme { get; set; }

        public AddresSent AddresSent { get; set; }

        public string MessageText { get; set; }

        public string DateCreate { get; set; }

        public bool IsRead { get; set; }

        public bool IsHidden { get; set; }
    }
}

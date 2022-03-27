using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity4.SystemEntity
{
    class AddresSent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("MessageId")]
        public int MessageId { get; set; }

        public Message Message { get; set; }

        public int SenderId { get; set; }

        public int RecipientId { get; set; }

        public string DateCreate { get; set; }
    }
}

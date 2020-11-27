using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Comp586ProjectServer.Models
{
    [Table("BoardGamePlayer")]
    public partial class BoardGamePlayer
    {
        [Key]
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int BoardGameId { get; set; }
    }
}

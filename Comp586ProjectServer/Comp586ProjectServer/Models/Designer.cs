using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Comp586ProjectServer.Models
{
    [Table("Designer")]

    public partial class Designer
    {
        public Designer()
        {
            BoardGames = new HashSet<BoardGame>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(BoardGame.Designer))]
        public virtual ICollection<BoardGame> BoardGames { get; set; } 

    }
}

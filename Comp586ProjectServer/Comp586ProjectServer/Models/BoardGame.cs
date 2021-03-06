﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Comp586ProjectServer.Models
{
    [Table("BoardGame")]

    public partial class BoardGame
    {       
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("DesignerId")]
        public int DesignerId { get; set; }        

        [ForeignKey(nameof(DesignerId))]
        [InverseProperty("BoardGames")]
        public virtual Designer Designer { get; set; }


    }
}

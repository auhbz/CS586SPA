using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Comp586ProjectServer.ViewModels
{
    public partial class DesignersWithBoardGames
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> BoardGames { get; set; }

    }
}

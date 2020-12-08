using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Comp586ProjectServer.ViewModels
{
    public partial class BoardGamesViewModel
    {        
        public int Id { get; set; }
        public string Name { get; set; }                
    }
}

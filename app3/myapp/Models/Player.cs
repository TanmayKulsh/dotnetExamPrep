using System;
using System.Collections.Generic;

#nullable disable

namespace myapp.Models
{
    public partial class Player
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sport { get; set; }
        public string Phone { get; set; }
    }
}

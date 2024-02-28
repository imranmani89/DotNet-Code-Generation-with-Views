using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? PostalCode { get; set; }
    }
}

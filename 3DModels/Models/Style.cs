using System;
using System.Collections.Generic;

namespace _3DModels.Models
{
    public partial class Style
    {
        public int StyleId { get; set; }
        public string? StyleName { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        public int? TeacupId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}


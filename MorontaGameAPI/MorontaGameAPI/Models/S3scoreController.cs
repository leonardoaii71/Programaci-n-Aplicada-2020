using System;
using System.Collections.Generic;

namespace MorontaGameAPI.Models
{
    public partial class S3scoreController
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime CreacionDate { get; set; }
    }
}

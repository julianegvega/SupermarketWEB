﻿namespace SupermarketWEB.Models
{
    public class Paymode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observation { get; set; }
        public ICollection<Invoice>? Invoices { get; set; } = default!;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Entitis
{
    public class CarWorkshop
    {
        public int Id { get; set; }
        public string Name { get; set; } = default;
        public string? Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public CarWorkshopContactDetails ContactDetails { get; set; } = default;
        public string EncodedName { get; private set; }
        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");
        public string? About { get; set; }
    }
}

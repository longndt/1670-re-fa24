﻿using System.Collections;
using System.Collections.Generic;

namespace OneToMany.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

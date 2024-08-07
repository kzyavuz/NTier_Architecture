﻿using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WindowsUI.ViewModels
{
    public class CategoryViewModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}

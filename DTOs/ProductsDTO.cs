﻿namespace KTUN_Final_Year_Project.DTOs
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProductsDTO
    {
#nullable disable
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Barcode { get; set; }

        public bool Status { get; set; } = true;

        public virtual StoresDTO Stores { get; set; }

        public virtual CategoriesDTO Categories { get; set; }
    }
}

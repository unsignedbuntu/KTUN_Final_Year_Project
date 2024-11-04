﻿namespace KTUN_Final_Year_Project.ResponseDTOs
{
    using KTUN_Final_Year_Project.DTOs;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class CustomerFeedbackResponseDTO
    {
#nullable disable

        public int UserID { get; set; }

        public int ProductID { get; set; }

        [ForeignKey("UserID")]

        public virtual UsersDTO Users { get; set; }

        [ForeignKey("ProductID")]

        public virtual ProductsDTO Products { get; set; }

        public string FeedbackText { get; set; }

        public int Rating { get; set; }

        public DateTime FeedbackDate { get; set; } = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);

    }
}
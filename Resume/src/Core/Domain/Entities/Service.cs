﻿namespace Resume.Models.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public required string CssClass { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}

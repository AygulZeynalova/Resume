﻿using Resume.Models.Entities.Enums;

namespace Resume.Models.Entities
{
    public class PersonSkill
    {
        public int PersonId { get; set; }
        public int SkillId { get; set; }
        public DisplayMode Mode { get; set; }
        public byte Percentage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Person? Person { get; set; }
        public Skill? Skill { get; set; }
    }
}

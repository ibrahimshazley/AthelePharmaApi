using System;
using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Entities
{
    public partial class HrExperienceCategories
    {
        public string ExperienceCategoryId { get; set; }
        public string ExperienceCategoryName { get; set; }
        public string ExperienceCategoryNameEn { get; set; }
        public string ExperienceCategoryNameConv { get; set; }
        public string InsUser { get; set; }
        public DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte RecStatus { get; set; }
        public decimal Id { get; set; }
        public string ExperienceCategoryCode { get; set; }
    }
}

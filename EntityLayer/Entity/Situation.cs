﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entity
{
    public class Situation
    {
        [Key]
        public int SituationId { get; set; }
        public string SituationName { get; set; }
        public bool Status { get; set; }
        public virtual List<Type> Types { get; set; }
        
    }
}

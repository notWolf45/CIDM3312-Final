using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CIDM3312_Final.Models
{
    public class Hunter
    {
        public int HunterID {get;set;}
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Name {get; set;}
        [Display(Name = "HR")]
        [Required]
        public int HRank {get; set;}
        [Display(Name = "MR")]
        [Required]
        public int MRank {get; set;}
        [Display(Name = "Total Damage")]
        [Required]
        public int TDmg {get; set;}
        public List<HuntersHunt> HuntersHunt {get; set;}
    }
}
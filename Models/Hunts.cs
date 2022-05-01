using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CIDM3312_Final.Models
{
    public class Hunt
    {
        public int HuntID {get;set;}
         [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Monster {get; set;}
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string H1Name {get; set;}
        [Required]
        public int H1Dmg {get; set;}
        [StringLength(60, MinimumLength = 2)]
        public string H2Name {get; set;}
        public int H2Dmg {get; set;}
        [StringLength(60, MinimumLength = 2)]
        public string H3Name {get; set;}
        public int H3Dmg {get; set;}
        [StringLength(60, MinimumLength = 2)]
        public string H4Name {get; set;}
        public int H4Dmg {get; set;}
        public List<HuntersHunt> HuntersHunt {get; set;}
    }

    public class HuntersHunt
    {
        public int HunterID {get; set;}
        public int HuntID {get; set;}
        public Hunter Hunter {get; set;}
        public Hunt Hunt {get; set;}

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootBall.Models
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int MatchID { get; set; }

        [Required]
        public string TeamName1 { get; set; }

        [Required]

        public string TeamName2 { get; set; }

        [Required]

        public string Status { get; set; }


        public string WinningTeam { get; set; }

        [Required]

        public int Points { get; set; }

    }
}
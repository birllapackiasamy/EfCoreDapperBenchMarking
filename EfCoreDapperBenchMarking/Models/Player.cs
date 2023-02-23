using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperEFCorePerformanceBenchmarks.Models
{
    [Table("Player")]
    public partial class Player
    {
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string LastName { get; set; }
        public virtual Team Team { get; set; }
        public int TeamId { get; set; }
    }
}
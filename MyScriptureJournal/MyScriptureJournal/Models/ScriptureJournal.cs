using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class ScriptureJournal
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [Display(Name = "Chapter and Verse")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ChapterVerse { get; set; }

        [StringLength(400, MinimumLength = 20)]
        [Required]
        public string Notes { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}

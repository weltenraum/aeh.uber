using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aeh.uber.Models
{
    public class SkillGroupViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool SkillsContainingLevel { get; set; }


        public List<SkillViewModel> Skills { get; set; }

        public string AboutMeId { get; set; }
        public AboutMeViewModel AboutMe { get; set; }
    }
}

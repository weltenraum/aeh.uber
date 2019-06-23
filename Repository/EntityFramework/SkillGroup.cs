using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aeh.uber.Repository.EntityFramework
{
    public class SkillGroup
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool SkillsContainingLevel { get; set; }


        public List<Skill> Skills { get; set; }

        public string AboutMeId { get; set; }
        public AboutMe AboutMe { get; set; }
    }
}

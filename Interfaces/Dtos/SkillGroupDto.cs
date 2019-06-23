using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aeh.uber.Interfaces.Dtos
{
    public class SkillGroupDto
    {
       public int Id { get; set; }
        public string Description { get; set; }
        public bool SkillsContainingLevel { get; set; }


        public List<SkillDto> Skills { get; set; }

        public string AboutMeId { get; set; }
        public AboutMeDto AboutMe { get; set; }

    }
}

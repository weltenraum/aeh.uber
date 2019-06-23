using System.Collections.Generic;

namespace aeh.uber.Models
{
    public class SkillViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public int? Level { get; set; }


        public int SkillGroupId { get; set; }
        public SkillGroupViewModel SkillGroup { get; set; }
    }
}
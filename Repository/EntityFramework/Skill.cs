using System.Collections.Generic;

namespace aeh.uber.Repository.EntityFramework
{
    public class Skill
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public int? Level { get; set; }


        public int SkillGroupId { get; set; }
        public SkillGroup SkillGroup { get; set; }
    }
}
using System.Collections.Generic;

namespace aeh.uber.Interfaces.Dtos
{
    public class SkillDto
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public int? Level { get; set; }


        public int SkillGroupId { get; set; }
        public SkillGroupDto SkillGroup { get; set; }
    }
}
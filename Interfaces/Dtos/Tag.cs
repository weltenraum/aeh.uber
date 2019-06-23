using System.Collections.Generic;

namespace aeh.uber.Interfaces.Dtos
{
    public class TagDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ExperienceId { get; set; }
        public ExperienceDto Experience { get; set; }
    }
}
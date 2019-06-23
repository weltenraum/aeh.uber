using System.Collections.Generic;

namespace aeh.uber.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ExperienceId { get; set; }
        public ExperienceViewModel Experience { get; set; }
    }
}
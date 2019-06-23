using System.Collections.Generic;

namespace aeh.uber.Repository.EntityFramework
{
    public class Keytopic
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}
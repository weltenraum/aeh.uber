using System.Collections.Generic;

namespace aeh.uber.Models
{
    public class ExperienceViewModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Until { get; set; }
        public string Heading { get; set; }
        public string Subheading { get; set; }
        public string Description { get; set; }
        public string KeytopicHeading { get; set; }
        public string TagHeading { get; set; }

        public IList<KeytopicViewModel> Keytopics { get; set; }
        public IList<TagViewModel> Tags { get; set; }


        public string AboutMeId { get; set; }
        public AboutMeViewModel AboutMe { get; set; }


    }
}
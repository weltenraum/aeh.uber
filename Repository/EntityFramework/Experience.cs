using System.Collections.Generic;

namespace aeh.uber.Repository.EntityFramework
{
    public class Experience
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Until { get; set; }
        public string Heading { get; set; }
        public string Subheading { get; set; }
        public string Description { get; set; }
        public string KeytopicHeading { get; set; }
        public string TagHeading { get; set; }

        public IList<Keytopic> Keytopics { get; set; }
        public IList<Tag> Tags { get; set; }


        public string AboutMeId { get; set; }
        public AboutMe AboutMe { get; set; }


    }
}
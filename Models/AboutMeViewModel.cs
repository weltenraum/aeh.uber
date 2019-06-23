using System.Collections.Generic;

namespace aeh.uber.Models
{
    public class AboutMeViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public string Jobtitle { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Cellphone { get; set; }

        public string CellPhoneLink { get
        {
            return "tel:" + Cellphone.Replace("(0)", "").Replace("-", "").Replace(" ", "").Trim();
        } }

        public string Messenger { get; set; }
        public string LocationDescription { get; set; }
        public string LocationLink { get; set; }
        public string AboutHeading { get; set; }
        public string AboutContent { get; set; }

        public List<ExperienceViewModel> Experiences { get; set; }
        public List<SkillGroupViewModel> SkillGroups { get; set; }

    }
}
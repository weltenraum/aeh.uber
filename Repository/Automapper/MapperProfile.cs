using aeh.uber.Interfaces.Dtos;
using aeh.uber.Models;
using aeh.uber.Repository.EntityFramework;
using AutoMapper;

namespace aeh.uber.Repository
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AboutMe, AboutMeDto>().ReverseMap();
            CreateMap<Experience, ExperienceDto>().ReverseMap();
            CreateMap<Keytopic, KeytopicDto>().ReverseMap();
            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<SkillGroup, SkillGroupDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();

            CreateMap<AboutMeDto, AboutMeViewModel>().ReverseMap();
            CreateMap<ExperienceDto, ExperienceViewModel>().ReverseMap();
            CreateMap<KeytopicDto, KeytopicViewModel>().ReverseMap();
            CreateMap<TagDto, TagViewModel>().ReverseMap();
            CreateMap<SkillGroupDto, SkillGroupViewModel>().ReverseMap();
            CreateMap<SkillDto, SkillViewModel>().ReverseMap();

        }
    }
}   
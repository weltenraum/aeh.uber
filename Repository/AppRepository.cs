using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aeh.uber.Interfaces.Dtos;
using aeh.uber.Repository.EntityFramework;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace aeh.uber.Repository
{
    public class AppRepository : Interfaces.IAppRepository
    {
        private readonly UberContext _context;

        private readonly IMapper _mapper;

        public AppRepository(UberContext context)
        {
            _context = context;
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperProfile());
            }).CreateMapper();
        }
        

        public async Task<AboutMeDto> GetAboutMeEntryAsync(string id)
        {
            var rawItem = await _context.AboutMes
                .Include(aboutMe => aboutMe.Experiences).ThenInclude(experience => experience.Keytopics)
                .Include(aboutMe => aboutMe.Experiences).ThenInclude(experience => experience.Tags)
                .Include(aboutMe => aboutMe.SkillGroups).ThenInclude(skillGroup => skillGroup.Skills)
                .Where(aboutMe => aboutMe.Id == id)
                .FirstOrDefaultAsync();

            var result = _mapper.Map<AboutMeDto>(rawItem);

            return result;
        }
    }
}
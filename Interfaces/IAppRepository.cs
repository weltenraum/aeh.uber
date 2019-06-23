using System.Collections.Generic;
using System.Threading.Tasks;
using aeh.uber.Interfaces.Dtos;

namespace aeh.uber.Interfaces
{
    public interface IAppRepository
    {
        Task<AboutMeDto> GetAboutMeEntryAsync(string id);
        //Task<IList<ExperienceGroupDto>> GetExperiencesAsync(string aboutMeId);
        //Task<IList<SkillGroupDto>> GetSkillsAsync(string aboutMeId);
    
        /*
        Task StoreExperienceAsync(ExperienceDto entry);
        Task StoreSkillAsync(SkillDto entry);
    
        Task DeleteExperienceAsync(int id);
        Task DeleteSkillAsync(int id);
        */
    }
}
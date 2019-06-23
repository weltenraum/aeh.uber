using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aeh.uber.Interfaces;
using aeh.uber.Interfaces.Dtos;

namespace aeh.uber.AppLogic
{
    public class AppLogicV1 : Interfaces.IAppLogic
    {
        private readonly IAppRepository _appRepository;

        public AppLogicV1(Interfaces.IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public Task<AboutMeDto> GetAboutMeEntryAsync(string id)
        {
            try
            {
                return _appRepository.GetAboutMeEntryAsync(id);
            }
            catch (Exception ex)
            {
                throw new Interfaces.Exceptions.GeneralUberException(ex.Message, ex);
            }
        }
    }
}
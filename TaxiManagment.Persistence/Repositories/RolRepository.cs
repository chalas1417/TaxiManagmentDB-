using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxiManagment.Domia.Entities;
using TaxiManagment.Domia.Interface;
using TaxiManagment.Domia.Models;
using TaxiManagment.Persistence.Context;
using TaxiManagment.Persistence.Repository;

namespace TaxiManagment.Persistence.Repositories
{
    public class RolRepository : BaseRepository<Rol, int>, IRolRepository
    {
        private readonly TaxiDBContext _taxiDBContext;
        private readonly ILogger<RolRepository> _logger;
        private readonly IConfiguration _configuration;

        public RolRepository(TaxiDBContext taxiDBContext,
                                ILogger<RolRepository> logger,
                                IConfiguration configuration) : base(taxiDBContext)
        {
            _taxiDBContext = taxiDBContext;
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<List<RolModels>> GetRolByUserRolId(int userRolId)
        {
            List<RolModels> result = new();

            try
            {
                result= await RolByUserIRold(userRolId);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;

        }

        private async Task<List<RolModels>> RolByUserIRold(int userRolId)
        {
            return await (from rol in _taxiDBContext.Rols
                          join user in _taxiDBContext.Users
                          on userRolId equals user.TaxiId
                          where rol.Delete == false
                          && rol.UserRolId == user.Id
                          select new RolModels()
                          {
                              Id = rol.Id
                          }).ToListAsync();
        }
    }
}

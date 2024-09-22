using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxiManagment.Domia.Entities;
using TaxiManagment.Domia.Models;
using TaxiManagment.Persistence.Context;
using TaxiManagment.Persistence.Interfaces;
using TaxiManagment.Persistence.Repository;

namespace TaxiManagment.Persistence.Repositories
{
    public class CarRepository : BaseRepository<Car, int>, ICarRepository
    {
        private readonly TaxiDBContext _taxiDBContext;
        private readonly ILogger<CarRepository> _logger;
        private readonly IConfiguration _configuration;

        public CarRepository(TaxiDBContext taxiDBContext,
                                ILogger<CarRepository> _logger,
                                IConfiguration configuration) : base(taxiDBContext)
        {
            this._taxiDBContext = _taxiDBContext;
            this._logger = _logger;
            this._configuration = configuration;
        }

        public async Task<List<CarModels>> GetCarByUserId(int userId)
        {
            List<CarModels> result = new();

            try
            {
                result= await CarByUserId(userId);
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;

        }

        private async Task<List<CarModels>> CarByUserId(int userId)
        {
            return await (from car in this._taxiDBContext.Cars
                          join user in this._taxiDBContext.Users on userId equals user.Id
                          where car.Delete == false && car.TaxiId == user.TaxiId
                          select new CarModels()
                          {
                              Id = car.Id
                          }).ToListAsync();
        }

    }
}
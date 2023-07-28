using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EstateManager : IEstateService
    {
        private readonly IEstateDal _estateDal;

        public EstateManager(IEstateDal estateDal)
        {
            _estateDal = estateDal;
        }

        public async Task CreateAsync(Estate entity)
        {
            await _estateDal.CreateAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            await _estateDal.DeleteAsync(id);
        }

        public async Task<IEnumerable<Estate>> GetAllAsync()
        {
            return await _estateDal.GetAllAsync();
        }

        public async Task<Estate> GetByIdAsync(string id)
        {
            return await _estateDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Estate entity, string id)
        {
            await _estateDal.UpdateAsync(entity, id);
        }
    }
}

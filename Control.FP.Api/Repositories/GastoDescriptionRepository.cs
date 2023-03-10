using Control.FP.Core.Entities;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Repositories;

public class GastoDescriptionRepository: IGastoDescriptionRepository
{
    public Task<GastoDescription> SaveAsync(GastoDescription gasto)
    {
        throw new NotImplementedException();
    }

    public Task<GastoDescription> UpdateAsync(GastoDescription gasto)
    {
        throw new NotImplementedException();
    }

    public Task<List<GastoDescription>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<GastoDescription> GetById(int id)
    {
        throw new NotImplementedException();
    }
}


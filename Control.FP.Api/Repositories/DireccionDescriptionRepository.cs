using Control.FP.Api.Repositories.Interfaces;
using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories;

public class DireccionDescriptionRepository: IDireccionDescriptionRepository
{
    public Task<DireccionDescription> SaveAsync(DireccionDescription direccion)
    {
        throw new NotImplementedException();
    }

    public Task<DireccionDescription> UpdateAsync(DireccionDescription direccimon)
    {
        throw new NotImplementedException();
    }

    public Task<List<DireccionDescription>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DireccionDescription> GetById(int id)
    {
        throw new NotImplementedException();
    }
}
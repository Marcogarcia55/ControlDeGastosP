using Control.FP.Core.Entities;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Repositories;

public class IngresosDescriptionRepository : IIngresoDescriptionRepository
{
    public Task<IngresosDescription> SaveAsync(IngresosDescription ingreso)
    {
        throw new NotImplementedException();
    }

    public Task<IngresosDescription> UpdateAsync(IngresosDescription ingreso)
    {
        throw new NotImplementedException();
    }

    public Task<List<IngresosDescription>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IngresosDescription> GetById(int id)
    {
        throw new NotImplementedException();
    }

}
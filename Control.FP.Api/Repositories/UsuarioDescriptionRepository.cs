using Control.FP.Core.Entities;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Repositories;

public class UsuarioDescriptionRepository: IUsuarioDescriptionRepository
{
    public Task<UsuarioDescription> SaveAsync(UsuarioDescription usuario)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioDescription> UpdateAsync(UsuarioDescription usuario)
    {
        throw new NotImplementedException();
    }

    public Task<List<UsuarioDescription>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioDescription> GetById(int id)
    {
        throw new NotImplementedException();
    }
}
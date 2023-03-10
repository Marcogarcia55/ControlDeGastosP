using Control.FP.Api.Repositories.Interfaces;
using Control.FP.Core.Entities;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Repositories;

public class InMemoryUsuarioControllerRepository: IUsuarioDescriptionRepository
{
    
    private readonly List<UsuarioDescription> _usuario;

    public InMemoryUsuarioControllerRepository()
    {
        _usuario = new List<UsuarioDescription>();
    }
    
    public async Task<UsuarioDescription> SaveAsync(UsuarioDescription usuario)
    {
        usuario.Id = _usuario.Count + 1;
        _usuario.Add(usuario);
        return usuario;
    }

    public async Task<UsuarioDescription> UpdateAsync(UsuarioDescription usuario)
    {
        var index = _usuario.FindIndex(x => x.Id == usuario.Id);
        
        if(index != -1)
        {
            _usuario[index] = usuario;
            
        }

        return await Task.FromResult(usuario);
    }

    public async Task<List<UsuarioDescription>> GetAllAsync()
    {
        
        return _usuario;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        _usuario.RemoveAll(x => x.Id == id);

        return true;
    }

    public async Task<UsuarioDescription> GetById(int id)
    {
        var usuario = _usuario.FirstOrDefault(x => x.Id == id);

        return await Task.FromResult(usuario);
    }
    
    
}
using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories.Interfaces;

public interface IUsuarioDescriptionRepository
{
    //Metodo para guardar categorias
    Task<UsuarioDescription> SaveAsync(UsuarioDescription usuario);
    
    //Metodo para Actualizar categorias
    Task<UsuarioDescription> UpdateAsync(UsuarioDescription usuario);

    //Metodo para retornar categorias
    Task<List<UsuarioDescription>> GetAllAsync();

    //Metodo para retornar una lista de categorias
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<UsuarioDescription> GetById(int id);
    
    
}
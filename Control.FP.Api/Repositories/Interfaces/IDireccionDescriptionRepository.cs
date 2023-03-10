using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories.Interfaces;

public interface IDireccionDescriptionRepository
{
    Task<DireccionDescription> SaveAsync(DireccionDescription direccion);
    
    //Metodo para Actualizar categorias
    Task<DireccionDescription> UpdateAsync(DireccionDescription direccion);

    //Metodo para retornar categorias
    Task<List<DireccionDescription>> GetAllAsync();

    //Metodo para retornar una lista de categorias
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<DireccionDescription> GetById(int id);
}
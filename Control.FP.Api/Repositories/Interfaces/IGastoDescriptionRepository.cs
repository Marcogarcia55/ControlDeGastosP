using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories.Interfaces;

public interface IGastoDescriptionRepository
{
    //Metodo para guardar categorias
    Task<GastoDescription> SaveAsync(GastoDescription gasto);
    
    //Metodo para Actualizar categorias
    Task<GastoDescription> UpdateAsync(GastoDescription gasto);

    //Metodo para retornar categorias
    Task<List<GastoDescription>> GetAllAsync();

    //Metodo para retornar una lista de categorias
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<GastoDescription> GetById(int id);
    
    
}
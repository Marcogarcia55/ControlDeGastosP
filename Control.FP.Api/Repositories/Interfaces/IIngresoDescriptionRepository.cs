using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories.Interfaces;

public interface IIngresoDescriptionRepository
{
    Task<IngresosDescription> SaveAsync(IngresosDescription ingreso);
    
    //Metodo para Actualizar categorias
    Task<IngresosDescription> UpdateAsync(IngresosDescription ingreso);

    //Metodo para retornar categorias
    Task<List<IngresosDescription>> GetAllAsync();

    //Metodo para retornar una lista de categorias
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<IngresosDescription> GetById(int id);
}
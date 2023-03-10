using Control.FP.Api.Repositories.Interfaces;
using Control.FP.Core.Entities;
using Control.FP.Api.Repositories.Interfaces;

namespace Control.FP.Api.Repositories;

public class InMemoryIngresoControllerRepository : IIngresoDescriptionRepository
{
    private readonly List<IngresosDescription> _ingreso;

    public InMemoryIngresoControllerRepository()
    {
        _ingreso = new List<IngresosDescription>();
    }

    public async Task<IngresosDescription> SaveAsync(IngresosDescription ingreso)
    {
        ingreso.Id = _ingreso.Count + 1;
        _ingreso.Add(ingreso);
        return ingreso;
    }

    public async Task<IngresosDescription> UpdateAsync(IngresosDescription ingreso)
    {
        var index = _ingreso.FindIndex(x => x.Id == ingreso.Id);

        if (index != -1)
        {
            _ingreso[index] = ingreso;

        }

        return await Task.FromResult(ingreso);
    }

    public async Task<List<IngresosDescription>> GetAllAsync()
    {

        return _ingreso;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        _ingreso.RemoveAll(x => x.Id == id);

        return true;
    }

    public async Task<IngresosDescription> GetById(int id)
    {
        var ingreso = _ingreso.FirstOrDefault(x => x.Id == id);

        return await Task.FromResult(ingreso);
    }

}
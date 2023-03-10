using Control.FP.Api.Repositories.Interfaces;
using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories;

public class InMemoryDireccionControllerRepository: IDireccionDescriptionRepository
{
    private readonly List<DireccionDescription> _direccion;

    public InMemoryDireccionControllerRepository()
    {
        _direccion = new List<DireccionDescription>();
    }

    public async Task<DireccionDescription> SaveAsync(DireccionDescription direccion)
    {
        direccion.Id = _direccion.Count + 1;
        _direccion.Add(direccion);
        return await Task.FromResult(direccion);
    }

    public async Task<DireccionDescription> UpdateAsync(DireccionDescription direccion)
    {
        var index = _direccion.FindIndex(x => x.Id == direccion.Id);

        if (index != -1)
        {
            _direccion[index] = direccion;
        }

        return await Task.FromResult(direccion);
    }

    public async Task<List<DireccionDescription>> GetAllAsync()
    {
        return await Task.FromResult(_direccion);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var gastoToRemove = _direccion.FirstOrDefault(x => x.Id == id);

        if (gastoToRemove != null)
        {
            _direccion.Remove(gastoToRemove);
            return await Task.FromResult(true);
        }

        return await Task.FromResult(false);
    }

    public async Task<DireccionDescription> GetById(int id)
    {
        var direccion = _direccion.FirstOrDefault(x => x.Id == id);
        return await Task.FromResult(direccion);
    }
}
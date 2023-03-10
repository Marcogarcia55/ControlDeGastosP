using Control.FP.Api.Repositories.Interfaces;
using Control.FP.Core.Entities;

namespace Control.FP.Api.Repositories;

public class InMemoryGastoControllerRepository: IGastoDescriptionRepository
{
    private readonly List<GastoDescription> _gasto;

    public InMemoryGastoControllerRepository()
    {
        _gasto = new List<GastoDescription>();
    }

    public async Task<GastoDescription> SaveAsync(GastoDescription gasto)
    {
        gasto.Id = _gasto.Count + 1;
        _gasto.Add(gasto);
        return await Task.FromResult(gasto);
    }

    public async Task<GastoDescription> UpdateAsync(GastoDescription gasto)
    {
        var index = _gasto.FindIndex(x => x.Id == gasto.Id);

        if (index != -1)
        {
            _gasto[index] = gasto;
        }

        return await Task.FromResult(gasto);
    }

    public async Task<List<GastoDescription>> GetAllAsync()
    {
        return await Task.FromResult(_gasto);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var gastoToRemove = _gasto.FirstOrDefault(x => x.Id == id);

        if (gastoToRemove != null)
        {
            _gasto.Remove(gastoToRemove);
            return await Task.FromResult(true);
        }

        return await Task.FromResult(false);
    }

    public async Task<GastoDescription> GetById(int id)
    {
        var gasto = _gasto.FirstOrDefault(x => x.Id == id);
        return await Task.FromResult(gasto);
    }
}

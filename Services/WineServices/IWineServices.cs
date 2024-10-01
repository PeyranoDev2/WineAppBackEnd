using Common.Models;

namespace Services.WineServices
{
    public interface IWineServices
    {
        void AddWine(WineForCreateDTO wineForCreateDTO);
        Dictionary<string, int> GetAllWinesStock();
    }
}
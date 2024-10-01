using Common.Models;
using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.WineServices
{
    public class WineServices : IWineServices
    {
        public readonly IWineRepository _wineRepository;
        public WineServices(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }


        public void AddWine(WineForCreateDTO wineForCreateDTO)
        {
            if (_wineRepository.GetWines().All(wine => wine.Name != wineForCreateDTO.Name))
            {
                _wineRepository.AddWine(
                new Wine
                {
                    Id = _wineRepository.GetWines().Max(x => x.Id) + 1,
                    Name = wineForCreateDTO.Name,
                    Variety = wineForCreateDTO.Variety,
                    Year = wineForCreateDTO.Year,
                    Region = wineForCreateDTO.Region,
                    Stock = wineForCreateDTO.Stock,
                    CreatedAt = DateTime.UtcNow,
                }
                );
            }
            else throw new InvalidOperationException();
        }

        public Dictionary<string, int> GetAllWinesStock()
        {
            return _wineRepository.GetAllWinesStock();
        }
    }
}
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class WineRepository : IWineRepository
    {
        private List<Wine> wines = new List<Wine>()
        {
            new Wine
            {
                Id = 1,
                Name = "Malbec Gran Reserva",
                Variety = "Malbec",
                Year = 2017,
                Region = "Bourgogne",
                Stock = 60,
                CreatedAt = new DateTime(2019, 8, 25)
            },
            new Wine
            {
                Id = 2,
                Name = "Malbec Single Vineyard",
                Variety = "Malbec",
                Year = 2016,
                Region = "Napa Valley",
                Stock = 45,
                CreatedAt = new DateTime(2020, 4, 18)
            },
            new Wine
            {
                Id = 3,
                Name = "Malbec Reserva Especial",
                Variety = "Malbec",
                Year = 2018,
                Region = "Sonoma",
                Stock = 80,
                CreatedAt = new DateTime(2021, 7, 12)
            },
            new Wine
            {
                Id = 4,
                Name = "Malbec Edición Limitada",
                Variety = "Malbec",
                Year = 2020,
                Region = "Marlborough",
                Stock = 35,
                CreatedAt = new DateTime(2022, 9, 5)
            },
            new Wine
            {
                Id = 5,
                Name = "Malbec Cosecha Especial",
                Variety = "Malbec",
                Year = 2021,
                Region = "Rioja",
                Stock = 20,
                CreatedAt = new DateTime(2023, 3, 27)
            }
        };
        public List<Wine> GetWines()
        {
            return wines;
        }
        public void AddWine(Wine wine)
        {
            wines.Add(wine);
        }
        public Dictionary<string, int> GetAllWinesStock()
        {
            return wines.ToDictionary(wine => wine.Name, wine => wine.Stock);
        }
    }
}

using Course.Data.Interfaces;
using Course.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Data.mocks
{
    public class MockUnits : IAllUnits
    {
        private readonly IUnitsCategory _CategoryUnits = new MockCategory();
        public IEnumerable<Unit> getUnits {
            get {
                return new List<Unit> {
                    new Unit { Name = "Primaris Captain", shortDesk = "Первый парень на селе",
                        longDesk = "Капитаны Космодесанта – одновременно превосходные воители и одарённые полководцы, командующие в бою ротами Адептус Астартес.",
                        img = "https://www.games-workshop.com/resources/catalog/product/920x950/99120101179_PrimarisCaptain01.jpg", price = 5, isFavourite = true, available = 1, Category = _CategoryUnits.getAllCategories.First() },
                    new Unit { Name = "Intercessor Squad", shortDesk = "Стоим-стреляем",
                        longDesk = "Заступники — это ядро любой ударной группировки космодесантников-примарис.",
                        img = "https://www.games-workshop.com/resources/catalog/product/920x950/99120101190_PrimarisIntercessors01.jpg", price = 5, isFavourite = true, available = 3, Category = _CategoryUnits.getAllCategories.ElementAt(2) },
                    new Unit { Name = "Hellblaster Squad", shortDesk = "Главное - не кинуть кол",
                        longDesk = "Изничтожители — отряды, составленные из превосходных стрелков, обеспечивающие группировкам космодесантников-примарис опустошительную огневую мощь на средней дистанции.",
                        img = "https://www.games-workshop.com/resources/catalog/product/920x950/99120101189_PrimarisHellblasters01.jpg", price = 8, isFavourite = true, available = 3, Category = _CategoryUnits.getAllCategories.Last() },
                    new Unit { Name = "Deathwing Terminators", shortDesk = "А ты часом не Падший?",
                        longDesk = "Отделения терминаторов – неукротимые воины, разносящие врага на части шквальным огнём штормболтеров.",
                        img = "https://www.games-workshop.com/resources/catalog/product/920x950/99120101096_DeathwingTerminators01.jpg", price = 9, isFavourite = false, available = 0, Category = _CategoryUnits.getAllCategories.ElementAt(3) }
                };
            }
        }
        public IEnumerable<Unit> getFavouriteUnits { get; set; }

        public Unit getUnit(int UnitID)
        {
            throw new NotImplementedException();
        }
    }
}

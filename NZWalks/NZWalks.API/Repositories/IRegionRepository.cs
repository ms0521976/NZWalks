using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        //Asynchronous非同步執行
       Task<IEnumerable<Region>> GetAllAsync();
    }
}


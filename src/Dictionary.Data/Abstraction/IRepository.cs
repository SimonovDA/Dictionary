using System.Threading.Tasks;
using Dictionary.Data.Models;

namespace Dictionary.Data.Abstraction
{
    public interface IRepository<T>
        where T : BaseEntry
    {
        Task<T> Get(string id);
        Task<T> Create(T value);
        Task Delete(T value);
        Task Update(T value);
    }
}

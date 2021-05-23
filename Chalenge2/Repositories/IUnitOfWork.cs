
using System.Threading.Tasks;

namespace Challenge2.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}

using Truestory.model;

namespace Truestory.Repositories
{
    public interface IGadgetRepo
    {
        int AddLaptop(Gadget msg);
        IEnumerable<Gadget> GetAllLaptops();
        void Remove(Gadget recordToDelete);
    }
}

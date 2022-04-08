using DL;

namespace BL;
public class RRGBL : IRobsBL
{

    private readonly IRepository _repo;
    public RRGBL(IRepository repo)
    {
        _repo = repo;
    }
    public void CreateRequest(Inventory requestToCreate)
    {
        _repo.CreateRequest(requestToCreate);
    }

    public List<Inventory> GetInventory()
    {
        return _repo.GetInventories();
    }

    public void SoldOut(Inventory markAsSold)
    {
        StaticStorage.Items.Remove(markAsSold);
    }
}

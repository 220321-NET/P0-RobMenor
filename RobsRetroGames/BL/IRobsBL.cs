using DL;

namespace BL;

public interface IRobsBL
{
    void CreateRequest(Inventory requestToCreate);

    List<Inventory> GetInventory();

        public void SoldOut(Inventory markAsSold)
    {
        StaticStorage.Items.Remove(markAsSold);
    }
}
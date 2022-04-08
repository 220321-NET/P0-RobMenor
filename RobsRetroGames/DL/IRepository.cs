namespace DL;

/// <summary>
/// interface for accessing data in RobsRetroGames
/// </summary>
public interface IRepository
{
    /// <summary>
    /// adds a request
    /// </summary>
    /// <param name="requestToCreate">request object to be inserted</param>
    void CreateRequest(Inventory requestToCreate);

/// <summary>
/// retrieves all inventories
/// </summary>
/// <returns>list of inventories, if empty, returns empty list</returns>
    List<Inventory> GetInventories();

/// <summary>
/// Updates request of inventory object
/// </summary>
/// <param name="requestToUpdate">the inventory item that has new request</param>
    void UpdateRequest(Inventory requestToUpdate);
}
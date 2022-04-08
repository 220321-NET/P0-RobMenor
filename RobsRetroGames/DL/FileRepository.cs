using System.Text.Json;

namespace DL;

public class FileRepository : IRepository
{
    private readonly string filePath = "../DL/StackLite.json";

    /// <summary>
    /// Gets all inventories from stacklite.json
    /// </summary>
    /// <returns>list of items, if none, returns empty list</returns>
    public List<Inventory> GetInventories()
    {
        string jsonString = "";

        try
        {
            jsonString = File.ReadAllText(filePath);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            
        }

        List<Inventory> items = new List<Inventory>();

        try
        {
            items = JsonSerializer.Deserialize<List<Inventory>>(jsonString) ?? new List<Inventory>();
        }
        catch(JsonException ex)
        {
            Console.WriteLine("There was a problem with the format of jsonString");
            Console.WriteLine(ex.Message);
        }

        return items;
    }

/// <summary>
/// inserts a new json request object to stacklite.json
/// </summary>
/// <param name="requestToCreate">a request object to be inserted</param>
    public void CreateRequest(Inventory requestToCreate)
    {
        if(requestToCreate == null) throw new ArgumentNullException();

        List<Inventory> allItems = GetInventories();
        allItems.Add(requestToCreate);

        string jsonString = JsonSerializer.Serialize(allItems);
        File.WriteAllText(filePath, jsonString);
    }

    public void UpdateRequest(Inventory requestToUpdate)
    {
        if(requestToUpdate == null) throw new ArgumentNullException();
        List<Inventory> allItems = GetInventories();

        Inventory foundItem = allItems.FirstOrDefault(g => g.GameSystem == requestToUpdate.GameSystem && g.Title == requestToUpdate.Title);

        foundItem.Quantity = requestToUpdate.Quantity;
    }
}
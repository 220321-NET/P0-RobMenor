namespace Models;

public class Demand : TextEntry
{
    public bool IsSelected { get; set; }

    public override string ToString()
    {
        return $"Date Created: {DateCreated} /nTitle: {Title} /nPrice: {Price} /nSelected: {IsSelected} /nQuantity: {Quantity}";
    }

}
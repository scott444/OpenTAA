namespace OpenTAA;

public class AssetValue
{
    public Guid AssetId {get;set;}
    public Asset? Asset {get;set;}
    public decimal Value {get;set;}
    public DateTime Date {get;set;}
}

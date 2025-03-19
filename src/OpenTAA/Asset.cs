namespace OpenTAA;

public class Asset
{
    public required string Symbol {get;set;}
    public Guid AssetClassId {get;set;}
    public AssetClass? AssetClass {get;set;}
    public Guid ExchangeId {get;set;}
    public Exchange? Exchange {get;set;}
    public List<AssetValue>? AssetValues {get;set;}
}

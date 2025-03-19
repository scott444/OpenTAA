namespace OpenTAA;

public class StrategyAsset
{
    public Guid StrategyId {get;set;}
    public Strategy? Strategy {get;set;}
    public Guid AssetId {get;set;}
    public Asset? Asset {get;set;}
}
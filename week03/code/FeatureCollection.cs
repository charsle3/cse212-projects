using System.Diagnostics.CodeAnalysis;

public class FeatureCollection
{
    public Feature[] Features { get; set; }
}

public class Feature
{
    public Property properties { get; set; }
}

public class Property
{
    public decimal mag { get; set; }
    public string place { get; set; }
}
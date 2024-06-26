#nullable enable
using System.Collections.Generic;
using Couchbase.Core.Compatibility;
using Stj = System.Text.Json.Serialization;
using NSft = Newtonsoft.Json;

namespace Couchbase.Search.Queries.Vector;

[InterfaceStability(Level.Committed)]
public sealed record VectorSearch(
    [property: Stj.JsonPropertyName(VectorSearch.PropVectorQueries)]
    [property: NSft.JsonProperty(VectorSearch.PropVectorQueries)]
    ICollection<VectorQuery> VectorQueries,
    VectorSearchOptions? Options)
{
    /// <summary>
    /// "K Nearest Neighbor"
    /// </summary>
    internal const string PropVectorQueries = "knn";

    internal const string PropVectorQueryCombination = "knn_operator";

    [Stj.JsonPropertyName(PropVectorQueryCombination)]
    [Stj.JsonIgnore(Condition = Stj.JsonIgnoreCondition.WhenWritingNull)]
    [NSft.JsonProperty(PropVectorQueryCombination, NullValueHandling = NSft.NullValueHandling.Ignore)]
    public string? VectorQueryCombination => Options?.VectoryQueryCombination?.ToString()?.ToLowerInvariant();
    public static VectorSearch Create(VectorQuery vectorQuery, VectorSearchOptions? options = null) =>
        new VectorSearch(new[] { vectorQuery }, options);

    public static VectorSearch Create(ICollection<VectorQuery> vectorQueries, VectorSearchOptions? options = null) =>
        new VectorSearch(vectorQueries, options);
}

[InterfaceStability(Level.Committed)]
public sealed record VectorSearchOptions(VectorQueryCombination? VectoryQueryCombination = null);

[InterfaceStability(Level.Committed)]
public enum VectorQueryCombination
{
    And = 0,
    Or = 1,
}
